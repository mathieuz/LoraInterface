namespace LoraInterface.Forms
{
    partial class FormModoOtaa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxCOM = new LoraInterface.CustomControls.CComboBox();
            this.conectarCOMButton = new FontAwesome.Sharp.IconButton();
            this.configuracoesConexaoGroup = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.conectarLoraButton = new FontAwesome.Sharp.IconButton();
            this.configuracoesDeJoinGroup = new System.Windows.Forms.Panel();
            this.configuracoesJoinToggle = new LoraInterface.CustomControls.CToggle();
            this.label7 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.intervaloTentativasJoinComboBox = new LoraInterface.CustomControls.CComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.numeroTentativasJoinComboBox = new LoraInterface.CustomControls.CComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.autoJoinComboBox = new LoraInterface.CustomControls.CComboBox();
            this.modoDeConfirmacaoGroup = new System.Windows.Forms.Panel();
            this.modoConfirmacaoToggle = new LoraInterface.CustomControls.CToggle();
            this.label8 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.numeroRetentativasComboBox = new LoraInterface.CustomControls.CComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.classeComboBox = new LoraInterface.CustomControls.CComboBox();
            this.chavesDeAtivacaoGroup = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.deviceEuiTextBox = new LoraInterface.CustomControls.CTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.appKeyTextBox = new LoraInterface.CustomControls.CTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comandosATGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.atSendButton = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.atSendPortaComboBox = new LoraInterface.CustomControls.CComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.atSendTextoTextBox = new LoraInterface.CustomControls.CTextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.configuracoesConexaoGroup.SuspendLayout();
            this.panel7.SuspendLayout();
            this.configuracoesDeJoinGroup.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel13.SuspendLayout();
            this.modoDeConfirmacaoGroup.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel1.SuspendLayout();
            this.chavesDeAtivacaoGroup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.comandosATGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(608, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conectar COM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.conectarCOMButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 24);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(588, 74);
            this.panel2.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBoxCOM);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel6.Size = new System.Drawing.Size(405, 54);
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
            this.comboBoxCOM.Size = new System.Drawing.Size(400, 53);
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
            this.conectarCOMButton.Location = new System.Drawing.Point(415, 10);
            this.conectarCOMButton.Name = "conectarCOMButton";
            this.conectarCOMButton.Size = new System.Drawing.Size(163, 54);
            this.conectarCOMButton.TabIndex = 12;
            this.conectarCOMButton.Text = "Conectar COM";
            this.conectarCOMButton.UseVisualStyleBackColor = false;
            this.conectarCOMButton.Click += new System.EventHandler(this.conectarCOMButton_Click);
            // 
            // configuracoesConexaoGroup
            // 
            this.configuracoesConexaoGroup.AutoSize = true;
            this.configuracoesConexaoGroup.Controls.Add(this.panel7);
            this.configuracoesConexaoGroup.Controls.Add(this.configuracoesDeJoinGroup);
            this.configuracoesConexaoGroup.Controls.Add(this.modoDeConfirmacaoGroup);
            this.configuracoesConexaoGroup.Controls.Add(this.panel1);
            this.configuracoesConexaoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.configuracoesConexaoGroup.Enabled = false;
            this.configuracoesConexaoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracoesConexaoGroup.ForeColor = System.Drawing.Color.Gray;
            this.configuracoesConexaoGroup.Location = new System.Drawing.Point(10, 268);
            this.configuracoesConexaoGroup.Name = "configuracoesConexaoGroup";
            this.configuracoesConexaoGroup.Padding = new System.Windows.Forms.Padding(10);
            this.configuracoesConexaoGroup.Size = new System.Drawing.Size(608, 518);
            this.configuracoesConexaoGroup.TabIndex = 5;
            this.configuracoesConexaoGroup.TabStop = false;
            this.configuracoesConexaoGroup.Text = "Configurações de Conexão";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.conectarLoraButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 452);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(588, 56);
            this.panel7.TabIndex = 13;
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
            this.conectarLoraButton.Size = new System.Drawing.Size(568, 36);
            this.conectarLoraButton.TabIndex = 13;
            this.conectarLoraButton.Text = "Conectar";
            this.conectarLoraButton.UseVisualStyleBackColor = false;
            this.conectarLoraButton.EnabledChanged += new System.EventHandler(this.conectarLoraButton_EnabledChanged);
            this.conectarLoraButton.Click += new System.EventHandler(this.conectarLoraButton_Click);
            // 
            // configuracoesDeJoinGroup
            // 
            this.configuracoesDeJoinGroup.Controls.Add(this.configuracoesJoinToggle);
            this.configuracoesDeJoinGroup.Controls.Add(this.label7);
            this.configuracoesDeJoinGroup.Controls.Add(this.panel12);
            this.configuracoesDeJoinGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.configuracoesDeJoinGroup.Location = new System.Drawing.Point(10, 181);
            this.configuracoesDeJoinGroup.Name = "configuracoesDeJoinGroup";
            this.configuracoesDeJoinGroup.Padding = new System.Windows.Forms.Padding(10);
            this.configuracoesDeJoinGroup.Size = new System.Drawing.Size(588, 271);
            this.configuracoesDeJoinGroup.TabIndex = 14;
            // 
            // configuracoesJoinToggle
            // 
            this.configuracoesJoinToggle.AutoSize = true;
            this.configuracoesJoinToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configuracoesJoinToggle.Location = new System.Drawing.Point(205, 2);
            this.configuracoesJoinToggle.MinimumSize = new System.Drawing.Size(42, 18);
            this.configuracoesJoinToggle.Name = "configuracoesJoinToggle";
            this.configuracoesJoinToggle.OffBackColor = System.Drawing.Color.Gray;
            this.configuracoesJoinToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.configuracoesJoinToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.configuracoesJoinToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.configuracoesJoinToggle.Size = new System.Drawing.Size(42, 18);
            this.configuracoesJoinToggle.TabIndex = 12;
            this.configuracoesJoinToggle.UseVisualStyleBackColor = true;
            this.configuracoesJoinToggle.CheckedChanged += new System.EventHandler(this.configuracoesJoinToggle_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "CONFIGURAÇÕES DE JOIN";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(10, 10);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 25, 10, 5);
            this.panel12.Size = new System.Drawing.Size(568, 251);
            this.panel12.TabIndex = 13;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label11);
            this.panel15.Controls.Add(this.intervaloTentativasJoinComboBox);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(10, 168);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel15.Size = new System.Drawing.Size(546, 73);
            this.panel15.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Intervalo de Tentativas (em segundos)";
            // 
            // intervaloTentativasJoinComboBox
            // 
            this.intervaloTentativasJoinComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.intervaloTentativasJoinComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intervaloTentativasJoinComboBox.BorderSize = 2;
            this.intervaloTentativasJoinComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.intervaloTentativasJoinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.intervaloTentativasJoinComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.intervaloTentativasJoinComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.intervaloTentativasJoinComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.intervaloTentativasJoinComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.intervaloTentativasJoinComboBox.Location = new System.Drawing.Point(0, 10);
            this.intervaloTentativasJoinComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.intervaloTentativasJoinComboBox.MinimumSize = new System.Drawing.Size(432, 61);
            this.intervaloTentativasJoinComboBox.Name = "intervaloTentativasJoinComboBox";
            this.intervaloTentativasJoinComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.intervaloTentativasJoinComboBox.Size = new System.Drawing.Size(546, 61);
            this.intervaloTentativasJoinComboBox.TabIndex = 13;
            this.intervaloTentativasJoinComboBox.Texts = "";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label12);
            this.panel17.Controls.Add(this.numeroTentativasJoinComboBox);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(10, 96);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel17.Size = new System.Drawing.Size(546, 72);
            this.panel17.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Número de Tentativas";
            // 
            // numeroTentativasJoinComboBox
            // 
            this.numeroTentativasJoinComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numeroTentativasJoinComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numeroTentativasJoinComboBox.BorderSize = 2;
            this.numeroTentativasJoinComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numeroTentativasJoinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.numeroTentativasJoinComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.numeroTentativasJoinComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numeroTentativasJoinComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.numeroTentativasJoinComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.numeroTentativasJoinComboBox.Location = new System.Drawing.Point(0, 10);
            this.numeroTentativasJoinComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.numeroTentativasJoinComboBox.MinimumSize = new System.Drawing.Size(432, 61);
            this.numeroTentativasJoinComboBox.Name = "numeroTentativasJoinComboBox";
            this.numeroTentativasJoinComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.numeroTentativasJoinComboBox.Size = new System.Drawing.Size(546, 61);
            this.numeroTentativasJoinComboBox.TabIndex = 13;
            this.numeroTentativasJoinComboBox.Texts = "";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.autoJoinComboBox);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(10, 25);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel13.Size = new System.Drawing.Size(546, 71);
            this.panel13.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Auto-Join";
            // 
            // autoJoinComboBox
            // 
            this.autoJoinComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.autoJoinComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoJoinComboBox.BorderSize = 2;
            this.autoJoinComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoJoinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.autoJoinComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.autoJoinComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoJoinComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.autoJoinComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.autoJoinComboBox.Location = new System.Drawing.Point(0, 10);
            this.autoJoinComboBox.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.autoJoinComboBox.MinimumSize = new System.Drawing.Size(432, 61);
            this.autoJoinComboBox.Name = "autoJoinComboBox";
            this.autoJoinComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.autoJoinComboBox.Size = new System.Drawing.Size(546, 61);
            this.autoJoinComboBox.TabIndex = 13;
            this.autoJoinComboBox.Texts = "";
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
            this.modoDeConfirmacaoGroup.Size = new System.Drawing.Size(588, 99);
            this.modoDeConfirmacaoGroup.TabIndex = 9;
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
            this.modoConfirmacaoToggle.CheckedChanged += new System.EventHandler(this.modoConfirmacaoToggle_CheckedChanged);
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
            this.panel16.Size = new System.Drawing.Size(568, 79);
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
            this.label9.Size = new System.Drawing.Size(147, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Número de Tentativas";
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
            this.numeroRetentativasComboBox.Size = new System.Drawing.Size(546, 46);
            this.numeroRetentativasComboBox.TabIndex = 4;
            this.numeroRetentativasComboBox.Texts = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.classeComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(588, 58);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "CLASSE";
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
            this.classeComboBox.Size = new System.Drawing.Size(568, 38);
            this.classeComboBox.TabIndex = 3;
            this.classeComboBox.Texts = "";
            // 
            // chavesDeAtivacaoGroup
            // 
            this.chavesDeAtivacaoGroup.AutoSize = true;
            this.chavesDeAtivacaoGroup.Controls.Add(this.panel3);
            this.chavesDeAtivacaoGroup.Controls.Add(this.panel5);
            this.chavesDeAtivacaoGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.chavesDeAtivacaoGroup.Enabled = false;
            this.chavesDeAtivacaoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chavesDeAtivacaoGroup.ForeColor = System.Drawing.Color.Gray;
            this.chavesDeAtivacaoGroup.Location = new System.Drawing.Point(10, 118);
            this.chavesDeAtivacaoGroup.Name = "chavesDeAtivacaoGroup";
            this.chavesDeAtivacaoGroup.Padding = new System.Windows.Forms.Padding(10);
            this.chavesDeAtivacaoGroup.Size = new System.Drawing.Size(608, 150);
            this.chavesDeAtivacaoGroup.TabIndex = 4;
            this.chavesDeAtivacaoGroup.TabStop = false;
            this.chavesDeAtivacaoGroup.Text = "Chaves de Ativação";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.deviceEuiTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 82);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(588, 58);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DEVICE EUI";
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
            this.deviceEuiTextBox.Multiline = true;
            this.deviceEuiTextBox.Name = "deviceEuiTextBox";
            this.deviceEuiTextBox.Padding = new System.Windows.Forms.Padding(12, 10, 3, 3);
            this.deviceEuiTextBox.Size = new System.Drawing.Size(568, 38);
            this.deviceEuiTextBox.TabIndex = 7;
            this.deviceEuiTextBox.Texts = "";
            this.deviceEuiTextBox.UnderlinedStyle = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.appKeyTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 24);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(588, 58);
            this.panel5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "APPKEY";
            // 
            // appKeyTextBox
            // 
            this.appKeyTextBox.AutoSize = true;
            this.appKeyTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.appKeyTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appKeyTextBox.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.appKeyTextBox.BorderSize = 2;
            this.appKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appKeyTextBox.ForeColor = System.Drawing.Color.Black;
            this.appKeyTextBox.Location = new System.Drawing.Point(10, 10);
            this.appKeyTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.appKeyTextBox.MaxLength = 32;
            this.appKeyTextBox.Multiline = true;
            this.appKeyTextBox.Name = "appKeyTextBox";
            this.appKeyTextBox.Padding = new System.Windows.Forms.Padding(12, 10, 3, 3);
            this.appKeyTextBox.Size = new System.Drawing.Size(568, 38);
            this.appKeyTextBox.TabIndex = 7;
            this.appKeyTextBox.Texts = "";
            this.appKeyTextBox.UnderlinedStyle = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 786);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 36);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // comandosATGroup
            // 
            this.comandosATGroup.Controls.Add(this.label5);
            this.comandosATGroup.Controls.Add(this.panel4);
            this.comandosATGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.comandosATGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comandosATGroup.ForeColor = System.Drawing.Color.Gray;
            this.comandosATGroup.Location = new System.Drawing.Point(10, 822);
            this.comandosATGroup.Name = "comandosATGroup";
            this.comandosATGroup.Padding = new System.Windows.Forms.Padding(10);
            this.comandosATGroup.Size = new System.Drawing.Size(608, 253);
            this.comandosATGroup.TabIndex = 7;
            this.comandosATGroup.TabStop = false;
            this.comandosATGroup.Text = "Comandos AT";
            this.comandosATGroup.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AT+SEND";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 24);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(588, 217);
            this.panel4.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 10);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel8.Size = new System.Drawing.Size(568, 196);
            this.panel8.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.atSendButton);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(10, 135);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panel14.Size = new System.Drawing.Size(546, 51);
            this.panel14.TabIndex = 18;
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
            this.atSendButton.Size = new System.Drawing.Size(546, 36);
            this.atSendButton.TabIndex = 14;
            this.atSendButton.Text = "Enviar";
            this.atSendButton.UseVisualStyleBackColor = false;
            this.atSendButton.Click += new System.EventHandler(this.atSendButton_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.atSendPortaComboBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 78);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panel10.Size = new System.Drawing.Size(546, 57);
            this.panel10.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Porta";
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
            this.atSendPortaComboBox.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.atSendPortaComboBox.MinimumSize = new System.Drawing.Size(317, 46);
            this.atSendPortaComboBox.Name = "atSendPortaComboBox";
            this.atSendPortaComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.atSendPortaComboBox.Size = new System.Drawing.Size(546, 46);
            this.atSendPortaComboBox.TabIndex = 10;
            this.atSendPortaComboBox.Texts = "";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.atSendTextoTextBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(10, 20);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panel9.Size = new System.Drawing.Size(546, 58);
            this.panel9.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Texto";
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
            this.atSendTextoTextBox.Size = new System.Drawing.Size(546, 32);
            this.atSendTextoTextBox.TabIndex = 8;
            this.atSendTextoTextBox.Texts = "";
            this.atSendTextoTextBox.UnderlinedStyle = false;
            // 
            // FormModoOtaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(645, 557);
            this.ControlBox = false;
            this.Controls.Add(this.comandosATGroup);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.configuracoesConexaoGroup);
            this.Controls.Add(this.chavesDeAtivacaoGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormModoOtaa";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.configuracoesConexaoGroup.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.configuracoesDeJoinGroup.ResumeLayout(false);
            this.configuracoesDeJoinGroup.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.modoDeConfirmacaoGroup.ResumeLayout(false);
            this.modoDeConfirmacaoGroup.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.chavesDeAtivacaoGroup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.comandosATGroup.ResumeLayout(false);
            this.comandosATGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox configuracoesConexaoGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private CustomControls.CComboBox classeComboBox;
        private System.Windows.Forms.GroupBox chavesDeAtivacaoGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private CustomControls.CTextBox deviceEuiTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private CustomControls.CTextBox appKeyTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private CustomControls.CComboBox comboBoxCOM;
        private FontAwesome.Sharp.IconButton conectarCOMButton;
        private System.Windows.Forms.Panel modoDeConfirmacaoGroup;
        private CustomControls.CToggle modoConfirmacaoToggle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label9;
        private CustomControls.CComboBox numeroRetentativasComboBox;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton conectarLoraButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private CustomControls.CTextBox atSendTextoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private CustomControls.CComboBox atSendPortaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel14;
        private FontAwesome.Sharp.IconButton atSendButton;
        private System.Windows.Forms.Panel configuracoesDeJoinGroup;
        private CustomControls.CToggle configuracoesJoinToggle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label11;
        private CustomControls.CComboBox intervaloTentativasJoinComboBox;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label12;
        private CustomControls.CComboBox numeroTentativasJoinComboBox;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label10;
        private CustomControls.CComboBox autoJoinComboBox;
        public System.Windows.Forms.GroupBox comandosATGroup;
    }
}