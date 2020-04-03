using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCheat_Reborn.SDK.Controllers
{
    public class Allocator
    {
        public Dictionary<IntPtr, IntPtr> AllocatedSize = new Dictionary<IntPtr, IntPtr>();

        public IntPtr AlloacNewPage(IntPtr size)
        {
            var Address = CylMem.NativeMethods.VirtualAllocEx(CylMem.ProcessHandle, IntPtr.Zero, (IntPtr)4096, (uint)CylMem.FreeType.Commit | (uint)CylMem.FreeType.Reserve, (uint)CylMem.MemoryProtection.ExecuteReadWrite);

            AllocatedSize.Add(Address, size);

            return Address;
        }

        public void Free()
        {
            foreach (var key in AllocatedSize)
                CylMem.NativeMethods.VirtualFreeEx(CylMem.ProcessHandle, key.Key, (IntPtr)4096, CylMem.FreeType.Commit | CylMem.FreeType.Reserve);
        }

        public IntPtr Alloc(int size)
        {
            for (int i = 0; i < AllocatedSize.Count; ++i)
            {
                var key = AllocatedSize.ElementAt(i).Key;
                int value = (int)AllocatedSize[key] + size;
                if (value < 4096)
                {
                    IntPtr CurrentAddres = IntPtr.Add(key, (int)AllocatedSize[key]);
                    AllocatedSize[key] = new IntPtr(value);
                    return CurrentAddres;
                }
            }

            return AlloacNewPage(new IntPtr(size));
        }

    }

}
