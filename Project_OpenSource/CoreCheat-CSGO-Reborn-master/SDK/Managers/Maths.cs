using System;
using System.Numerics;
using System.Windows.Forms;

namespace CoreCheat_Reborn.SDK.Managers
{
    class Maths
    {
        public static float M_PI_F = (180.0f / Convert.ToSingle(System.Math.PI));
        public static string ApplicationName = "csgo";
        public static Matrix4x4 Matrix = new Matrix4x4(0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);

        public static int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        public static int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        public static Vector3 WorldToScreen(Vector3 bone) //World to screen
        {
            Vector3 Out = new Vector3();
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            float w = Matrix.M41 * bone.X + Matrix.M42 * bone.Y + Matrix.M43 * bone.Z + Matrix.M44;
            if (w < 0.01f)
                return Out;

            Out.X = (Matrix.M11 * bone.X + Matrix.M12 * bone.Y + Matrix.M13 * bone.Z + Matrix.M14) * 1.0f / w;
            Out.Y = (Matrix.M21 * bone.X + Matrix.M22 * bone.Y + Matrix.M23 * bone.Z + Matrix.M24) * 1.0f / w;

            Out.X = (ScreenWidth / 2) + 0.5f * Out.X * ScreenWidth + 0.5f;
            Out.Y = (ScreenHeight / 2) - 0.5f * Out.Y * ScreenHeight + 0.5f;

            return Out;
        }

        public static Vector3 ClampAngle(Vector3 angle)
        {
            while (angle.Y > 180) angle.Y -= 360;
            while (angle.Y < -180) angle.Y += 360;

            if (angle.X > 89.0f) angle.X = 89.0f;
            if (angle.X < -89.0f) angle.X = -89.0f;

            angle.Z = 0f;

            return angle;
        }

        public static Vector3 Normalize(Vector3 angles)
        {
            if (angles.X > 89.0f && angles.X <= 180.0f)
                angles.X = 89.0f;
            while (angles.X > 180)
                angles.X -= 360;
            while (angles.X < -89.0f)
                angles.X = -89.0f;
            while (angles.Y > 180)
                angles.Y -= 360;
            while (angles.Y < -180)
                angles.Y += 360;
            angles.Z = 0;
            return angles;
        }

        public static Vector3 CalcAngle(Vector3 from, Vector3 to)
        {
            Vector3 angle = new Vector3();
            float dx = from.X - to.X,
                      dy = from.Y - to.Y,
                      dz = from.Z - to.Z;
            double hyp = Math.Sqrt(dx * dx + dy * dy);
            angle.X = (float)(Math.Atan2(dz, hyp) * 57.295779513082f);
            angle.Y = (float)(Math.Atan2(dy, dx) * 57.295779513082f);
            if (double.IsNaN(angle.X)) angle.X = 0;
            if (double.IsNaN(angle.Y)) angle.Y = 0;
            if (dx >= 0.0) { angle.Y += 180.0f; }
            return angle;
        }
    }
}
