using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.Features
{
    class Triggerbot
    {
        public static void RunTriggerBotPanorama()
        {
            if (CheatStatus.TriggerActive)
            {
                if (AssistsConfig.TriggerKey == KeysList.NOKEYS || (AssistsConfig.TriggerKey != KeysList.NOKEYS && Methods.HoldingKey(Parsers.KeyListToRealKey(AssistsConfig.TriggerKey))))
                {
                    if (CLocalPlayer.IsCloseRangeWeapon) return;
                    if (CLocalPlayer.IsThrowableWeapon) return;
                    else
                    {
                        int CrossEntity;
                        if (CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (CLocalPlayer.CrossID - 1) * 0x10) == -1)
                            CrossEntity = 0;
                        else
                            CrossEntity = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (CLocalPlayer.CrossID - 1) * 0x10);
                        if (CrossEntity == 0) return;
                        if (CEntityPlayer.isDormant(CrossEntity)) return;
                        if (CEntityPlayer.isDead(CrossEntity)) return;
                        if (CEntityPlayer.Team(CrossEntity) == Teams.NONE || CEntityPlayer.Team(CrossEntity) == Teams.SPECTATOR) return;
                        if (CEntityPlayer.WeaponName(CrossEntity) == "NONE") return;
                        if (AssistsConfig.isNoScope)
                        {
                            if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer && ((CEntityPlayer.Team(CrossEntity) == CLocalPlayer.Team && AssistsConfig.isFriendlyFire) || (CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team)))
                            {
                                if (CEntityPlayer.isAlive(CrossEntity) && CLocalPlayer.CrossID >= 0)
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        if (CLocalPlayer.IsPistolWeapon)
                                        {
                                            CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                            continue;
                                        }
                                        else if (AssistsConfig.isSprayRandom)
                                            CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                        else
                                            CLocalPlayer.ShootWithPointer(WeaponSettings.TriggerSprayTime);
                                    }
                                }
                            }
                        }
                        else if (!CLocalPlayer.Scoped)
                        {
                            if (CLocalPlayer.IsScopedWeapon)
                                return;
                            else
                            {
                                if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer && ((CEntityPlayer.Team(CrossEntity) == CLocalPlayer.Team && AssistsConfig.isFriendlyFire) || (CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team)))
                                {
                                    if ((CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team) && CEntityPlayer.isAlive(CrossEntity) && CLocalPlayer.CrossID >= 0)
                                    {
                                        for (int i = 0; i < 2; i++)
                                        {
                                            if (CLocalPlayer.IsPistolWeapon)
                                            {
                                                CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                                continue;
                                            }
                                            else if (AssistsConfig.isSprayRandom)
                                                CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                            else
                                                CLocalPlayer.ShootWithPointer(WeaponSettings.TriggerSprayTime);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer)
                            {
                                if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer && ((CEntityPlayer.Team(CrossEntity) == CLocalPlayer.Team && AssistsConfig.isFriendlyFire) || (CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team)))
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        if (CLocalPlayer.IsPistolWeapon)
                                        {
                                            CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                            continue;
                                        }
                                        else if (AssistsConfig.isSprayRandom)
                                            CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                        else
                                            CLocalPlayer.ShootWithPointer(WeaponSettings.TriggerSprayTime);
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
