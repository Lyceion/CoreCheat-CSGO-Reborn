using System;
using System.Diagnostics;
using System.Windows.Forms;
using static CoreCheat_Reborn.Classes.WebConnection;

namespace CoreCheat_Reborn.Classes
{
    class Functions
    {
        public static void InitializeProject()
        {
            IsServerAcsessible();
            if (GetStrData("version") != "OK")
            {
                Clipboard.SetText(ProgramSettings.Globals.KEY);
                MessageBox.Show("Your Launcher Has Been Outdated Or Modified. Please Download New Version or Again!", "Version Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start(GetStrData("update"));
                Environment.Exit(0);
            }
            else
               if (!IsProgramStatus())
            {
                MessageBox.Show("Launcher Closed For A While. Reason: \n" + GetStrData("closealert"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (IsCloseRedir())
                {
                    Process.Start(GetStrData("closelink"));
                    Environment.Exit(0);
                }
                else
                    Environment.Exit(0);
            }
            else
                   if (IsOpenMSG())
            {
                MessageBox.Show("Message From Admin: \n" + GetStrData("message"), "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (IsMsgRedir())
                    Process.Start(GetStrData("msglink"));
            }
        }
        private static void IsServerAcsessible()
        {
            try
            {
                GetStrData("update");
            }
            catch
            {
                MessageBox.Show("Server connection error. Exiting...", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
