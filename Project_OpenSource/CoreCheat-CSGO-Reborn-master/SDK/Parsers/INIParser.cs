using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.SDK.Parsers
{
    public class INIParser
    {
        #region Fields
        private static string INIPath;
        private static string ConfigName;
        private static string ConfigPath = @"\Config\";
        private static string ExePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        #endregion

        #region Native Methods
        private static class NativeMethods
        {
            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            public static extern bool WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            public static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        }
        #endregion

        #region Load INI
        public static void Load(string _ConfigName)
        {
            ConfigName = _ConfigName;
            INIPath = ExePath + ConfigPath + ConfigName + ".ini";
        }
        public static string GetINIDirectoryPath()
        {
            return ExePath + ConfigPath;
        }
        #endregion

        #region Read & Write INI
        public static string Read(Categorys categorys, string Key)
        {
            string CategoryName = null;
            switch (categorys)
            {
                case Categorys.VISUALS:
                    CategoryName = "Visuals";
                    break;

                case Categorys.ASSISTS:
                    CategoryName = "Assists";
                    break;

                case Categorys.AIM:
                    CategoryName = "Aim";
                    break;

                case Categorys.MISCS:
                    CategoryName = "Miscs";
                    break;

                case Categorys.SKINCHANGER:
                    CategoryName = "SkinChanger";
                    break;

                case Categorys.SETTINGS:
                    CategoryName = "Settings";
                    break;
            }

            IsINIFileExitsOrCreate();

            StringBuilder sb = new StringBuilder(500);
            NativeMethods.GetPrivateProfileString(CategoryName, Key, "", sb, sb.Capacity, INIPath);
            string veri = sb.ToString();
            sb.Clear();
            return veri;
        }
        public static bool Write(Categorys categorys, string Key, string Value)
        {
            string CategoryName = null;
            switch (categorys)
            {
                case Categorys.VISUALS:
                    CategoryName = "Visuals";
                    break;

                case Categorys.ASSISTS:
                    CategoryName = "Assists";
                    break;

                case Categorys.AIM:
                    CategoryName = "Aim";
                    break;

                case Categorys.MISCS:
                    CategoryName = "Miscs";
                    break;

                case Categorys.SKINCHANGER:
                    CategoryName = "SkinChanger";
                    break;

                case Categorys.SETTINGS:
                    CategoryName = "Settings";
                    break;
            }

            IsINIFileExitsOrCreate();

            return NativeMethods.WritePrivateProfileString(CategoryName, Key, Value, INIPath);
        }
        public static void SaveConfig()
        {
            Load(ConfigName);
            Write(Categorys.MISCS, "ClanTag", MiscConfig.SelectedClanTag);
        }
        public static void LoadConfig()
        {
            Load(ConfigName);
            MiscConfig.SelectedClanTag = Read(Categorys.MISCS, "ClanTag");
        }
        #endregion

        #region Extensions
        private static bool IsINIFileExitsOrCreate()
        {
            CreateINIDirectoryFile();
            CreateINI();
            return true;
        }
        public static void CreateINIDirectoryFile()
        {
            if (!Directory.Exists(ExePath + ConfigPath))
            {
                Directory.CreateDirectory(ExePath + ConfigPath);
            }
        }
        public static void CreateINI()
        {
            if (!File.Exists(ExePath + ConfigPath + ConfigName + ".ini"))
            {
                File.Create(ExePath + ConfigPath + ConfigName + ".ini");
            }
        }
        #endregion

        public enum Categorys
        {
            VISUALS,
            ASSISTS,
            AIM,
            MISCS,
            SKINCHANGER,
            SETTINGS
        }
    }
}
