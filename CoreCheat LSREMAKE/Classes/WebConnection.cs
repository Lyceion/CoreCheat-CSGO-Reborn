using static CoreCheat_LSREMAKE.Classes.Global;
using System.Net;

namespace CoreCheat_LSREMAKE.Classes
{
    class WebConnection
    {
        public static WebClient cyl = new WebClient();
        public static string Download(string type, string adress)
        {
            try
            {
                return cyl.DownloadString(adress);
            }
            catch
            {
                return "null";
            }

        }
        public static string GetStrData(string data)
        {
            var srvStr = server + "?key=" + KEY + "&cmd=" + data;
            return Download("string", srvStr);
        }
        public static bool IsProgramStatus()
        {
            var str = GetStrData("status");
            if(str == "acik")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsOpenMSG()
        {
            var str = GetStrData("ismessage");
            if (str == "acik")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsCloseRedir()
        {
            var str = GetStrData("iscloselink");
            if (str == "acik")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsCheatOpen(string cheat)
        {
            var str = GetStrData(cheat);
            if (str == "acik")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
