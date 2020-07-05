using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoreCheat_Reborn
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Version_Selector.VersionSelector());
            Application.Run(new Versions.Panorama.Main());
        }
    }
}
