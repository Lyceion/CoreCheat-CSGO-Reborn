using System;
using System.Drawing;
using CoreCheat_Reborn.SDK.Managers;
using static CoreCheat_Reborn.Debugger.Datas;

namespace CoreCheat_Reborn.Debugger
{
    public partial class Debugger : MetroFramework.Forms.MetroForm
    {
        public Debugger(/*Structs.Cheat cht*/ string cht, Color consoleColor, MetroFramework.MetroColorStyle scheme)
        {
            InitializeComponent();
            LoadInfoText();
            HookedCheat = cht;
            Text += " -> {cht}";
            console.ForeColor = consoleColor;
            Style = scheme;
        }
        public void log(string Message)
        {
            AddInfoToDebugger(Message);
        }
        public void log(string Message,string Tag)
        {
            AddInfoToDebugger(String.Format("[{0}] {1}",Tag, Message));
        }
        private void Debugger_Load(object sender, System.EventArgs e)
        {
            Refresh();
        }
        private void LoadInfoText()
        {
            if (Modules.ClientDLLAdress > 0 || Modules.EngineDLLAdress > 0)
            {
                dlls.Text = "Hooked All DLLS Sucsessfully!";
            }
            else if (Modules.ClientDLLAdress <= 0 || Modules.EngineDLLAdress <= 0)
            {
                dlls.ForeColor = Color.Red;
                dlls.Text = "Can't get any dll!";
            }
            else if (Modules.EngineDLLAdress <= 0 || Modules.ClientDLLAdress > 0)
            {
                dlls.ForeColor = Color.Red;
                dlls.Text = "Can't Hook 'engine.dll'!";
            }
            else if (Modules.EngineDLLAdress > 0 || Modules.ClientDLLAdress <= 0)
            {
                dlls.ForeColor = Color.Red;
                dlls.Text = "Can't Hook 'client_panorama.dll'!";
            }
            else
            {
                dlls.ForeColor = Color.DodgerBlue;
                dlls.Text = "NULL";
            }
            AddInfoToDebugger("Console Attached  To {HookedCheat} Sucsessfully.");
        }
        public void AddInfoToDebugger(string Message, object DATA = null)
        {
            if (isAttached)
            {
                if (DATA == null)
                    console.Text += "[" + DateTime.Now.ToString("HH:mm") + "] {Message}" + Environment.NewLine;
                else
                    console.Text += "[" + DateTime.Now.ToString("HH:mm") + "] {Message} DATA OUTPUT => " + DATA.ToString() + Environment.NewLine;
            }
        }
    }
}
