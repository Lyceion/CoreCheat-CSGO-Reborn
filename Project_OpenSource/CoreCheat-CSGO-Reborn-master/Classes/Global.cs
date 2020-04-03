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
        public static string server = "http://www.lysep.com/coreproject/check.php";

        //DEPENDS
        public static Assembly assembly = Assembly.GetExecutingAssembly();
        public static FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

        //LOCAL VARS
        public static string FileHash = GetExecutingFileHash();
        public static string ProgramVersion = Convert.ToString(fvi.FileVersion);
        public static string ProgramName = Assembly.GetExecutingAssembly().ToString();
        public static string KEY = Base64Encode(FileHash + ProgramVersion + ProgramName);
        public static DateTime  CompileDate = Assembly.GetExecutingAssembly().GetLinkerTime();
    }
}
