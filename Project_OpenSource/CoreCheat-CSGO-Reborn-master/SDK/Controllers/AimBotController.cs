using System;
using System.Numerics;
using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.SDK.Entities;
using System.Threading;
// Author : Septillioner
// GitHub : http://github.com/Septillioner
// E-mail  : septillioner@protonmail.com
// Programmed for CoreCheat
namespace CoreCheat_Reborn.SDK.Controllers
{
    class AimBotController
    {
        private int target_entbase = 0;
        private Vector3 target_vector = new Vector3(),
                                        from_vector   = new Vector3();
        public float target_distance = float.MaxValue;
        public float sensivity = 1;
        public AimBotController(float sensivity)
        {
            this.sensivity = sensivity;
        }
        public AimBotController()
        {
        }
        public void setFrom(Vector3 from)
        {
            target_distance = float.MaxValue;
            from_vector = from;
        }
        public void closestEngine(int entbase,Vector3 to)
        {
            float n_distance = Vector3.Distance(from_vector, to);
            if (n_distance< target_distance && target_distance > 0)
            {
                target_entbase = entbase;
                target_vector = to;
                target_distance = Vector3.Distance(from_vector, to);
            }
        }
        
        public int closestPlayerEntityBase
        {
            get
            {
                return target_entbase;
            }
        }
        public Vector3 closestPlayerVector
        {
            get{
               return target_vector;
            }
        }
        public Vector3 CalcAngle(Vector3 to)
        {
            return CalcAngle(from_vector, to);
        }
        public Vector3 FixBonePos(Vector3 a, Vector3 b)
        {
            Vector3 anglesb = new Vector3();

            Vector3 delta = a - b;

            CalcAngle(delta, anglesb);

            return anglesb;
        }
        public Vector3 CalcAngle(Vector3 from,Vector3 to)
        {
            Vector3 angle = new Vector3();
            float dx = from.X - to.X,
                      dy = from.Y - to.Y,
                      dz = from.Z - to.Z;
            double hyp = Math.Sqrt(dx * dx + dy * dy);
            angle.X = (float)(Math.Atan2(dz,hyp)* 57.295779513082f);
            angle.Y =(float)(Math.Atan2(dy,dx)* 57.295779513082f);
            if (double.IsNaN(angle.X)) angle.X = 0; 
            if (double.IsNaN(angle.Y))angle.Y = 0; 
            if (dx >= 0.0) { angle.Y += 180.0f; }
            if (dx < 0.0) { angle.Y -= 180.0f; }
            return angle;
        }
        public void SmoothAim(Vector3 to,int frame=200)
        {
            int frames = frame;
            Vector3 from = CLocalPlayer.ViewAngles;
            for (int i = 0; i < frames; i++)
            {
                float dx = i*(from.X-to.X)/frames,
                          dy = i*(from.Y-to.Y)/frames;
                Vector3 frame_ = new Vector3(
                    to.X-dx,
                    to.Y-dy,
                    0);
                CLocalPlayer.ViewAngles = Managers.Parsers.ClampAngle(frame_);
                Thread.Sleep((int)(1 * sensivity));
            }
            CLocalPlayer.ViewAngles = Managers.Parsers.ClampAngle(to);
        }
        public Vector3 RemovePunch(Vector3 aim)
        {
            return Vector3.Subtract(aim, Vector3.Multiply(CLocalPlayer.AimPunchAngles, 2));
        }

    }
}
