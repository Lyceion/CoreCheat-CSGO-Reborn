using CoreCheat_Reborn.SDK.Controllers;
using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CoreCheat_Reborn.CheatClasses
{
    class Methods
    {
        [DllImport("user32", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);
        public static void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();
        }
        public static bool HoldingKey(Keys keyid)
        {
            if ((GetAsyncKeyState(keyid) & 0x8000) > 0)
                return true;
            else
                return false;
        }
        public static string RandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string input = "#$!%&?}{][ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
        public static void AttachDebugger(string CheatName)
        {
            //CoreCheat_Reborn.Debugger.Debugger = new CoreCheat_Reborn.Debugger(CheatName, Color.White, MetroFramework.MetroColorStyle.Red);
        }
        public static Vector3 GetBonePos(int target, int bone)
        {
            int bMatrix = CylMem.ReadInt(target + Offsets.netvars.m_dwBoneMatrix);
            Vector3 vec = new Vector3();
            vec.X = CylMem.ReadFloat(bMatrix + (0x30 * bone) + 0xC);
            vec.Y = CylMem.ReadFloat(bMatrix + (0x30 * bone) + 0x1C);
            vec.Z = CylMem.ReadFloat(bMatrix + (0x30 * bone) + 0x2C);
            return vec;
        }
    }
}
