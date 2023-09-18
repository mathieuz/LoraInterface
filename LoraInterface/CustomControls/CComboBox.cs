using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoraInterface.CustomControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class CComboBox : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.FromArgb(65, 65, 65);
        private Color listBackColor = Color.FromArgb(230, 224, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.FromArgb(65, 65, 65);
        private int borderSize = 1;

        private ComboBox comboList;
        private Label labelText;
        private Button buttonIcon;

        public new Color BackColor
        {
            get
            {
                return backColor;
            }

            set
            {
                backColor = value;
                labelText.BackColor = backColor;
                buttonIcon.BackColor = backColor;
            }
        }

        public Color IconColor
        {
            get
            {
                return iconColor;
            }

            set
            {
                iconColor = value;
                buttonIcon.Invalidate();
            }
        }

        public Color ListBackColor
        {
            get
            {
                return listBackColor;
            }

            set
            {
                listBackColor = value;
                comboList.BackColor = listBackColor;
            }
        }

        public Color ListTextColor
        {
            get
            {
                return listTextColor;
            }

            set
            {
                listTextColor = value;
                comboList.ForeColor = listTextColor;
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                base.BackColor = borderColor;
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
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
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
                labelText.ForeColor = value;
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
                labelText.Font = value;
                comboList.Font = value;
            }
        }

        public string Texts
        {
            get
            {
                return labelText.Text;
            }

            set
            {
                labelText.Text = value;
            }
        }

        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return comboList.DropDownStyle;
            }

            set
            {
                if (comboList.DropDownStyle != ComboBoxStyle.Simple)
                {
                    comboList.DropDownStyle = value;
                }
                
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return comboList.Items;
            }
        }

        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get
            {
                return comboList.DataSource;
            }

            set
            {
                comboList.DataSource = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return comboList.AutoCompleteCustomSource;
            }

            set
            {
                comboList.AutoCompleteCustomSource = value;
            }
        }

        [DefaultValue(AutoCompleteSource.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return comboList.AutoCompleteSource;
            }

            set
            {
                comboList.AutoCompleteSource = value;
            }
        }

        [DefaultValue(AutoCompleteMode.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return comboList.AutoCompleteMode;
            }

            set
            {
                comboList.AutoCompleteMode = value;
            }
        }

        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get
            {
                return comboList.SelectedItem;
            }

            set
            {
                comboList.SelectedItem = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                return comboList.SelectedIndex;
            }

            set
            {
                comboList.SelectedIndex = value;
            }
        }

        public event EventHandler OnSelectedIndexChanged;

        public CComboBox()
        {
            comboList = new ComboBox();
            labelText = new Label();
            buttonIcon = new Button();

            comboList.BackColor = ListBackColor;
            comboList.Font = new Font(this.Font.Name, 10f);
            comboList.ForeColor = ListTextColor;
            comboList.Dock = DockStyle.Fill;

            comboList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            comboList.TextChanged += new EventHandler(ComboBox_TextChanged);

            buttonIcon.Dock = DockStyle.Right;
            buttonIcon.FlatStyle = FlatStyle.Flat;
            buttonIcon.FlatAppearance.BorderSize = 0;
            buttonIcon.BackColor = BackColor;
            buttonIcon.Size = new Size(30, 30);
            buttonIcon.Cursor = Cursors.Hand;

            buttonIcon.Click += new EventHandler(icon_click);
            buttonIcon.Paint += new PaintEventHandler(icon_paint);

            labelText.Dock = DockStyle.Fill;
            labelText.AutoSize = false;
            labelText.BackColor = BackColor;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.Padding = new Padding(5, 0, 0, 0);
            labelText.Font = new Font(this.Font.Name, 10f);
            labelText.Click += new EventHandler(Surface_Click);

            this.Controls.Add(labelText);
            this.Controls.Add(buttonIcon);
            this.Controls.Add(comboList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(BorderSize);
            base.BackColor = BorderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();

            InitializeComponent();
        }

        private void AdjustComboBoxDimensions()
        {
            comboList.Width = labelText.Width;
            comboList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - comboList.Width,
                Y = labelText.Bottom - labelText.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            comboList.Select();

            if (comboList.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                comboList.DroppedDown = true;
            }
        }

        private void icon_paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;

            var rectIcon = new Rectangle((buttonIcon.Width - iconWidth) / 2, (buttonIcon.Height - iconHeight) / 2, iconWidth, iconHeight);

            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(IconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void icon_click(object sender, EventArgs e)
        {
            comboList.Select();
            comboList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            labelText.Text = comboList.Text;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }

            labelText.Text = comboList.Text.ToString();
        }

        private void CComboBox_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                base.BackColor = Color.FromArgb(64, 64, 64);

            } else
            {
                base.BackColor = Color.Gainsboro;
            }
        }
    }
}
