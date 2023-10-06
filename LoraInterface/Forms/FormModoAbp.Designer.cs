﻿namespace LoraInterface.Forms
{
    partial class FormModoAbp
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxCOM = new LoraInterface.CustomControls.CComboBox();
            this.conectarCOMButton = new FontAwesome.Sharp.IconButton();
            this.chavesDeAtivacaoGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceEuiTextBox = new LoraInterface.CustomControls.CTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nwkskeyTextBox = new LoraInterface.CustomControls.CTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.appskeyTextBox = new LoraInterface.CustomControls.CTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.deviceAddressTextBox = new LoraInterface.CustomControls.CTextBox();
            this.configuracoesConexaoGroup = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.conectarLoraButton = new FontAwesome.Sharp.IconButton();
            this.modoDeConfirmacaoGroup = new System.Windows.Forms.Panel();
            this.modoConfirmacaoToggle = new LoraInterface.CustomControls.CToggle();
            this.label8 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.numeroRetentativasComboBox = new LoraInterface.CustomControls.CComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.classeComboBox = new LoraInterface.CustomControls.CComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comandosATGroup = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.atSendButton = new FontAwesome.Sharp.IconButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.atSendPortaComboBox = new LoraInterface.CustomControls.CComboBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.atSendTextoTextBox = new LoraInterface.CustomControls.CTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.chavesDeAtivacaoGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.configuracoesConexaoGroup.SuspendLayout();
            this.panel7.SuspendLayout();
            this.modoDeConfirmacaoGroup.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel10.SuspendLayout();
            this.comandosATGroup.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.groupBox1.Size = new System.Drawing.Size(607, 108);
            this.groupBox1.TabIndex = 1;
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
            this.panel5.Size = new System.Drawing.Size(587, 74);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBoxCOM);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel6.Size = new System.Drawing.Size(404, 54);
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
            this.comboBoxCOM.Size = new System.Drawing.Size(399, 53);
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
            this.conectarCOMButton.Location = new System.Drawing.Point(414, 10);
            this.conectarCOMButton.Name = "conectarCOMButton";
            this.conectarCOMButton.Size = new System.Drawing.Size(163, 54);
            this.conectarCOMButton.TabIndex = 12;
            this.conectarCOMButton.Text = "Conectar COM";
            this.conectarCOMButton.UseVisualStyleBackColor = false;
            this.conectarCOMButton.Click += new System.EventHandler(this.conectarCOMButton_Click);
            // 
            // chavesDeAtivacaoGroup
            // 
            this.chavesDeAtivacaoGroup.AutoSize = true;
            this.chavesDeAtivacaoGroup.Controls.Add(this.panel1);
            this.chavesDeAtivacaoGroup.Controls.Add(this.panel2);
            this.chavesDeAtivacaoGroup.Controls.Add(this.panel3);
            this.chavesDeAtivacaoGroup.Controls.Add(this.panel4);
            this.chavesDeAtivacaoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.chavesDeAtivacaoGroup.Enabled = false;
            this.chavesDeAtivacaoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chavesDeAtivacaoGroup.ForeColor = System.Drawing.Color.Gray;
            this.chavesDeAtivacaoGroup.Location = new System.Drawing.Point(10, 176);
            this.chavesDeAtivacaoGroup.Name = "chavesDeAtivacaoGroup";
            this.chavesDeAtivacaoGroup.Padding = new System.Windows.Forms.Padding(10);
            this.chavesDeAtivacaoGroup.Size = new System.Drawing.Size(607, 266);
            this.chavesDeAtivacaoGroup.TabIndex = 3;
            this.chavesDeAtivacaoGroup.TabStop = false;
            this.chavesDeAtivacaoGroup.Text = "Chaves de Ativação";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deviceEuiTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 198);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(587, 58);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "DEVICE EUI";
            // 
            // deviceEuiTextBox
            // 
            this.deviceEuiTextBox.AutoSize = true;
            this.deviceEuiTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEuiTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deviceEuiTextBox.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.deviceEuiTextBox.BorderSize = 2;
            this.deviceEuiTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceEuiTextBox.ForeColor = System.Drawing.Color.Black;
            this.deviceEuiTextBox.Location = new System.Drawing.Point(10, 10);
            this.deviceEuiTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.deviceEuiTextBox.MaxLength = 16;
            this.deviceEuiTextBox.Multiline = false;
            this.deviceEuiTextBox.Name = "deviceEuiTextBox";
            this.deviceEuiTextBox.Padding = new System.Windows.Forms.Padding(12, 10, 3, 3);
            this.deviceEuiTextBox.Size = new System.Drawing.Size(567, 29);
            this.deviceEuiTextBox.TabIndex = 7;
            this.deviceEuiTextBox.Texts = "";
            this.deviceEuiTextBox.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nwkskeyTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 140);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(587, 58);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "NWKSKEY";
            // 
            // nwkskeyTextBox
            // 
            this.nwkskeyTextBox.AutoSize = true;
            this.nwkskeyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nwkskeyTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nwkskeyTextBox.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.nwkskeyTextBox.BorderSize = 2;
            this.nwkskeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nwkskeyTextBox.ForeColor = System.Drawing.Color.Black;
            this.nwkskeyTextBox.Location = new System.Drawing.Point(10, 10);
            this.nwkskeyTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nwkskeyTextBox.MaxLength = 32;
            this.nwkskeyTextBox.Multiline = false;
            this.nwkskeyTextBox.Name = "nwkskeyTextBox";
            this.nwkskeyTextBox.Padding = new System.Windows.Forms.Padding(12, 10, 3, 3);
            this.nwkskeyTextBox.Size = new System.Drawing.Size(567, 29);
            this.nwkskeyTextBox.TabIndex = 7;
            this.nwkskeyTextBox.Texts = "";
            this.nwkskeyTextBox.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.appskeyTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 82);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(587, 58);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "APPSKEY";
            // 
            // appskeyTextBox
            // 
            this.appskeyTextBox.AutoSize = true;
            this.appskeyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.appskeyTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appskeyTextBox.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.appskeyTextBox.BorderSize = 2;
            this.appskeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appskeyTextBox.ForeColor = System.Drawing.Color.Black;
            this.appskeyTextBox.Location = new System.Drawing.Point(10, 10);
            this.appskeyTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.appskeyTextBox.MaxLength = 32;
            this.appskeyTextBox.Multiline = false;
            this.appskeyTextBox.Name = "appskeyTextBox";
            this.appskeyTextBox.Padding = new System.Windows.Forms.Padding(12, 10, 3, 3);
            this.appskeyTextBox.Size = new System.Drawing.Size(567, 29);
            this.appskeyTextBox.TabIndex = 7;
            this.appskeyTextBox.Texts = "";
            this.appskeyTextBox.UnderlinedStyle = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.deviceAddressTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 24);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(587, 58);
            this.panel4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "DEVICE ADDRESS";
            // 
            // deviceAddressTextBox
            // 
            this.deviceAddressTextBox.AutoSize = true;
            this.deviceAddressTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deviceAddressTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deviceAddressTextBox.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.deviceAddressTextBox.BorderSize = 2;
            this.deviceAddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceAddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.deviceAddressTextBox.Location = new System.Drawing.Point(10, 10);
            this.deviceAddressTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.deviceAddressTextBox.MaxLength = 8;
            this.deviceAddressTextBox.Multiline = false;
            this.deviceAddressTextBox.Name = "deviceAddressTextBox";
            this.deviceAddressTextBox.Padding = new System.Windows.Forms.Padding(12, 10, 3, 3);
            this.deviceAddressTextBox.Size = new System.Drawing.Size(567, 29);
            this.deviceAddressTextBox.TabIndex = 6;
            this.deviceAddressTextBox.Texts = "";
            this.deviceAddressTextBox.UnderlinedStyle = false;
            // 
            // configuracoesConexaoGroup
            // 
            this.configuracoesConexaoGroup.AutoSize = true;
            this.configuracoesConexaoGroup.Controls.Add(this.panel7);
            this.configuracoesConexaoGroup.Controls.Add(this.modoDeConfirmacaoGroup);
            this.configuracoesConexaoGroup.Controls.Add(this.panel10);
            this.configuracoesConexaoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.configuracoesConexaoGroup.Enabled = false;
            this.configuracoesConexaoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracoesConexaoGroup.ForeColor = System.Drawing.Color.Gray;
            this.configuracoesConexaoGroup.Location = new System.Drawing.Point(10, 442);
            this.configuracoesConexaoGroup.Name = "configuracoesConexaoGroup";
            this.configuracoesConexaoGroup.Padding = new System.Windows.Forms.Padding(10);
            this.configuracoesConexaoGroup.Size = new System.Drawing.Size(607, 247);
            this.configuracoesConexaoGroup.TabIndex = 4;
            this.configuracoesConexaoGroup.TabStop = false;
            this.configuracoesConexaoGroup.Text = "Configurações de Conexão";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.conectarLoraButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 181);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(587, 56);
            this.panel7.TabIndex = 12;
            // 
            // conectarLoraButton
            // 
            this.conectarLoraButton.BackColor = System.Drawing.Color.Gainsboro;
            this.conectarLoraButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conectarLoraButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conectarLoraButton.FlatAppearance.BorderSize = 0;
            this.conectarLoraButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.conectarLoraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.conectarLoraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conectarLoraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectarLoraButton.ForeColor = System.Drawing.Color.White;
            this.conectarLoraButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.conectarLoraButton.IconColor = System.Drawing.Color.Black;
            this.conectarLoraButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.conectarLoraButton.Location = new System.Drawing.Point(10, 10);
            this.conectarLoraButton.Name = "conectarLoraButton";
            this.conectarLoraButton.Size = new System.Drawing.Size(567, 36);
            this.conectarLoraButton.TabIndex = 13;
            this.conectarLoraButton.Text = "Conectar";
            this.conectarLoraButton.UseVisualStyleBackColor = false;
            this.conectarLoraButton.Click += new System.EventHandler(this.conectarLoraButton_Click);
            // 
            // modoDeConfirmacaoGroup
            // 
            this.modoDeConfirmacaoGroup.Controls.Add(this.modoConfirmacaoToggle);
            this.modoDeConfirmacaoGroup.Controls.Add(this.label8);
            this.modoDeConfirmacaoGroup.Controls.Add(this.panel16);
            this.modoDeConfirmacaoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.modoDeConfirmacaoGroup.Location = new System.Drawing.Point(10, 82);
            this.modoDeConfirmacaoGroup.Name = "modoDeConfirmacaoGroup";
            this.modoDeConfirmacaoGroup.Padding = new System.Windows.Forms.Padding(10);
            this.modoDeConfirmacaoGroup.Size = new System.Drawing.Size(587, 99);
            this.modoDeConfirmacaoGroup.TabIndex = 8;
            // 
            // modoConfirmacaoToggle
            // 
            this.modoConfirmacaoToggle.AutoSize = true;
            this.modoConfirmacaoToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modoConfirmacaoToggle.Location = new System.Drawing.Point(198, 2);
            this.modoConfirmacaoToggle.MinimumSize = new System.Drawing.Size(42, 18);
            this.modoConfirmacaoToggle.Name = "modoConfirmacaoToggle";
            this.modoConfirmacaoToggle.OffBackColor = System.Drawing.Color.Gray;
            this.modoConfirmacaoToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.modoConfirmacaoToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.modoConfirmacaoToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.modoConfirmacaoToggle.Size = new System.Drawing.Size(42, 18);
            this.modoConfirmacaoToggle.TabIndex = 12;
            this.modoConfirmacaoToggle.UseVisualStyleBackColor = true;
            this.modoConfirmacaoToggle.CheckedChanged += new System.EventHandler(this.cToggle1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "MODO DE CONFIRMAÇÂO";
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.label9);
            this.panel16.Controls.Add(this.numeroRetentativasComboBox);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(10, 10);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.panel16.Size = new System.Drawing.Size(567, 79);
            this.panel16.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Número de Retentativas";
            // 
            // numeroRetentativasComboBox
            // 
            this.numeroRetentativasComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numeroRetentativasComboBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.numeroRetentativasComboBox.BorderSize = 2;
            this.numeroRetentativasComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numeroRetentativasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.numeroRetentativasComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.numeroRetentativasComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numeroRetentativasComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.numeroRetentativasComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.numeroRetentativasComboBox.Location = new System.Drawing.Point(10, 25);
            this.numeroRetentativasComboBox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.numeroRetentativasComboBox.MinimumSize = new System.Drawing.Size(317, 46);
            this.numeroRetentativasComboBox.Name = "numeroRetentativasComboBox";
            this.numeroRetentativasComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.numeroRetentativasComboBox.Size = new System.Drawing.Size(545, 46);
            this.numeroRetentativasComboBox.TabIndex = 4;
            this.numeroRetentativasComboBox.Texts = "";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.classeComboBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 24);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10);
            this.panel10.Size = new System.Drawing.Size(587, 58);
            this.panel10.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "CLASSE";
            // 
            // classeComboBox
            // 
            this.classeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classeComboBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.classeComboBox.BorderSize = 2;
            this.classeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.classeComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.classeComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.classeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.classeComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.classeComboBox.Location = new System.Drawing.Point(10, 10);
            this.classeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.classeComboBox.MinimumSize = new System.Drawing.Size(233, 35);
            this.classeComboBox.Name = "classeComboBox";
            this.classeComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.classeComboBox.Size = new System.Drawing.Size(567, 38);
            this.classeComboBox.TabIndex = 3;
            this.classeComboBox.Texts = "";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 689);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(607, 36);
            this.panel8.TabIndex = 5;
            // 
            // comandosATGroup
            // 
            this.comandosATGroup.AutoSize = true;
            this.comandosATGroup.Controls.Add(this.panel9);
            this.comandosATGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.comandosATGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comandosATGroup.ForeColor = System.Drawing.Color.Gray;
            this.comandosATGroup.Location = new System.Drawing.Point(10, 725);
            this.comandosATGroup.Name = "comandosATGroup";
            this.comandosATGroup.Padding = new System.Windows.Forms.Padding(10);
            this.comandosATGroup.Size = new System.Drawing.Size(607, 255);
            this.comandosATGroup.TabIndex = 6;
            this.comandosATGroup.TabStop = false;
            this.comandosATGroup.Text = "Comandos AT";
            this.comandosATGroup.Visible = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(10, 24);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(587, 221);
            this.panel9.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "AT+SEND";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(10, 10);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel11.Size = new System.Drawing.Size(567, 202);
            this.panel11.TabIndex = 9;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.atSendButton);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(10, 142);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panel14.Size = new System.Drawing.Size(545, 51);
            this.panel14.TabIndex = 17;
            // 
            // atSendButton
            // 
            this.atSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.atSendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atSendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atSendButton.FlatAppearance.BorderSize = 0;
            this.atSendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.atSendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.atSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atSendButton.ForeColor = System.Drawing.Color.White;
            this.atSendButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.atSendButton.IconColor = System.Drawing.Color.Black;
            this.atSendButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.atSendButton.Location = new System.Drawing.Point(0, 10);
            this.atSendButton.Name = "atSendButton";
            this.atSendButton.Size = new System.Drawing.Size(545, 36);
            this.atSendButton.TabIndex = 14;
            this.atSendButton.Text = "Enviar";
            this.atSendButton.UseVisualStyleBackColor = false;
            this.atSendButton.Click += new System.EventHandler(this.atSendButton_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.atSendPortaComboBox);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(10, 78);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panel13.Size = new System.Drawing.Size(545, 64);
            this.panel13.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Porta";
            // 
            // atSendPortaComboBox
            // 
            this.atSendPortaComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.atSendPortaComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.atSendPortaComboBox.BorderSize = 1;
            this.atSendPortaComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atSendPortaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.atSendPortaComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.atSendPortaComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.atSendPortaComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.atSendPortaComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.atSendPortaComboBox.Location = new System.Drawing.Point(0, 10);
            this.atSendPortaComboBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.atSendPortaComboBox.MinimumSize = new System.Drawing.Size(272, 40);
            this.atSendPortaComboBox.Name = "atSendPortaComboBox";
            this.atSendPortaComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.atSendPortaComboBox.Size = new System.Drawing.Size(545, 49);
            this.atSendPortaComboBox.TabIndex = 9;
            this.atSendPortaComboBox.Texts = "";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.atSendTextoTextBox);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(10, 20);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panel12.Size = new System.Drawing.Size(545, 58);
            this.panel12.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Texto";
            // 
            // atSendTextoTextBox
            // 
            this.atSendTextoTextBox.AutoSize = true;
            this.atSendTextoTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.atSendTextoTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.atSendTextoTextBox.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.atSendTextoTextBox.BorderSize = 1;
            this.atSendTextoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atSendTextoTextBox.ForeColor = System.Drawing.Color.Black;
            this.atSendTextoTextBox.Location = new System.Drawing.Point(0, 10);
            this.atSendTextoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.atSendTextoTextBox.MaxLength = 32767;
            this.atSendTextoTextBox.Multiline = false;
            this.atSendTextoTextBox.Name = "atSendTextoTextBox";
            this.atSendTextoTextBox.Padding = new System.Windows.Forms.Padding(12, 13, 3, 3);
            this.atSendTextoTextBox.Size = new System.Drawing.Size(545, 32);
            this.atSendTextoTextBox.TabIndex = 7;
            this.atSendTextoTextBox.Texts = "";
            this.atSendTextoTextBox.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(221, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Configurações Modo ABP";
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(10, 32);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(607, 36);
            this.panel15.TabIndex = 8;
            // 
            // FormModoAbp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(644, 558);
            this.ControlBox = false;
            this.Controls.Add(this.comandosATGroup);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.configuracoesConexaoGroup);
            this.Controls.Add(this.chavesDeAtivacaoGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.label11);
            this.Name = "FormModoAbp";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.chavesDeAtivacaoGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.configuracoesConexaoGroup.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.modoDeConfirmacaoGroup.ResumeLayout(false);
            this.modoDeConfirmacaoGroup.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.comandosATGroup.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox chavesDeAtivacaoGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.CTextBox deviceEuiTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private CustomControls.CTextBox nwkskeyTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private CustomControls.CTextBox appskeyTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private CustomControls.CTextBox deviceAddressTextBox;
        private System.Windows.Forms.GroupBox configuracoesConexaoGroup;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private CustomControls.CComboBox classeComboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private CustomControls.CComboBox comboBoxCOM;
        private FontAwesome.Sharp.IconButton conectarCOMButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox comandosATGroup;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label7;
        private CustomControls.CComboBox atSendPortaComboBox;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private CustomControls.CTextBox atSendTextoTextBox;
        private System.Windows.Forms.Panel panel14;
        private FontAwesome.Sharp.IconButton atSendButton;
        private System.Windows.Forms.Panel modoDeConfirmacaoGroup;
        private CustomControls.CToggle modoConfirmacaoToggle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label9;
        private CustomControls.CComboBox numeroRetentativasComboBox;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton conectarLoraButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel15;
    }
}