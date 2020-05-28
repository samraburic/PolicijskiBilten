using Bilten.Model;
using Bilten.Model.Requests.Mugshot;
using Bilten.Model.Requests.Osoba;
using Bilten.Model.Requests.OsobeMugshot;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI
{
    public partial class frmDodajOsobu : Form
    {
        private readonly APIService _osobe = new APIService("Osoba");
        private readonly APIService _mugshots = new APIService("Mugshot");
        private readonly APIService _osobeMugshots = new APIService("OsobeMugshot");

        private Capture camera;
        private HaarCascade faceDetection;
        Image<Bgr, Byte> Frame;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace = null;
        Image<Gray, byte> grayFace = null;
        Osoba osoba;
        

        public frmDodajOsobu()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new OsobaUpsertRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Jmbg = txtJMBG.Text,
                BrLicneKarte = txtBrLicneKarte.Text,
                DatumRodjenja = calDatumRodjenja.Value
            };

            await _osobe.Insert<Model.Osoba>(request);

            var temp = await _osobe.Get<List<Model.Osoba>>(new OsobaSearchRequest
            {
                Jmbg = txtJMBG.Text
            });

            foreach (var item in temp)
            {
                osoba = item;
            }

            MessageBox.Show("Osoba uspješno dodana !");
        }

        private void frmDodajOsobu_Load(object sender, EventArgs e)
        {
            faceDetection = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(ProcessFrame);
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();

            var faces = grayFace.DetectHaarCascade(faceDetection, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                    new Size(20, 20))[0];

            foreach (var face in faces)
            {
                result = Frame.Copy(face.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame.Draw(face.rect, new Bgr(Color.Green), 3);
                pbExtractedFaces.Image = result.ToBitmap();
            }
            CamImageBox.Image = Frame;
        }

        private async void btnDodajSliku_Click(object sender, EventArgs e)
        {
            grayFace = camera.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            var faces = grayFace.DetectHaarCascade(faceDetection, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                    new Size(20, 20))[0];

            foreach (var face in faces)
            {
                TrainedFace = Frame.Copy(face.rect).Convert<Gray, byte>();
                break;
            }

            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            string naziv = osoba.Ime + "_" + osoba.Id + "." + txtNazivSlike.Text;
            MessageBox.Show(naziv);
            txtNazivSlike.Clear();

            TrainedFace.Save(Application.StartupPath + "\\Faces\\" + naziv + ".bmp");

            string path = Application.StartupPath + "\\Faces\\" + naziv + ".bmp";

            var noviMugshot = await _mugshots.Insert<Model.Mugshot>(new MugshotUpsertRequest()
            {
                MugshotPath = path
            });

            await _osobeMugshots.Insert<Model.OsobeMugshot>(new OsobeMugshotUpsertRequest()
            {
                MugshotId = noviMugshot.Id,
                OsobaId = osoba.Id
            });

        }
    }
}
