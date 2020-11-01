using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Updater
{
#pragma warning disable CS0436
    public partial class Main : Form
    {
        WebClient webClient;
        Stopwatch sw = new Stopwatch();
        public Main()
        {
            InitializeComponent();
        }
        void InitializeRepo()
        {
            GithubNET.Users.SelectUser("lysep-corp");
            GithubNET.Repository.SelectRepository("CoreCheatCSGO-LSREMAKE");
        }
        void CheckForCheatUpdates()
        {
            var LastVersion = GithubNET.Repository.LatestReleasesUrl;
            var OldVersion = Datas.Default.OldVersionLink;
            if ((LastVersion != OldVersion) || !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "core.exe"))
            {
                circularProgressBar1.Visible = true;
                try
                {
                    DownloadFile(LastVersion, AppDomain.CurrentDomain.BaseDirectory + "cheat.zip");
                    Datas.Default.OldVersionLink = LastVersion;
                    Datas.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            else
            {
                StartCheat();
            }
        }
        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                       | SecurityProtocolType.Tls11
                       | SecurityProtocolType.Tls12
                       | SecurityProtocolType.Ssl3;
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri URL = urlAddress.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);
                sw.Start();
                try
                {
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            circularProgressBar1.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
                Environment.Exit(0);
            }
            else
            {
                circularProgressBar1.Visible = false;
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "core.exe"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "core.exe");
                ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + "cheat.zip", Directory.GetCurrentDirectory());
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "cheat.zip");
                StartCheat();
            }
        }
        private void StartCheat()
        {
            MD5Controller.MD5Controller.ChangeMD5(AppDomain.CurrentDomain.BaseDirectory + "core.exe");
            var proc = Process.Start(AppDomain.CurrentDomain.BaseDirectory + "core.exe", "-updaterOut");
            if (proc.Id > 0)
            {
                Sleep(3000);
                Environment.Exit(0);
            }
        }
        void Sleep(int msec)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (msec == 0 || msec < 0) return;
            timer1.Interval = msec;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
                Application.DoEvents();
        }
        uint i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColorPanel.ColorLeft = ColorTranslator.FromHtml(Rainbow(100, i % 100));
            BackColorPanel.ColorRight = ColorTranslator.FromHtml(Rainbow(50, i % 50));
            BackColorPanel.Refresh();
            if (i == uint.MaxValue)
                i = 0;
            i++;
        }
        public static string Rainbow(int numOfSteps, uint step)
        {
            var r = 0.0;
            var g = 0.0;
            var b = 0.0;
            var h = (double)step / numOfSteps;
            var i = (int)(h * 6);
            var f = h * 6.0 - i;
            var q = 1 - f;

            switch (i % 6)
            {
                case 0:
                    r = 1;
                    g = f;
                    b = 0;
                    break;
                case 1:
                    r = q;
                    g = 1;
                    b = 0;
                    break;
                case 2:
                    r = 0;
                    g = 1;
                    b = f;
                    break;
                case 3:
                    r = 0;
                    g = q;
                    b = 1;
                    break;
                case 4:
                    r = f;
                    g = 0;
                    b = 1;
                    break;
                case 5:
                    r = 1;
                    g = 0;
                    b = q;
                    break;
            }
            return "#" + ((int)(r * 255)).ToString("X2") + ((int)(g * 255)).ToString("X2") + ((int)(b * 255)).ToString("X2");
        }
        private void Main_Shown(object sender, EventArgs e)
        {
            Sleep(3000);
            InitializeRepo();
            CheckForCheatUpdates();
        }
    }
}
