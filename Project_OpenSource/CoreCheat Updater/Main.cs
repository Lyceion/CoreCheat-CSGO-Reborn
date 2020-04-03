using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using static System.Convert;

namespace CoreCheat_Updater
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
#pragma warning disable CS0436
        public Main()
        {
            //CheckForUpdaterUpdates();
            InitializeComponent();
        }
        WebClient webClient;
        Stopwatch sw = new Stopwatch();
        private void Main_Load(object sender, EventArgs e)
        {
            //InitializeRepo();
            //CheckForCheatUpdates();
        }
        void InitializeRepo()
        {
            statusTXT.Text = "Initializing Repos...";
            GithubNET.Users.SelectUser("lysep-corp");
            GithubNET.Repository.SelectRepository("CoreCheatCSGO-LSREMAKE");
        }
        void CheckForCheatUpdates()
        {
            statusTXT.Text = "Chekking For Updates...";
            var LastVersion = GithubNET.Repository.LatestReleasesUrl;
            var OldVersion = Datas.Default.OldVersionLink;
            if ((LastVersion != OldVersion) || !File.Exists(AppDomain.CurrentDomain.BaseDirectory + "core.exe"))
            {
                statusTXT.Text = "Update Found! Downloading...";
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
                statusTXT.Text = "No Update Found. Starting Cheat...";
                StartCheat();
            }
        }
        void CheckForUpdaterUpdates()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string ProgramVersion = Convert.ToString(fvi.FileVersion);
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(ProgramVersion);
            string KEY = ToBase64String(plainTextBytes);
#if DEBUG
            Clipboard.SetText(KEY);
#endif
            WebClient CylClient = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string WebKEY = CylClient.DownloadString("https://lysep.com/coreproject/check.php?cmd=updaterVersion");
            if (WebKEY != KEY)
            {
                MessageBox.Show("En: Please download again.\n\nTr: Lütfen Tekrar Indirin.");
                Environment.Exit(0);
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
                percent.Visible = false;
                dataInfo.Visible = false;
                updateProgress.Spinning = true;
                statusTXT.Text = "Download complated. Starting Cheat...";
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "core.exe"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "core.exe");
                ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory + "cheat.zip", Directory.GetCurrentDirectory());
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "cheat.zip");
                StartCheat();
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void UpdateProgress_Click(object sender, EventArgs e)
        {

        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            dataInfo.Visible = true;
            //dataInfo.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            updateProgress.Spinning = false;
            updateProgress.Value = e.ProgressPercentage;
            percent.Visible = true;
            percent.Text = e.ProgressPercentage.ToString() + "%";
            dataInfo.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }
        private void Main_Shown(object sender, EventArgs e)
        {
            CheckForUpdaterUpdates();
            InitializeRepo();
            CheckForCheatUpdates();
        }
        private void StartCheat()
        {
            statusTXT.Text = "Program is started. Updater goes!";
            //MD5Controller.MD5Controller.ChangeMD5(AppDomain.CurrentDomain.BaseDirectory + "core.exe");
            var proc = Process.Start(AppDomain.CurrentDomain.BaseDirectory + "core.exe", "-updaterOut");
            if (proc.Id > 0)
            {
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
    }
}
