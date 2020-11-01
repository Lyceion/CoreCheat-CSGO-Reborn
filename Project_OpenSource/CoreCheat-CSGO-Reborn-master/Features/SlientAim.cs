using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Classes;
using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.SDK.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.Features
{
    class SlientAim
    {
        public static void ChangeViewAngles(Vector3 Angles, bool CanShoot)
        {
            //read pointers to commands buffer and clientstate
            CInput Input = CylMem.CRead2<CInput>(Modules.ClientDLLAdress + dwInput);
            int ClientState = CylMem.ReadInt(Modules.EngineDLLAdress + dwClientState);

            //stop sending packets
            EngineClient.SendPackets = false;

            int DesiredCmd = CylMem.ReadInt(ClientState + clientstate_last_outgoing_command); //read the last outgoing command
            DesiredCmd += 2; //+1 current one +2 incomming one

            //calculate addresses of Icomming cmd and current cmd + verified, 150 is the size of the commands buffer
            int IncommingUserCmd = Input.Commands + (DesiredCmd % 150) * Marshal.SizeOf(typeof(CUserCmd));
            int CurrentUserCmd = Input.Commands + ((DesiredCmd - 1) % 150) * Marshal.SizeOf(typeof(CUserCmd));
            int VerifiedCurrentUserCmd = Input.VerifiedCommands + ((DesiredCmd - 1) % 150) * Marshal.SizeOf(typeof(CVerifiedUserCmd));

            int CmdNumber = 0;
            while (CmdNumber < DesiredCmd) //now we wait until is the right time to hit, dont sleep! the wait time is really short, in fact it doesnt consume cpu, +0x04 skips vft and reads the cmd number
                CmdNumber = CylMem.ReadInt(IncommingUserCmd + 0x04);

            CUserCmd CMD = CylMem.CRead2<CUserCmd>(CurrentUserCmd); //we hack this one, read it

            CMD.ViewAngles.X = Angles.X; //set new view angles
            CMD.ViewAngles.Y = Angles.Y;

            if (CanShoot) //trigger shoot button if we set CanShoot to true
                CMD.Buttons |= 1 << 0;

            //when you are done write em back
            CylMem.CWrite<CUserCmd>(CurrentUserCmd, CMD);
            CylMem.CWrite<CUserCmd>(VerifiedCurrentUserCmd, CMD); //dont bother calculating crc (accualy you can do it to make vac happy and not get banned easilly lol)

            EngineClient.SendPackets = true; //restore sending packets
        }
    }
}
