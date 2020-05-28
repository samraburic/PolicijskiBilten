using Bilten.Model;
using Bilten.Model.Requests.Mugshot;
using Bilten.Model.Requests.Osoba;
using Bilten.Model.Requests.OsobeMugshot;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using TextmagicRest;
using TextmagicRest.Model;
using System.Net.Mail;

namespace Bilten.WinUI
{
    public partial class frmFaceDetectionRecognition : Form
    {
        private Capture camera;
        private HaarCascade faceDetection;

        private readonly APIService _mugshots = new APIService("Mugshot");
        private readonly APIService _osobe = new APIService("Osoba");
        private readonly APIService _osobeMugshots = new APIService("OsobeMugshot");
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        string name, names = null;
        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
        List<string> labels = new List<string>();
        Image<Bgr, Byte> Frame;
        Image<Gray, Byte> grayFace = null;
        Image<Gray, byte> result;
        List<string> Users = new List<string>();
        List<string> imena = new List<string>();
        int count = 0;

        public frmFaceDetectionRecognition()
        {
            InitializeComponent();
        }

        private async void ProcessFrame(object sender, EventArgs arg)
        {
            Users.Add("");
            Frame = camera.QueryFrame().Resize(320,240,Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();

            MCvAvgComp[][] faces = grayFace.DetectHaarCascade(faceDetection,
                                                    1.2,
                                                    10,
                                                    HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                                    new Size(20, 20));

            foreach (MCvAvgComp face in faces[0])
            {
                result = Frame.Copy(face.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);//1
                Frame.Draw(face.rect, new Bgr(Color.Green), 3);

                if (trainingImages.ToArray().Length != 0)
                {
                    var list = await _mugshots.Get<List<Model.Mugshot>>(null);
                    MCvTermCriteria termCriterias = new MCvTermCriteria(list.Count(), 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer
                        (trainingImages.ToArray(), labels.ToArray(), 3000, ref termCriterias);
                    name = recognizer.Recognize(result);
                    Frame.Draw(name, ref font, new Point(face.rect.X - 2, face.rect.Y - 2), new Bgr(Color.Red));
                }
                Users.Add("");
            }
            CamImageBox.Image = Frame;
            names = "";
            ProvjeraOsobe(name);
        }

        private async void ProvjeraOsobe(string ime)
        {
            if (ime != "" && ime!=null)
            {
                imena.Add(ime);
                if (count != 0)
                {
                    string ime1 = imena.ToArray()[imena.ToArray().Length - 2];
                    string ime2 = imena.ToArray()[imena.ToArray().Length - 1];
                    if (ime1 == ime2)
                    {
                        return;
                    }
                }

                count++;
                var request = new OsobaSearchRequest()
                {
                    Ime = ime
                };

                var osoba = await _osobe.Get<List<Model.Osoba>>(request);

                if (osoba != null)
                {
                    foreach (var item in osoba)
                    {
                        if (item.Potraga == true)
                        {
                            MessageBox.Show("Osoba " + item.Ime + " se trazi!!!");
                            string poruka = "Osoba " + item.Ime + " " + item.Prezime + " (JMBG:" + item.Jmbg + ", Br. lične karte:" + item.BrLicneKarte + ") je viđena na kameri (LOKACIJA KAMERE) u " + DateTime.Now;
                            //Mail(poruka);
                        }
                    }
                }
            }
            else
                return;
        }

        //private void Mail(string poruka)
        //{
        //    MailMessage mail = new MailMessage("rocknload96@gmail.com",
        //                "samraburic0@gmail.com",
        //                "Uočena osoba sa potjernice  - " + DateTime.Now.Date.ToString("dd.MM.yyyy"),
        //                poruka);

        //    SmtpClient client = new SmtpClient("smtp.gmail.com");
        //    client.Port = 587;
        //    client.Credentials = new System.Net.NetworkCredential("rocknload96@gmail.com", "Sb20082014");
        //    client.EnableSsl = true;
        //    client.Send(mail);
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(ProcessFrame);
        }

        private async void frmFaceDetectionRecognition_Load(object sender, EventArgs e)   
        {
            faceDetection = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                var listMugshots = await _mugshots.Get<List<Model.Mugshot>>(null);
                foreach (var item in listMugshots)
                {
                    trainingImages.Add(new Image<Gray, byte>(item.MugshotPath));
                    var listOsobeMugshots = await _osobeMugshots.Get<List<Model.OsobeMugshot>>(new OsobeMugshotSearchRequest()
                    {
                        MugshotId = item.Id
                    });

                    foreach (var itemOM in listOsobeMugshots)
                    {
                        int OsobaId = itemOM.OsobaId;
                        var osoba = await _osobe.GetById<Model.Osoba>(OsobaId);
                        labels.Add(osoba.Ime);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong!");
            }
        }

        private void btnOsobe_Click(object sender, EventArgs e)
        {
            frmOsobe frm = new frmOsobe();
            frm.Show();
        }

        private void btnDodajOsobuSlike_Click(object sender, EventArgs e)
        {
            frmDodajOsobu frm = new frmDodajOsobu();
            frm.Show();
        }
    }
}
