using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Classes
{
    class Processesing
    {
        public static int GetModule(string procName, string mModuleName)
        {
            Process[] p = Process.GetProcessesByName(procName);

            if(p.Length > 0)
            {
                foreach(ProcessModule m in p[0].Modules)
                {
                    if(m.ModuleName == mModuleName)
                    {
                        return (Int32)m.BaseAddress;
                    }
                }
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public static void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();
        }
    }
}
