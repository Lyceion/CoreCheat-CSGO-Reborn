using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CoreCheat_Reborn.SDK.Classes
{
    class CUserCmd
    {
        public int Vft;
        public int CmdNumber;
        public int TickCount;
        public Vector3 ViewAngles;
        public Vector3 AimDirection;
        public float Forwardmove;
        public float Sidemove;
        public float Upmove;
        public int Buttons;
        public byte Impulse;
        private readonly byte __pad0x01 = 0x03;
        public int WeaponSelect;
        public int WeaponSubtype;
        public int RandomSeed;
        public string MouseDx;
        public string MouseDy;
        public bool HasBeenPredicted;
        private readonly byte __pad0x02 = 0x1B;
    }
}
