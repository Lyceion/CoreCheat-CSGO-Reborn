using System;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using CoreCheat_Reborn.Classes;
using static CoreCheat_Reborn.Classes.Base64;
using static CoreCheat_Reborn.Classes.ExecutingHash;

namespace CoreCheat_Reborn
{
    class ProgramSettings
    {
        public static class CheatTheme
        {
            public static Color MainThemeColor = Color.FromArgb(20, 20, 20); //DARK
            //public static Color MainThemeColor = Color.FromArgb(255, 255, 255); //LIGHT
            //public static Color SecondaryThemeColor = Color.FromArgb(203, 23, 29); //RED SECONDARY
            //public static Color SecondaryThemeColor = Color.FromArgb(37, 138, 255); //BLUE SECONDARY
            public static Color SecondaryThemeColor = ColorTranslator.FromHtml("#fc03c2"); //HOT PINK SECONDARY
            //public static Color SecondaryThemeColor = Color.FromArgb(106, 90, 205); //PURPLE SECONDARY
            //public static Color SecondaryThemeColor = Color.FromArgb(155, 155, 155); //GRAY SECONDARY
        }
        public static class Globals
        {
            //SERVER PHP
#if DEBUG
            public static string server = "http://www.lysep.com/coreproject/check_beta.php";
#else
            public static string server = "http://www.lysep.com/coreproject/check.php";
#endif
            //DEPENDS
            public static Assembly assembly = Assembly.GetExecutingAssembly();
            public static FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            //LOCAL VARS
            public static string FileHash = GetExecutingFileHash();
            public static string ProgramVersion = Convert.ToString(fvi.FileVersion);
            public static string ProgramName = Assembly.GetExecutingAssembly().ToString();
#if DEBUG
            public static string KEY = "test";
#else
            public static string KEY = Base64Encode(FileHash + ProgramVersion + ProgramName);
#endif
            public static DateTime CompileDate = Assembly.GetExecutingAssembly().GetLinkerTime();
        }
    }
}
