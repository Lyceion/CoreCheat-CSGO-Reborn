using System.Net;

namespace CoreCheat_Reborn.Classes
{
    class WebConnection
    {
        public static WebClient CylClient = new WebClient();
        public static string Download(string type, string adress)
        {
            try
            {
                return CylClient.DownloadString(adress);
            }
            catch
            {
                return "null";
            }
        }
        public static string GetStrData(string data)
        {
            var srvStr = ProgramSettings.Globals.server + "?key=" + ProgramSettings.Globals.KEY + "&cmd=" + data;
            return Download("string", srvStr);
        }
        public static bool IsProgramStatus()
        {
            var str = GetStrData("status");
            if(str == "acik")
                return true;
            else
                return false;
        }
        public static bool IsOpenMSG()
        {
            var str = GetStrData("ismessage");
            if (str == "acik")
                return true;
            else
                return false;
        }
        public static bool IsCloseRedir()
        {
            var str = GetStrData("iscloselink");
            if (str == "acik")
                return true;
            else
                return false;
        }
        public static bool IsMsgRedir()
        {
            var str = GetStrData("ismsglink");
            if (str == "acik")
                return true;
            else
                return false;
        }
        public static bool IsCheatOpen(string cheat)
        {
            var str = GetStrData(cheat);
            if (str == "acik")
                return true;
            else
                return false;
        }
    }
}
