namespace LoraInterface.Forms
{
    partial class FormConfigurarIos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxCOM = new LoraInterface.CustomControls.CComboBox();
            this.conectarCOMButton = new FontAwesome.Sharp.IconButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(290, 22);
            this.label11.TabIndex = 8;
            this.label11.Text = "Configurar modos e zonas dos IOs";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(10, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(630, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conectar COM";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.conectarCOMButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 24);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(610, 74);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBoxCOM);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel6.Size = new System.Drawing.Size(427, 54);
            this.panel6.TabIndex = 13;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxCOM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxCOM.BorderSize = 1;
            this.comboBoxCOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxCOM.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxCOM.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxCOM.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.comboBoxCOM.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxCOM.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCOM.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.comboBoxCOM.MinimumSize = new System.Drawing.Size(370, 53);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxCOM.Size = new System.Drawing.Size(422, 53);
            this.comboBoxCOM.TabIndex = 15;
            this.comboBoxCOM.Texts = "";
            // 
            // conectarCOMButton
            // 
            this.conectarCOMButton.BackColor = System.Drawing.Color.LimeGreen;
            this.conectarCOMButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conectarCOMButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.conectarCOMButton.FlatAppearance.BorderSize = 0;
            this.conectarCOMButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.conectarCOMButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.conectarCOMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conectarCOMButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectarCOMButton.ForeColor = System.Drawing.Color.White;
            this.conectarCOMButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.conectarCOMButton.IconColor = System.Drawing.Color.Black;
            this.conectarCOMButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.conectarCOMButton.Location = new System.Drawing.Point(437, 10);
            this.conectarCOMButton.Name = "conectarCOMButton";
            this.conectarCOMButton.Size = new System.Drawing.Size(163, 54);
            this.conectarCOMButton.TabIndex = 12;
            this.conectarCOMButton.Text = "Conectar COM";
            this.conectarCOMButton.UseVisualStyleBackColor = false;
            this.conectarCOMButton.Click += new System.EventHandler(this.conectarCOMButton_Click);
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(10, 32);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(630, 36);
            this.panel15.TabIndex = 10;
            // 
            // FormConfigurarIos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(650, 597);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConfigurarIos";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private CustomControls.CComboBox comboBoxCOM;
        private FontAwesome.Sharp.IconButton conectarCOMButton;
        private System.Windows.Forms.Panel panel15;
    }
}