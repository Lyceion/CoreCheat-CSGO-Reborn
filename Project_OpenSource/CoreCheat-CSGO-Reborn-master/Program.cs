using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoreCheat_Reborn
{
    static class Program
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);
        [STAThread]
        static void Main(string[] args)
        {
#if DEBUG
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Versions.Panorama.Main());
            Application.Run(new vSelector());
            //Application.Run(new Versions.ZDEV.Main());
            //Application.Run(new Expire());
#else
            if (args[0] == "-updaterOut")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new vSelector());
            }
            else
            {
                MessageBox(IntPtr.Zero, "En: Please open program from updater.\n\nTr: Lütfen programı güncelleyiciden açın.", "Info!", 0);
                Environment.Exit(0);
            }
#endif
        }
    }
}
