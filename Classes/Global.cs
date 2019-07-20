using System;
using System.Diagnostics;
using System.Reflection;
using static CoreCheat_Reborn.Classes.Base64;
using static CoreCheat_Reborn.Classes.ExecutingHash;

namespace CoreCheat_Reborn.Classes
{
    public static class Global
    {
        //SERVER PHP
        public static string server = "http://www.lysep.com/corecheat/check.php";

        //DEPENDS
        public static Assembly assembly = Assembly.GetExecutingAssembly();
        public static FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

        //WEB VARS
        public static string WebVersion;
        public static string UpdateRedirect;
        public static bool ProgramStatus;
        public static string CheatError;
        public static bool OpenMessage;
        public static bool CloseRedirect;
        public static string UpdateLink;
        public static string CloseLink;

        //LOCAL VARS
        public static string ProgramName = Assembly.GetExecutingAssembly().ToString();
        public static string ProgramVersion = Convert.ToString(fvi.FileVersion);
        public static string FileHash = GetExecutingFileHash();
        public static string KEY = Base64Encode(FileHash + ProgramVersion + ProgramName);
        //public static string KEY = "test";
    } 
}
