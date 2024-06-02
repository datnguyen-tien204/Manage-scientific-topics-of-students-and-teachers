using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace GUI
{
    public partial class uc_FindScholar : UserControl
    {
        public uc_FindScholar()
        {
            InitializeComponent();
        }
        private async Task initalized()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void LoadWeb(string url)
        {
            await initalized();
            webView21.CoreWebView2.Navigate(url);
            webView21.ZoomFactor = 0.85;
        }

        private void uc_FindScholar_Load(object sender, EventArgs e)
        {
            LoadWeb("https://scholar.google.com/");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null && webView21.CoreWebView2.CanGoBack)
            {
                webView21.CoreWebView2.GoBack();
            }
            else
            {
                MessageBox.Show("You can't back.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }
    }
}
