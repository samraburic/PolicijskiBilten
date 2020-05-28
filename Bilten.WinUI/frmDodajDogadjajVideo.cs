using Bilten.Model.Requests.DogadjajVideo;
using Bilten.Model.Requests.Video;
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
    public partial class frmDodajDogadjajVideo : Form
    {
        private readonly APIService _video = new APIService("Video");
        private readonly APIService _dogadjajVideo = new APIService("DogadjajVideo");

        private int? _dogadjajId = null;

        public frmDodajDogadjajVideo(int? dogadjajId = null)
        {
            InitializeComponent();
            _dogadjajId = dogadjajId;
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var video = await _video.Insert<Bilten.Model.Video>(new VideoUpsertRequest()
            {
                Naziv = txtNaziv.Text,
                Url = txtUrl.Text
            });

            await _dogadjajVideo.Insert<Bilten.Model.DogadjajVideo>(new DogadjajVideoUpsertRequest()
            {
                VideoId = video.Id,
                DogadjajId = _dogadjajId.Value
            });
            MessageBox.Show("Video " + video.Naziv + " spašen u dogadjaj " + _dogadjajId.ToString());

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                wbVideo.Navigate(txtUrl.Text);
            }
        }
    }
}
