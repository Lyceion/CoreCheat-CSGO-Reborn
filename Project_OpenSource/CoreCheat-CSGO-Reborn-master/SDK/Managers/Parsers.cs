using System.Numerics;
using System.Windows.Forms;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.CheatClasses.Structs;

namespace CoreCheat_Reborn.SDK.Managers
{
    class Parsers
    {
        #region WeaponNameParser
        public static string ParseItemName(short weapID)
        {
            switch (weapID)
            {
                case 0:
                    return "NONE";
                case 1:
                    return "Desert Eagle";
                case 2:
                    return "Dual Barettas";
                case 3:
                    return "Fives-SeveN";
                case 4:
                    return "Glock-18";
                case 7:
                    return "AK-47";
                case 8:
                    return "AUG";
                case 9:
                    return "AWP";
                case 10:
                    return "FAMAS";
                case 11:
                    return "G3SG1";
                case 13:
                    return "Galil AR";
                case 14:
                    return "M249";
                case 16:
                    return "M4A4";
                case 17:
                    return "MAC-10";
                case 19:
                    return "P90";
                case 23:
                    return "MP5-SD";
                case 24:
                    return "UMP-45";
                case 25:
                    return "XM1014";
                case 26:
                    return "PP-Bizon";
                case 27:
                    return "MAG-7";
                case 28:
                    return "Negev";
                case 29:
                    return "Sawed-Off";
                case 30:
                    return "Tec-9";
                case 31:
                    return "Zeus x27";
                case 32:
                    return "P2000";
                case 33:
                    return "MP7";
                case 34:
                    return "MP9";
                case 35:
                    return "Nova";
                case 36:
                    return "P250";
                case 37:
                    return "Ballistic Shield";
                case 38:
                    return "SCAR-20";
                case 39:
                    return "SG 553";
                case 40:
                    return "SSG 08";
                case 41:
                    return "KnifeGG";
                case 42:
                    return "Knife";
                case 43:
                    return "Flashbang";
                case 44:
                    return "HE Granade";
                case 45:
                    return "Smoke Granade";
                case 46:
                    return "Molotov";
                case 47:
                    return "Decoy Granade";
                case 48:
                    return "Incendiary Granade";
                case 49:
                    return "C4 Explosive";
                case 55:
                    return "Defuse Kit";
                case 56:
                    return "Rescue Kit";
                case 57:
                    return "Medi-Shot";
                case 59:
                    return "Terrorist Knife";
                case 60:
                    return "M4A1-S";
                case 61:
                    return "USP-S";
                case 63:
                    return "CZ75-Auto";
                case 64:
                    return "R8 Revolver";
                case 68:
                    return "TA Granade";
                case 69:
                    return "Hands";
                case 70:
                    return "Breach Charge";
                case 72:
                    return "Tablet";
                case 74:
                    return "Meele";
                case 75:
                    return "Axe";
                case 76:
                    return "Hammer";
                case 78:
                    return "Wrench";
                case 80:
                    return "Spectral Shiv";
                case 81:
                    return "Fire Bomb";
                case 82:
                    return "Deversion Device";
                case 83:
                    return "Frag Granade";
                case 84:
                    return "Snowball";
                case 85:
                    return "Bump Mine";
                case 500:
                    return "Bayonet";
                case 505:
                    return "Flip Knife";
                case 506:
                    return "Gut Knife";
                case 507:
                    return "Karambit";
                case 508:
                    return "M9 Bayonet";
                case 509:
                    return "Huntsman Knife";
                case 512:
                    return "Falchion Knife";
                case 514:
                    return "Bowie Knife";
                case 515:
                    return "Butterfly Knife";
                case 516:
                    return "Shadow Daggers";
                case 519:
                    return "Ursus Knife";
                case 520:
                    return "Navaja Knife";
                case 522:
                    return "Stiletto Knife";
                case 523:
                    return "Talon Knife";
                default:
                    return "null";
            }
        }
        #endregion

        #region AngleParsers
        public static Vector3 ClampAngle(Vector3 angle)
        {
            while (angle.Y > 180) angle.Y -= 360;
            while (angle.Y < -180) angle.Y += 360;

            if (angle.X > 89.0f) angle.X = 89.0f;
            if (angle.X < -89.0f) angle.X = -89.0f;

            angle.Z = 0f;

            return angle;
        }
        //public static Vector2 WorldToScreen(Vector3 target,int width=1024,int height=768)
        //{
        //    Vector2 _worldToScreenPos;
        //    Vector3 to;
        //    float w = 0.0f;
        //    float[] viewmatrix = new float[16];
        //    viewmatrix = G.Engine.ViewMatrix;

        //    to.X = viewmatrix[0] * target.X + viewmatrix[1] * target.Y + viewmatrix[2] * target.Z + viewmatrix[3];
        //    to.Y = viewmatrix[4] * target.X + viewmatrix[5] * target.Y + viewmatrix[6] * target.Z + viewmatrix[7];

        //    w = viewmatrix[12] * target.X + viewmatrix[13] * target.Y + viewmatrix[14] * target.Z + viewmatrix[15];

        //    // behind us
        //    if (w < 0.01f)
        //        return new Vector2(0, 0);

        //    to.X *= (1.0f / w);
        //    to.Y *= (1.0f / w);


        //    float x = width / 2;
        //    float y = height / 2;

        //    x += 0.5f * to.X * width + 0.5f;
        //    y -= 0.5f * to.Y * height + 0.5f;

        //    to.X = x;
        //    to.Y = y;

        //    _worldToScreenPos.X = to.X;
        //    _worldToScreenPos.Y = to.Y;
        //    return _worldToScreenPos;
        //}
        public static Vector3 NormalizeAngle(Vector3 angle)
        {
            while (angle.X < -180.0f) angle.X += 360.0f;
            while (angle.X > 180.0f) angle.X -= 360.0f;

            while (angle.X < -180.0f) angle.Y += 360.0f;
            while (angle.X > 180.0f) angle.Y -= 360.0f;

            while (angle.Z < -180.0f) angle.Z += 360.0f;
            while (angle.Z > 180.0f) angle.Z -= 360.0f;

            return angle;
        }
        #endregion

        #region HealthParser
        public static GlowStruct ParseEnemyGlowHealth(int Health)
        {
            GlowStruct output = new GlowStruct();
            output.r = 1.0f - (Health / 100.0f);
            output.g = Health / 100.0f;
            output.b = 0;
            output.a = 1.0f;
            return output;
        }
        public static ColorStruct ParseEnemyChamsHealth(int Health)
        {
            ColorStruct output = new ColorStruct();
            output.r = 255 - (Health * 2.55f);
            output.g = Health / 2.55f;
            output.b = 0;
            output.a = 255;
            return output;
        }
        #endregion

        public static Keys KeyListToRealKey(KeysList key)
        {
            if (key == KeysList.E)
                return Keys.E;
            if (key == KeysList.V)
                return Keys.V;
            if (key == KeysList.X)
                return Keys.X;
            if (key == KeysList.Z)
                return Keys.Z;
            else
                return Keys.LButton;
        }
    }
}
