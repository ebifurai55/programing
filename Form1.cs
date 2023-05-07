using Microsoft.Web.WebView2.Core;
using System;
using System.Windows.Forms;

namespace AmaterasuVer1
{
    public partial class Form1 : Form
    {
        private async Task InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await InitializeAsync();

            webView21.CoreWebView2.Navigate("https://web.biz-prog.net/");
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
            this.Text = webView21.CoreWebView2.DocumentTitle.ToString();
        }

        private void Fwd_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
            this.Text = webView21.CoreWebView2.DocumentTitle.ToString();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
            this.Text = webView21.CoreWebView2.DocumentTitle.ToString();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Stop();
        }


        private void UrlList_SelectedIndexChanged(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate(UrlList.Text);

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate(UrlList.Text);
            this.Text = webView21.CoreWebView2.DocumentTitle.ToString();
        }
        private void UrlList_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                webView21.CoreWebView2.Navigate(UrlList.Text);
                this.Text = webView21.CoreWebView2.DocumentTitle.ToString();
                UrlList.Items.Add(UrlList.Text);

            }
        }
        // Updates the title bar with the current document title.

        private void webView21_Navigating(object sender, WebBrowserNavigatedEventArgs e)
        {
            setNavigate(false);

        }
        private void webView21_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            setNavigate(true);

            //UrlList.Text = webView21.Source.ToString();

            //UrlList.Items.Add(webView21.Source.ToString());

            //UrlList.Items[i].Add(UrlList.Text);
            //for (i = 0; i < UrlList.Items.Count; i++)
            //{
            //    if (UrlList.Items[i] == UrlList.Text)
            //    {
            //        break;
            //    }
            //    if (i <= UrlList.Items.Count)
            //    {
            //        UrlList.Items.Add(UrlList.Text);
            //
            //     }
            //     }



        }
        private void setNavigate(bool ena)
        {
            if (ena == true)
            {
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = true;
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void お気に入りに追加_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void setting_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this); // 自フォームへの参照を渡す
            f2.Show(); // サブ・フォームを表示
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this); // 自フォームへの参照を渡す
            form3.Show(); // サブ・フォームを表示
        }

        
    }
}
// ...

