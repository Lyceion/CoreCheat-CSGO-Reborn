using System.Diagnostics;

namespace CoreCheat_Reborn.Classes
{
    class Processesing
    {
        public static int GetPIDByName(string pName)
        {
            Process[] P = Process.GetProcessesByName(pName);
            return P[0].Id;
        }
    }
}
