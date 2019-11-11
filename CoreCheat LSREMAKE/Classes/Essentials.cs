using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace CoreCheat_LSREMAKE.Classes
{
    class Essentials
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        public static bool HoldingKey(Keys keyid)
        {
            if ((GetAsyncKeyState(keyid) & 0x8000) > 0)
                return true;
            else
                return false;
        }
    }
}
