using System;
using System.Diagnostics;

namespace CoreCheat_Reborn.SDK.Managers
{
    class Modules
    {
        public static string ClientDLLName = "client_panorama.dll";
        public static string EngineDLLName = "engine.dll";
        public static string ShaderAPIName = "shaderapidx9.dll";
        public static string VSTDLibDLLName = "vstdlib.dll";
        public static int ClientDLLAdress;
        public static int EngineDLLAdress;
        public static int ShaderAPIAdress;
        public static int VSTDLibDLLAdress;
        public static int GetModule(string procName, string mModuleName)
        {
            Process[] p = Process.GetProcessesByName(procName);

            if (p.Length > 0)
            {
                foreach (ProcessModule m in p[0].Modules)
                {
                    if (m.ModuleName == mModuleName)
                    {
                        return (int)m.BaseAddress;
                    }
                }
                return 0;
            }
            else
            {
                return 0;
            }
        }
        public static bool IsModuleRunning(string moduleName)
        {
            try
            {
                Process[] p = Process.GetProcessesByName("csgo");

                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == moduleName)
                        {
                            return true;
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
