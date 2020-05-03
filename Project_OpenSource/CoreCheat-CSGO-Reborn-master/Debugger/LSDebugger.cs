using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace LSDebug
{
    public enum TextType
    {
        Info = 0,
        Warning = 1,
        Danger = 2,
        Safe = 3,
        Success = 4,
        Failed = 5
    }
    public enum ResizeType
    {
        Percent = 0,
        Pixel = 1
    }

    #region LS Splitter Panel
    class LSSplitterPanel : Panel
    {
        public Panel Panel1, Panel2;
        public ResizeType ResizeType = ResizeType.Pixel;
        private int WidthPercentPanel_ = 30, WidthPanel_;
        public int WidthPercentPanel
        {
            get
            {
                return WidthPercentPanel_;
            }
            set
            {
                WidthPercentPanel_ = value;
                ResizeType = ResizeType.Percent;
                InitializePanelStyle();
            }
        }
        public int WidthPanel
        {
            get
            {
                return WidthPanel_;
            }
            set
            {
                WidthPanel_ = value;
                ResizeType = ResizeType.Pixel;
                InitializePanelStyle();
            }
        }
        private bool Reverse_ = false;
        public bool Reverse
        {
            get
            {
                return Reverse_;
            }
            set
            {
                Reverse_ = value;
                InitializePanelStyle();
            }
        }
        public LSSplitterPanel(Panel panel1, Panel panel2) : base()
        {
            InitializeStyle();
            Panel1 = panel1;
            Panel2 = panel2;
            WidthPanel = this.Width / 2;
            Controls.Add(Panel1);
            Controls.Add(Panel2);
        }
        public LSSplitterPanel() : base()
        {
            InitializeStyle();
            Panel1 = new Panel();
            Panel2 = new Panel();
            WidthPanel = this.Width / 2;
            Panel1.BackColor = Color.Red;
            Panel2.BackColor = Color.Green;
            Controls.Add(Panel1);
            Controls.Add(Panel2);
        }
        private void InitializeStyle()
        {
            BorderStyle = BorderStyle.None;
            BackColor = Color.Purple; // Color.FromArgb(23, 23, 23);
            ForeColor = Color.FromArgb(238, 238, 238);
            Dock = DockStyle.Fill;
            Resize += OnResizePanel;
        }
        public void InitializePanelStyle()
        {
            Panel p1, p2;
            p1 = Reverse_ ? Panel2 : Panel1;
            p2 = Reverse_ ? Panel1 : Panel2;
            if (p1 != null && p2 != null)
            {
                int p1w, p2w;
                p1.Height = Height;
                p2.Height = Height;
                p1w = ResizeType == ResizeType.Pixel ? WidthPanel_ : Width * WidthPercentPanel_ / 100;
                p2w = Width - p1w;
                p1.Width = p1w;
                p2.Left = p1w;
                p2.Width = p2w;
            }
        }
        private void OnResizePanel(object sender, EventArgs e)
        {
            InitializePanelStyle();
        }
    }
    #endregion

    #region LSDebugUI Main
    class LSDebugUI : Form
    {
        private LSDebug LST = new LSDebug();
        public LSDebugVariable LSTV = new LSDebugVariable();
        public LSSplitterPanel SPC = new LSSplitterPanel();
        public LSDebugUI() : base()
        {
            SPC.BackColor = Color.FromArgb(23, 23, 23);
            SPC.Dock = DockStyle.Fill;
            SPC.Visible = true;
            SPC.BorderStyle = BorderStyle.None;
            Controls.Add(SPC);
            SPC.Panel1.Controls.Add(LSTV);
            SPC.Panel2.Controls.Add(LST);
            SPC.WidthPanel = 380;
            Size = new Size(980, 460);

            LST.Visible = true;
            LST.Dock = DockStyle.Fill;

            LSTV.Visible = true;
            LSTV.Dock = DockStyle.Fill;

        }
        public bool Symbolizator
        {
            get
            {
                return LST.Symbolizator;
            }
            set
            {
                LST.Symbolizator = value;
            }
        }
        public bool TimeBool
        {
            get
            {
                return LST.TimeBool;
            }
            set
            {
                LST.TimeBool = value;
            }
        }
        #region VariableDebugger
        public async void SetVariable(string VariableName, int value)
        {
            LSTV.SetVariable(VariableName, value);
        }
        #endregion
        #region ConsoleDebugger
        public void Debug()
        {
            this.Show();
        }
        public async void Print(object text)
        {
            this.LST.Print(text.ToString());
        }
        public async void PrintLine(object text)
        {
            this.LST.PrintLine(text.ToString());
        }
        public async void Print(object text, Color color)
        {
            this.LST.Print(text.ToString(), color);
        }
        public async void PrintLine(object text, Color color)
        {
            this.LST.PrintLine(text.ToString(), color);
        }
        public async void Print(object text, TextType type)
        {
            this.LST.Print(text.ToString(), type);
        }
        public async void PrintLine(object text, TextType type)
        {
            this.LST.PrintLine(text.ToString(), type);
        }
        public async void DumpBytes(byte[] bytes)
        {
            this.LST.DumpBytes(bytes);
        }
        public async void DumpBytes(byte[] bytes, int offset)
        {
            this.LST.DumpBytes(bytes, offset);
        }
        public async void DumpBytes(byte[] bytes, int offset, string label)
        {
            this.LST.DumpBytes(bytes, offset, label);
        }
        #endregion
    }
    #endregion

    #region Build Of ConsoleDebugger
    class LSDebug : RichTextBox
    {
        public static Color MainThemeColor = Color.FromArgb(9, 9, 7);
        public static Color SecondaryThemeColor = Color.FromArgb(150, 0, 0);
        public static Color TextColor = Color.FromArgb(238, 238, 238);
        public static Color WarningColor = Color.FromArgb(237, 194, 0);
        public static Color DangerColor = Color.FromArgb(255, 0, 0);
        public static Color InfoColor = Color.FromArgb(173, 173, 173);
        public static Color SafeColor = Color.FromArgb(0, 141, 242);
        public static Color SuccessColor = Color.FromArgb(0, 245, 41);
        public static Color FailedColor = Color.FromArgb(252, 16, 13);
        public LSDebug() : base()
        {
            BackColor = MainThemeColor;
            ForeColor = TextColor;
            Margin = new Padding(8, 8, 8, 8);
            Font = new Font(new FontFamily("Consolas"),
                                 9f,
                                 FontStyle.Regular,
                                 GraphicsUnit.Point
            );
            BorderStyle = BorderStyle.None;
            ReadOnly = true;
            Cursor = Cursors.Default;
        }

        #region Hex Dumping
        public int H_BYTESOFLINE = 16;
        public int H_MARGINON = 0X7;
        public Color AddressColor = Color.FromArgb(255, 149, 0);
        public Color ByteColor = Color.FromArgb(0, 255, 0);
        public void DumpBytes(byte[] bytes)
        {
            for (int i = 0; i <= bytes.Length / H_BYTESOFLINE; i++)
            {
                int LineOffset = i * H_BYTESOFLINE;
                int GetTopOfSize = bytes.Length - LineOffset <= 16 ? bytes.Length - LineOffset : 16;
                Write(string.Format("0x{0}\t", LineOffset.ToString("X8")), AddressColor);
                for (int j = 0; j < H_BYTESOFLINE; j++)
                {
                    if (j < GetTopOfSize)
                    {
                        Write(bytes[LineOffset + j].ToString("X2"), ByteColor);
                        if (!(GetTopOfSize == j - 1))
                            Write(" ");
                    }
                    else
                    {
                        Write("  ");
                        if (!(H_BYTESOFLINE == j - 1))
                            Write(" ");
                    }
                    if (H_MARGINON == j)
                        Write(" ");
                }
                Write("  ");
                for (int j = 0; j < H_BYTESOFLINE; j++)
                {
                    if (j < GetTopOfSize)
                    {
                        byte tb = bytes[LineOffset + j];
                        this.Write(tb < 32 ? "." : ((char)tb).ToString());
                    }
                }
                Write("\n");
            }
            GotoBottom();
        }
        public void DumpBytes(byte[] bytes, int offset)
        {
            Write("Dumping from ");
            Write(string.Format("0x{0}", offset.ToString("X8")), AddressColor);
            Write("\n");
            for (int i = 0; i <= bytes.Length / H_BYTESOFLINE; i++)
            {
                int LineOffset = i * H_BYTESOFLINE;
                int GetTopOfSize = bytes.Length - LineOffset <= 16 ? bytes.Length - LineOffset : 16;
                Write("\t");
                Write(string.Format("0x{0}\t", (offset + LineOffset).ToString("X8")), AddressColor);
                for (int j = 0; j < H_BYTESOFLINE; j++)
                {
                    if (j < GetTopOfSize)
                    {
                        Write(bytes[LineOffset + j].ToString("X2"), ByteColor);
                        if (!(GetTopOfSize == j - 1))
                            Write(" ");
                    }
                    else
                    {
                        Write("  ");
                        if (!(H_BYTESOFLINE == j - 1))
                            Write(" ");
                    }
                    if (H_MARGINON == j)
                        Write(" ");

                }
                Write("  ");
                for (int j = 0; j < H_BYTESOFLINE; j++)
                {
                    if (j < GetTopOfSize)
                    {
                        byte tb = bytes[LineOffset + j];
                        Write(tb < 32 ? "." : ((char)tb).ToString());
                    }
                }
                Write("\n");
            }
            GotoBottom();
        }
        public void DumpBytes(byte[] bytes, int offset, string label)
        {
            Write(" [");
            Write(string.Format("0x{0}", offset.ToString("X8")), AddressColor);
            Write(string.Format("]{0}\n", label));
            for (int i = 0; i <= bytes.Length / H_BYTESOFLINE; i++)
            {
                int LineOffset = i * H_BYTESOFLINE;
                int GetTopOfSize = bytes.Length - LineOffset <= 16 ? bytes.Length - LineOffset : 16;
                Write("\t");
                Write(string.Format("0x{0}\t", (offset + LineOffset).ToString("X8")), AddressColor);
                for (int j = 0; j < H_BYTESOFLINE; j++)
                {
                    if (j < GetTopOfSize)
                    {
                        Write(bytes[LineOffset + j].ToString("X2"), ByteColor);
                        if (!(GetTopOfSize == j - 1))
                            Write(" ");
                    }
                    else
                    {
                        Write("  ");
                        if (!(H_BYTESOFLINE == j - 1))
                            Write(" ");
                    }
                    if (H_MARGINON == j)
                        Write(" ");

                }
                Write("  ");
                for (int j = 0; j < H_BYTESOFLINE; j++)
                {
                    if (j < GetTopOfSize)
                    {
                        byte tb = bytes[LineOffset + j];
                        this.Write(tb < 32 ? "." : ((char)tb).ToString());
                    }
                }
                Write("\n");
            }
        }
        #endregion

        #region Date And Symbolization
        public bool TimeBool = true, Symbolizator = true;
        private void LogDate()
        {
            AppendText("[");
            SelectionColor = WarningColor;
            AppendText(DateTime.Now.ToShortDateString());
            AppendText(" ");
            AppendText(DateTime.Now.ToLongTimeString());
            SelectDefaultColor();
            AppendText("]");
        }
        public void AppendSymbolizator(TextType type)
        {
            if (!Symbolizator)
                return;
            Color tempcolor = this.SelectionColor;
            SelectionColor = TextColor;
            AppendText("[");
            SelectionColor = tempcolor;
            if (TextType.Warning.Equals(type))
            {
                SelectionColor = WarningColor;
                AppendText("?");
            }
            else if (TextType.Danger.Equals(type))
            {
                SelectionColor = DangerColor;
                AppendText("!");
            }
            else if (TextType.Failed.Equals(type))
            {
                SelectionColor = FailedColor;
                AppendText("-");
            }
            else if (TextType.Success.Equals(type))
            {
                SelectionColor = SuccessColor;

                AppendText("+");
            }
            else
            {
                SelectionColor = SafeColor;
                AppendText("*");

            }
            SelectionColor = TextColor;
            AppendText("]");
            SelectionColor = tempcolor;
        }
        #endregion

        #region Console Raw Printing
        public void Write(string Text)
        {
            AppendText(Text);
        }
        public void GotoBottom()
        {
            SelectionStart = Text.Length;
            ScrollToCaret();
        }
        public void Write(string Text, Color color)
        {
            Color tmpcolor = SelectionColor;
            SelectionColor = color;
            AppendText(Text);
            SelectionColor = tmpcolor;
        }
        #endregion

        #region Console Printing
        public void Print(String text)
        {
            if (TimeBool)
            {
                LogDate();
            }
            Write(text);
            GotoBottom();
        }
        public void PrintLine(String text)
        {
            if (TimeBool)
            {
                LogDate();
            }
            Write(text);
            AppendText("\n");
            GotoBottom();
        }
        public void Print(String text, Color color)
        {
            if (TimeBool)
            {
                LogDate();
            }
            Write(text, color);
            GotoBottom();
        }
        public void PrintLine(String text, Color color)
        {
            if (TimeBool)
            {
                LogDate();
            }
            Write(text, color);
            AppendText("\n");
            GotoBottom();
        }
        public void Print(String text, TextType type)
        {
            if (TimeBool)
            {
                LogDate();
            }
            SelectTypeOfColor(type);
            AppendSymbolizator(type);
            Write(text);
            SelectDefaultColor();
            GotoBottom();
        }
        public void PrintLine(String text, TextType type)
        {
            if (TimeBool)
            {
                LogDate();
            }
            SelectTypeOfColor(type);
            AppendSymbolizator(type);
            Write(text);
            SelectDefaultColor();
            Write("\n");
            GotoBottom();
        }
        #endregion

        #region Color Selection
        public void SelectTypeOfColor(TextType type)
        {
            if (TextType.Warning.Equals(type))
            {
                SelectionColor = WarningColor;

            }
            else if (TextType.Info.Equals(type))
            {
                SelectionColor = InfoColor;

            }
            else if (TextType.Danger.Equals(type))
            {
                SelectionColor = DangerColor;

            }
            else if (TextType.Safe.Equals(type))
            {
                SelectionColor = SafeColor;

            }
            else if (TextType.Success.Equals(type))
            {
                SelectionColor = SuccessColor;
            }
            else
            {
                SelectionColor = InfoColor;
            }
        }
        public void SelectDefaultColor()
        {
            SelectionColor = TextColor;
        }
        #endregion
    }
    #endregion

    #region Build Of VariableDebugger
    class LSDebugVariable : DataGridView
    {
        public static Color MainThemeColor = Color.FromArgb(9, 9, 7);
        public static Color MainGridColor = Color.FromArgb(15, 15, 13);
        public static Color SecondaryThemeColor = Color.FromArgb(150, 0, 0);
        public static Color TextColor = Color.FromArgb(238, 238, 238);
        public static Color CellStyle_BackgroundColor = Color.FromArgb(21, 21, 21);
        public static Color CellStyle_SelectionColor = Color.FromArgb(29, 29, 29);
        public static Color CellStyleHeader_BackgroundColor = Color.FromArgb(25, 25, 25);
        public static Color CellStyleHeader_SelectionColor = Color.FromArgb(29, 29, 29);
        public static Image VariableIcon = Base64StringToBitmap("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");
        public static Image Base64StringToBitmap(string base64String)
        {
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);
            memoryStream.Position = 0;
            Image bmpReturn = Image.FromStream(memoryStream);
            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;
            return bmpReturn;
        }
        public LSDebugVariable() : base()
        {
            BackgroundColor = MainThemeColor;
            GridColor = MainGridColor;
            ForeColor = TextColor;
            Margin = new Padding(8, 8, 8, 8);
            Font = new Font(new FontFamily("Consolas"),
                                 9f,
                                 FontStyle.Regular,
                                 GraphicsUnit.Point
            );
            BorderStyle = BorderStyle.None;
            DefaultCellStyle.BackColor = CellStyle_BackgroundColor;
            DefaultCellStyle.SelectionBackColor = CellStyle_SelectionColor;
            DefaultCellStyle.ForeColor = TextColor;
            ColumnHeadersDefaultCellStyle.BackColor = CellStyleHeader_BackgroundColor;
            ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            RowHeadersDefaultCellStyle.BackColor = CellStyleHeader_BackgroundColor;
            RowHeadersDefaultCellStyle.ForeColor = TextColor;
            RowHeadersDefaultCellStyle.Padding = new Padding(3, 2, 3, 2);
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersWidth = 30;
            BorderStyle = BorderStyle.None;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ReadOnly = true;
            EnableHeadersVisualStyles = false;
            RowPostPaint += RowPostPaintEvent;
            DataGridViewCell cellTemplate = new DataGridViewTextBoxCell();

            DataGridViewColumn nameColumn = new DataGridViewColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.CellTemplate = cellTemplate;
            DataGridViewColumn valueColumn = new DataGridViewColumn();
            valueColumn.Name = "Value";
            valueColumn.HeaderText = "Value";
            valueColumn.CellTemplate = cellTemplate;
            DataGridViewColumn hexColumn = new DataGridViewColumn();
            hexColumn.Name = "Hex";
            hexColumn.HeaderText = "Hex";
            hexColumn.CellTemplate = cellTemplate;
            DataGridViewColumn typeColumn = new DataGridViewColumn();
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "Type";
            typeColumn.CellTemplate = cellTemplate;
            typeColumn.Width = 50;
            Columns.Add(nameColumn);
            Columns.Add(valueColumn);
            Columns.Add(hexColumn);
            Columns.Add(typeColumn);
        }
        public void RowPostPaintEvent(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            if (Rows[e.RowIndex].Cells[0].Value != null)
            {
                Icon VariableIco = Icon.FromHandle(((Bitmap)VariableIcon).GetHicon());
                Graphics graphics = e.Graphics;

                int w = 20;
                int h = 20;
                int x = e.RowBounds.X + ((RowHeadersWidth - w) / 2);
                int y = e.RowBounds.Y + (Rows[e.RowIndex].Height - h) / 2;

                Rectangle rectangle = new Rectangle(x, y, w, h);
                graphics.DrawIcon(VariableIco, rectangle);
            }

        }
        public bool CheckInRow(string VariableName)
        {
            foreach (DataGridViewRow item in Rows)
            {
                if (item.Cells[0].Value != null)
                    if (item.Cells[0].Value.ToString().Equals(VariableName))
                        return true;
            }
            return false;
        }
        public int GetIndexByVarName(string VariableName)
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                DataGridViewRow element = Rows[i];
                if (element.Cells[0].Value != null)
                    if (element.Cells[0].Value.ToString().Equals(VariableName))
                        return i;
            }
            return -1;
        }
        private string tmpv = "";
        private int tmpin;
        public void SetVariable(string VariableName, int value)
        {
            if (tmpv.Equals(VariableName))
            {
                Rows[tmpin].Cells[1].Value = value;
                Rows[tmpin].Cells[2].Value = String.Format("0x{0}", value.ToString("X8"));
                return;
            }
            tmpv = VariableName;
            if (CheckInRow(VariableName))
            {
                int i = GetIndexByVarName(VariableName);
                tmpin = i;

                if (i >= 0)
                {
                    Rows[i].Cells[1].Value = value;
                    Rows[i].Cells[2].Value = String.Format("0x{0}", value.ToString("X8"));
                }
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)Rows[0].Clone();
                row.Tag = VariableName;
                row.Cells[0].Value = VariableName;
                row.Cells[1].Value = value;
                row.Cells[2].Value = String.Format("0x{0}", value.ToString("X8"));
                row.Cells[3].Value = "int";
                row.Height = 30;
                tmpin = Rows.Add(row);

            }
            //ListViewItem item = new ListViewItem(VariableName);
            //item.SubItems.Add(VariableName);
            //item.SubItems.Add(String.Format("0x{0}", value.ToString("X8")));
            //item.SubItems.Add("int");
        }
    }
    #endregion
}
