using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_Manage_Settings : UserControl
    {
        public uc_Manage_Settings()
        {
            InitializeComponent();
        }

        private void btn_visitFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/datnguyen-tien204";
            Process.Start(url);
        }

        private void btn_visitZalo_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/charrise.elaina";
            Process.Start(url);
        }

        private void btn_visitYouTube_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/charrise.elaina";
            Process.Start(url);
        }

        private void btn_visitInstagram_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/_ngtdt204/";
            Process.Start(url);
        }

        private void btn_visitGithub_Click(object sender, EventArgs e)
        {
            string url = "https://huggingface.co/datnguyentien204";
            Process.Start(url);
        }

        private void btn_visitTelegram_Click(object sender, EventArgs e)
        {
            string url = "https://weibo.com/u/7730984206";
            Process.Start(url);
        }

        private void btn_visitTwitter_Click(object sender, EventArgs e)
        {
            string url = "https://www.xiaohongshu.com/user/profile/625adc0e0000000010009a74";
            Process.Start(url);
        }
    }
}
