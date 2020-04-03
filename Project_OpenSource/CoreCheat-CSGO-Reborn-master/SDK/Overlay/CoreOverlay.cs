using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

//------------------------------------------------
//ATTENTION!
//------------------------------------------------
//THIS CLASS IS MADE BY https://github.com/Lufzys
//THX For Lufzy to giving me this class.
// Class by @Lufzy (Kroxy13)
//------------------------------------------------


namespace CoreCheat_Reborn.SDK.Overlay
{
    class CoreOverlay
    {
        static Structs.Rect pClientRect;
        public static Form pOverlayForm;
        private static Process pProcess;
        private static string pWindowName;
        private static IntPtr pHandle = IntPtr.Zero;
        private static Graphics g;
        private static Rectangle ScreenSize = Screen.GetBounds(ScreenSize);
        private static class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr FindWindow(string ipClassName, string ipWindowName);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowRect(IntPtr hwnd, out Structs.Rect lpRect);

            [DllImport("user32.dll")]
            public static extern IntPtr GetForegroundWindow();

            [DllImport("user32.dll")]
            public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

            [DllImport("kernel32.dll",
    EntryPoint = "GetStdHandle",
    SetLastError = true,
    CharSet = CharSet.Auto,
    CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr GetStdHandle(int nStdHandle);
            [DllImport("kernel32.dll",
                EntryPoint = "AllocConsole",
                SetLastError = true,
                CharSet = CharSet.Auto,
                CallingConvention = CallingConvention.StdCall)]
            public static extern int AllocConsole();
            public const int STD_OUTPUT_HANDLE = -11;
            public const int MY_CODE_PAGE = 437;
        }
        private class Structs
        {
            public struct Rect
            {
                public int left, top, right, bottom;
            }
        }
        public static void Load(string ProcessName, string WindowName)
        {
            try
            {
                pWindowName = WindowName;
                Process[] p = Process.GetProcessesByName(ProcessName);

                if (p.Length > 0)
                {
                    pProcess = p[0];
                    pHandle = NativeMethods.FindWindow(null, pWindowName);

                    pOverlayForm = new Form()
                    {
                        BackColor = System.Drawing.Color.Wheat,
                        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None,
                        ShowIcon = false,
                        ShowInTaskbar = false,
                        TopMost = false,
                        TransparencyKey = System.Drawing.Color.Wheat
                    };

                    #region Threads
                    Timer RefreshOverlaySize = new Timer()
                    {
                        Interval = 1,
                        Enabled = true
                    };
                    Timer ControlUselessDrawing = new Timer()
                    {
                        Interval = 1,
                        Enabled = true
                    };
                    RefreshOverlaySize.Tick += new EventHandler(RefreshOverlaySize_Thread);
                    ControlUselessDrawing.Tick += new EventHandler(ControlUselessDrawing_Thread);
                    pOverlayForm.Paint += new PaintEventHandler(Overlay_Drawing);
                    #endregion

                    pOverlayForm.Show();

                    RefreshSize();

                    int initialStyle = NativeMethods.GetWindowLong(pOverlayForm.Handle, -20);
                    NativeMethods.SetWindowLong(pOverlayForm.Handle, -20, initialStyle | 0x80000 | 0x20);
                }
            }
            catch { }
        }
        private static void ControlUselessDrawing_Thread(object sender, EventArgs e)
        {
            if (GetActiveWindowTitle() == pWindowName)
            {
                pOverlayForm.TopMost = true;
            }
            else
            {
                pOverlayForm.TopMost = false;
            }

            if (pProcess.HasExited)
            {
                pOverlayForm.Close();
            }
        }
        private static void RefreshOverlaySize_Thread(object sender, EventArgs e)
        {
            RefreshSize();
        }
        private static void Overlay_Drawing(object sender, PaintEventArgs e)
        {
            string header = "Hello Cylops & Lufzy!";
            g = e.Graphics;
            DrawFilledRectangle(Pens.Red, 13, 35, (int)(header.Length * 8.785714285714286), 40);
            DrawShadowString("CoreCheat [DEV]", new Font("Segoe UI", 11, FontStyle.Bold), Brushes.Red, 15, 35);
            DrawShadowString(header, new Font("Segoe UI", 11, FontStyle.Italic), Brushes.Red, 15, 55);
            DrawShadowString("LocalPlayer ->" + SDK.Entities.CLocalPlayer.LocalPlayerBase.ToString(), new Font("Segoe UI", 11, FontStyle.Regular), Brushes.Yellow, 15, 75);

        }

        #region Overlay Methods
        public static void RefreshSize()
        {
            NativeMethods.GetWindowRect(pHandle, out pClientRect);
            pOverlayForm.Size = new System.Drawing.Size(pClientRect.right - pClientRect.left, pClientRect.bottom - pClientRect.top);
            pOverlayForm.Top = pClientRect.top;
            pOverlayForm.Left = pClientRect.left;
        }
        private static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = NativeMethods.GetForegroundWindow();

            if (NativeMethods.GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        #endregion

        #region Drawing
        public static void DrawString(string Text, Font Font, Brush Brush, int x, int y)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(Text, Font, Brush, x, y);
        }
        public static void DrawShadowString(string Text, Font Font, Brush Brush, int x, int y)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(Text, Font, Brushes.Black, x + 1, y - 1);
            g.DrawString(Text, Font, Brushes.Black, x - 1, y + 1);
            g.DrawString(Text, Font, Brushes.Black, x - 1, y - 1);
            g.DrawString(Text, Font, Brushes.Black, x + 1, y + 1);
            g.DrawString(Text, Font, Brush, x, y);
        }
        public static void DrawRectangle(Pen Pen, int x, int y, int Width, int Height)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.DrawRectangle(Pen, x, y, Width, Height);
        }
        public static void DrawShadowRectangle(Pen Pen, int x, int y, int Width, int Height)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.DrawRectangle(Pens.Black, x + 1, y - 1, Width, Height);
            g.DrawRectangle(Pens.Black, x - 1, y + 1, Width, Height);
            g.DrawRectangle(Pens.Black, x - 1, y - 1, Width, Height);
            g.DrawRectangle(Pens.Black, x + 1, y + 1, Width, Height);
            g.DrawRectangle(Pen, x, y, Width, Height);
        }
        public static void DrawFilledRectangle(Pen Pen, int x, int y, int Width, int Height)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.FillRectangle(Brushes.Black, x, y, Width, Height);
            g.DrawRectangle(Pens.Black, x + 1, y - 1, Width, Height);
            g.DrawRectangle(Pens.Black, x - 1, y + 1, Width, Height);
            g.DrawRectangle(Pens.Black, x - 1, y - 1, Width, Height);
            g.DrawRectangle(Pens.Black, x + 1, y + 1, Width, Height);
            g.DrawRectangle(Pen, x, y, Width, Height);
        }
        public static void DrawCircle(Pen Pen, int x, int y, int Width, int Height)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.DrawEllipse(Pen, x, y, Width, Height);
        }
        public static void DrawShadowCircle(Pen Pen, int x, int y, int Width, int Height)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.DrawEllipse(Pens.Black, x + 1, y - 1, Width, Height);
            g.DrawEllipse(Pens.Black, x - 1, y + 1, Width, Height);
            g.DrawEllipse(Pens.Black, x - 1, y - 1, Width, Height);
            g.DrawEllipse(Pens.Black, x + 1, y + 1, Width, Height);
            g.DrawEllipse(Pen, x, y, Width, Height);
        }
        #endregion
    }
}
