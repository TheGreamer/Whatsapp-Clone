using System;
using System.Drawing;
using System.Windows.Forms;

namespace Whatsapp
{
    public partial class LineTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        
        public LineTextBox()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                Invalidate();
            }
        }

        public bool PasswordChar
        {
            get { return textBox.UseSystemPasswordChar; }
            set { textBox.UseSystemPasswordChar = value; }
        }

        public string PlaceholderText
        {
            get { return textBox.PlaceholderText; }
            set { textBox.PlaceholderText = value; }
        }

        public HorizontalAlignment TextAlign
        {
            get { return textBox.TextAlign; }
            set { textBox.TextAlign = value; }
        }

        public int MaxLength
        {
            get { return textBox.MaxLength; }
            set { textBox.MaxLength = value; }
        }

        public bool Multiline
        {
            get { return textBox.Multiline; }
            set { textBox.Multiline = value; }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox.ForeColor = value;
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }

        public string Texts
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;

                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new(0, txtHeight);
                textBox.Multiline = false;

                Height = textBox.Height + Padding.Top + Padding.Bottom;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
        }
    }
}