using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Json.Net;
using Microsoft.VisualBasic;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string startUrl = "https://demo-odoo.acesy.nl/";
        public string pathString = System.Environment.CurrentDirectory;
        public string fileName = "config.json";

        public Form1()
        {
            this.LoadJson();
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView21.NavigationStarting += EnsureHttps;
            webView21.ContentLoading += onPaintLoanding;
            webView21.NavigationStarting += onPaintLoanding2;
            webView21.NavigationCompleted += onPaintN; 
            InitializeAsync();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            containerControl3.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
        }
        public void LoadJson()
        {
            string objectx = "{" + "url" + ": '" + startUrl + "'}";
            string pathStringLocal = System.IO.Path.Combine(pathString, fileName);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>", pathStringLocal);
            pathString = pathStringLocal;
            if (!System.IO.File.Exists(pathStringLocal))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathStringLocal))
                {
                    fs.Close();
                    fs.Dispose();
                    this.on_save_url(startUrl);
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);

                using (System.IO.StreamReader r = new System.IO.StreamReader(pathStringLocal))
                {
                    string json = File.ReadAllText(pathStringLocal);
                    Console.Write(">>>><<<<<<<<<>> "+json);
                    if (json != null && json.Trim() != "")
                    {
                        Console.Write(pathString);
                        Console.Write("____________DIM_____________");
                        Console.Write(json);
                        dynamic j = JsonConvert.DeserializeObject(json);
                        Console.Write(j.url);
                        startUrl = j.url;
                        Console.WriteLine(startUrl+" 666>>Second");
                    }
                    else
                    {
                        Console.Write("This is alternative" + "ALter");
                        r.Close();
                        r.Dispose();
                        this.on_save_url(startUrl);

                    }
                }

            }


        }
        private void navigate()
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(startUrl);
            }
        }
        void onPaintN(object sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            spinner.Visible = false;
            Console.WriteLine(">>>>>Navigation completed++++++++++");
        }

        private void onReload()
        {
            webView21.Reload();
        }
        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                //args.Cancel = true;
            }
        }
        void onPaintLoanding2(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            spinner.Visible = true;
            goback.Enabled = webView21.CanGoBack;
            goForward.Enabled = webView21.CanGoForward;
        }
        
        void onCompleted(object sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            spinner.Visible = true;
            goback.Enabled = webView21.CanGoBack;
            goForward.Enabled = webView21.CanGoForward;
        }

        void onPaintLoanding(object sender, CoreWebView2ContentLoadingEventArgs args)
        {
            spinner.Visible = true;

            if (webView21.CanGoBack)
            {
                goback.Enabled = true;
            }
            else
            {
                goback.Enabled = false;
            }

            if (webView21.CanGoForward)
            {
                goForward.Enabled = true;
            }
            else
            {
                goForward.Enabled = false;
            }
            Console.WriteLine(">>>>>Is loandign stated++++++++++");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void onclick_back(object sender, EventArgs e)
        {
            Console.WriteLine("_______GoBack_______________");
            webView21.GoBack();
        }
        private void onclick_next(object sender, EventArgs e)
        {

            Console.WriteLine("_______GoForward_________________");
            webView21.GoForward();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void appUrl_click(object sender, EventArgs e)
        {
            Console.WriteLine("App_url onClick ==>");
            string interaction = Interaction.InputBox("Please an app url", "Setting app url", startUrl, -1, -1);
            //var result = InputBox.Show("Enter a new value", "Change Settings", "Default");
            Console.WriteLine(interaction);
            if (interaction != null && interaction.Trim() != "")
            {
                this.on_save_url(interaction);
            }
                



        }
        public void on_save_url(string interaction)
        {
            //pathString = System.IO.Path.Combine(pathString, fileName);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
            string objectx = "{" + "url" + ": '" + interaction + "'}";
            startUrl = interaction;
            System.IO.StreamWriter w = new System.IO.StreamWriter(pathString);
            w.Write(objectx);
            w.Close();
            w.Dispose();
            this.onReturn(null, null);
        }

        private void containerControl2_Click(object sender, EventArgs e)
        {

        }
        public void onOpenUrl(object sender, EventArgs e)
        {
            //webView.Source = new System.Uri(startUrl);
            this.onOp();
            
        }
        async void onOp()
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                Console.WriteLine(startUrl);
                Console.WriteLine("********************************");
                //webView.CoreWebView2.Navigate(startUrl);
                //webView21.CoreWebView2.Navigate(startUrl);
                //webView21.Source = new System.Uri(startUrl);
                Console.WriteLine(webView21.Source);
                this.MaximizeBox = true;
                this.MinimizeBox = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
                webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
                containerControl3.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);

                containerControl4.Visible = false;
                containerControl3.Visible = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                DialogResult res = MessageBox.Show("Please wait a second, initialisation is ongoing ...", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                /*
                if (res == DialogResult.OK || res == DialogResult.Cancel)
                {
                    this.onOp(); 
                }
                */
            }
        }

        public void onReturn(object sender, EventArgs e)
        {
            
            containerControl3.Visible = false;
            containerControl4.Visible = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeAsync();

        }
        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            Console.WriteLine(startUrl + " 666>>Second");
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                Console.WriteLine("_______________________________________________________");
                webView21.Source = new System.Uri(startUrl);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void containerControl2_Click_1(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void containerControl3_Click(object sender, EventArgs e)
        {

        }

        private void spinner_Click(object sender, EventArgs e)
        {

        }
    }
}


