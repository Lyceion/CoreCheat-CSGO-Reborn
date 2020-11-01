using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCheat_Reborn.SDK.Controllers
{
    public static class NetvarManager
    {
        public static Dictionary<string, Dictionary<string, int>> Table =
            new Dictionary<string, Dictionary<string, int>>();

        public static void ScanTable(IntPtr table, int level, int offset, string name)
        {
            var count = CylMem.ReadInt((int)table + 0x4);

            for (var i = 0; i < count; i++)
            {
                var propID = CylMem.ReadInt((int)table) + i * 0x3C;
                var propName = CylMem.ReadString(CylMem.ReadInt(propID));
                var isBaseClass = propName.IndexOf("baseclass") == 0;
                var propOffset = offset + CylMem.ReadInt(propID + 0x2C);
                if (!isBaseClass)
                {
                    if (!Table.ContainsKey(name))
                        Table.Add(name, new Dictionary<string, int>());

                    if (!Table[name].ContainsKey(propName)) Table[name].Add(propName, propOffset);
                }

                var child = (IntPtr)CylMem.ReadInt(propID + 0x28);

                if (child == IntPtr.Zero)
                    continue;

                if (!isBaseClass)
                    --level;

                ScanTable(child, ++level, propOffset, name);
            }
        }

        public static void Init()
        {
            var _firstclass = (IntPtr)SigScan.ScanPattern(Managers.Modules.ClientDLLName, "A1 ? ? ? ? C3 CC CC CC CC CC CC CC CC CC CC A1 ? ? ? ? B9", 1, 0, false); // dwGetAllClasses

            _firstclass = (IntPtr)CylMem.ReadInt((int)_firstclass);

            if (_firstclass == IntPtr.Zero)
            {
                //Environment.Exit(-1);
            }

            do
            {
                var table = (IntPtr)CylMem.ReadInt((int)_firstclass + 0xC);
                if (table != IntPtr.Zero)
                {
                    var table_name = CylMem.ReadString(CylMem.ReadInt((int)table + 0xC));
                    ScanTable(table, 0, 0, table_name);
                }

                _firstclass = (IntPtr)CylMem.ReadInt((int)_firstclass + 0x10);
            } while (_firstclass != IntPtr.Zero);
        }
    }
}

