using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoraInterface.CustomControls
{
 
    public partial class CTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(64, 64, 64);
        private int borderSize = 2;
        private bool underlinedStyle = true;
        private Color borderColorFocus = Color.FromArgb(253, 189, 19);
        private Color disabledColor = Color.Gainsboro;
        private bool isFocused = false;

        //Construtor da classe.
        public CTextBox()
        {
            InitializeComponent();
        }

        //Getters e setters.
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }

            set
            {
                textBox1.Multiline = value;
            }
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;

                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        public string Texts
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }

            set
            {
                textBox1.MaxLength = value;
            }
        }

        public Color BorderColorFocus
        {
            get
            {
                return borderColorFocus;
            }

            set
            {
                borderColorFocus = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Desenha a borda no custom textbox.
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (this.Enabled == false)
                {
                    penBorder.Color = disabledColor;

                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }

                }
                else if (isFocused == false)
                {
                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }

                } 
                else
                {
                    penBorder.Color = borderColorFocus;

                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);

                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;

                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
