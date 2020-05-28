using Bilten.Model;
using Bilten.Model.Requests.DogadjajVideo;
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
    public partial class frmDogadjajVideo : Form
    {
        private readonly APIService _video = new APIService("Video");
        private readonly APIService _dogadjajVideo = new APIService("DogadjajVideo");

        private int? _dogadjajId = null;
        public frmDogadjajVideo(int? dogadjajId = null)
        {
            InitializeComponent();
            _dogadjajId = dogadjajId;
        }

        private async void frmDogadjajVideo_Load_1(object sender, EventArgs e)
        {
            await LoadVidea();

        }

        private async Task LoadVidea()
        {
            var dogadjajVideos = await _dogadjajVideo.Get<List<Bilten.Model.DogadjajVideo>>(new DogadjajVideoSearchRequest()
            {
                DogadjajId = _dogadjajId
            });

            foreach (var item in dogadjajVideos)
            {
                var result = await _video.GetById<Bilten.Model.Video>(item.VideoId);
                cmbVideo.Items.Add(result);
            }

            cmbVideo.DisplayMember = "Naziv";
            cmbVideo.ValueMember = "Url";
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var video = await _video.GetById<Bilten.Model.Video>((cmbVideo.SelectedItem as Model.Video).Id);

            //_yUrl = video.Url;//"https://www.youtube.com/watch?v=sBAAgrQBCxc"
            webBrowser1.Navigate(video.Url);//http://youtube.com/v/sBAAgrQBCxc?version=3

        }

    }
}
