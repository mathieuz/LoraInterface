namespace LoraInterface
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.salvarButton = new FontAwesome.Sharp.IconButton();
            this.abrirButton = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.modoAbpButton = new FontAwesome.Sharp.IconButton();
            this.modoOtaaButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.consoleButton = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.enviarConsole = new FontAwesome.Sharp.IconButton();
            this.consolePanel = new System.Windows.Forms.RichTextBox();
            this.fecharJanelaButton = new FontAwesome.Sharp.IconButton();
            this.maximizarJanelaButton = new FontAwesome.Sharp.IconButton();
            this.minimizarJanelaButton = new FontAwesome.Sharp.IconButton();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consoleCmdTextBox = new LoraInterface.CustomControls.CTextBox();
            this.sideBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.desktopPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.sideBarPanel.Controls.Add(this.panel1);
            this.sideBarPanel.Controls.Add(this.salvarButton);
            this.sideBarPanel.Controls.Add(this.abrirButton);
            this.sideBarPanel.Controls.Add(this.panel4);
            this.sideBarPanel.Controls.Add(this.modoAbpButton);
            this.sideBarPanel.Controls.Add(this.modoOtaaButton);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 39);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(180, 612);
            this.sideBarPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 38);
            this.panel1.TabIndex = 3;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.menuButton.IconColor = System.Drawing.Color.White;
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.IconSize = 30;
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Margin = new System.Windows.Forms.Padding(0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(34, 29);
            this.menuButton.TabIndex = 2;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salvarButton.FlatAppearance.BorderSize = 0;
            this.salvarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.salvarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.salvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarButton.ForeColor = System.Drawing.Color.White;
            this.salvarButton.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.salvarButton.IconColor = System.Drawing.Color.White;
            this.salvarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salvarButton.IconSize = 25;
            this.salvarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvarButton.Location = new System.Drawing.Point(0, 44);
            this.salvarButton.Margin = new System.Windows.Forms.Padding(0);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.salvarButton.Size = new System.Drawing.Size(180, 36);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Tag = "Salvar";
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // abrirButton
            // 
            this.abrirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abrirButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.abrirButton.FlatAppearance.BorderSize = 0;
            this.abrirButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.abrirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.abrirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirButton.ForeColor = System.Drawing.Color.White;
            this.abrirButton.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.abrirButton.IconColor = System.Drawing.Color.White;
            this.abrirButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.abrirButton.IconSize = 25;
            this.abrirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrirButton.Location = new System.Drawing.Point(0, 80);
            this.abrirButton.Margin = new System.Windows.Forms.Padding(0);
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.abrirButton.Size = new System.Drawing.Size(180, 36);
            this.abrirButton.TabIndex = 7;
            this.abrirButton.Tag = "Abrir";
            this.abrirButton.Text = "Abrir";
            this.abrirButton.UseVisualStyleBackColor = true;
            this.abrirButton.Click += new System.EventHandler(this.abrirButton_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 38);
            this.panel4.TabIndex = 6;
            // 
            // modoAbpButton
            // 
            this.modoAbpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modoAbpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.modoAbpButton.FlatAppearance.BorderSize = 0;
            this.modoAbpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.modoAbpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.modoAbpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modoAbpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoAbpButton.ForeColor = System.Drawing.Color.White;
            this.modoAbpButton.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.modoAbpButton.IconColor = System.Drawing.Color.White;
            this.modoAbpButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.modoAbpButton.IconSize = 25;
            this.modoAbpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modoAbpButton.Location = new System.Drawing.Point(0, 160);
            this.modoAbpButton.Margin = new System.Windows.Forms.Padding(0);
            this.modoAbpButton.Name = "modoAbpButton";
            this.modoAbpButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.modoAbpButton.Size = new System.Drawing.Size(180, 36);
            this.modoAbpButton.TabIndex = 2;
            this.modoAbpButton.Tag = "Modo ABP";
            this.modoAbpButton.Text = "Modo ABP";
            this.modoAbpButton.UseVisualStyleBackColor = true;
            this.modoAbpButton.Click += new System.EventHandler(this.modoAbpButton_Click);
            // 
            // modoOtaaButton
            // 
            this.modoOtaaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modoOtaaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.modoOtaaButton.FlatAppearance.BorderSize = 0;
            this.modoOtaaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.modoOtaaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.modoOtaaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modoOtaaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modoOtaaButton.ForeColor = System.Drawing.Color.White;
            this.modoOtaaButton.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.modoOtaaButton.IconColor = System.Drawing.Color.White;
            this.modoOtaaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.modoOtaaButton.IconSize = 25;
            this.modoOtaaButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.modoOtaaButton.Location = new System.Drawing.Point(0, 196);
            this.modoOtaaButton.Margin = new System.Windows.Forms.Padding(0);
            this.modoOtaaButton.Name = "modoOtaaButton";
            this.modoOtaaButton.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.modoOtaaButton.Size = new System.Drawing.Size(180, 36);
            this.modoOtaaButton.TabIndex = 4;
            this.modoOtaaButton.Tag = "Modo OTAA";
            this.modoOtaaButton.Text = "Modo OTAA";
            this.modoOtaaButton.UseVisualStyleBackColor = true;
            this.modoOtaaButton.Click += new System.EventHandler(this.modoOtaaButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.desktopPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 612);
            this.panel2.TabIndex = 2;
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.desktopPanel.Controls.Add(this.panel3);
            this.desktopPanel.Controls.Add(this.panel5);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(0, 0);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(868, 612);
            this.desktopPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.consoleButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 31);
            this.panel3.TabIndex = 2;
            // 
            // consoleButton
            // 
            this.consoleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.consoleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consoleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.consoleButton.FlatAppearance.BorderSize = 0;
            this.consoleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.consoleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.consoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleButton.ForeColor = System.Drawing.Color.White;
            this.consoleButton.IconChar = FontAwesome.Sharp.IconChar.Terminal;
            this.consoleButton.IconColor = System.Drawing.Color.White;
            this.consoleButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.consoleButton.IconSize = 20;
            this.consoleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consoleButton.Location = new System.Drawing.Point(0, 0);
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.Size = new System.Drawing.Size(83, 31);
            this.consoleButton.TabIndex = 1;
            this.consoleButton.Text = "Console";
            this.consoleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consoleButton.UseVisualStyleBackColor = false;
            this.consoleButton.Click += new System.EventHandler(this.consoleButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel5.Controls.Add(this.enviarConsole);
            this.panel5.Controls.Add(this.consoleCmdTextBox);
            this.panel5.Controls.Add(this.consolePanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 362);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(868, 250);
            this.panel5.TabIndex = 0;
            // 
            // enviarConsole
            // 
            this.enviarConsole.Dock = System.Windows.Forms.DockStyle.Right;
            this.enviarConsole.IconChar = FontAwesome.Sharp.IconChar.None;
            this.enviarConsole.IconColor = System.Drawing.Color.Black;
            this.enviarConsole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.enviarConsole.Location = new System.Drawing.Point(792, 5);
            this.enviarConsole.Name = "enviarConsole";
            this.enviarConsole.Size = new System.Drawing.Size(71, 28);
            this.enviarConsole.TabIndex = 2;
            this.enviarConsole.Text = "Enviar";
            this.enviarConsole.UseVisualStyleBackColor = true;
            this.enviarConsole.Click += new System.EventHandler(this.enviarConsole_Click);
            // 
            // consolePanel
            // 
            this.consolePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.consolePanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consolePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consolePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consolePanel.ForeColor = System.Drawing.Color.PowderBlue;
            this.consolePanel.Location = new System.Drawing.Point(5, 33);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.ReadOnly = true;
            this.consolePanel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consolePanel.Size = new System.Drawing.Size(858, 212);
            this.consolePanel.TabIndex = 0;
            this.consolePanel.Text = "";
            // 
            // fecharJanelaButton
            // 
            this.fecharJanelaButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.fecharJanelaButton.FlatAppearance.BorderSize = 0;
            this.fecharJanelaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.fecharJanelaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.fecharJanelaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecharJanelaButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.fecharJanelaButton.IconColor = System.Drawing.Color.White;
            this.fecharJanelaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.fecharJanelaButton.IconSize = 15;
            this.fecharJanelaButton.Location = new System.Drawing.Point(1003, 0);
            this.fecharJanelaButton.Name = "fecharJanelaButton";
            this.fecharJanelaButton.Size = new System.Drawing.Size(45, 39);
            this.fecharJanelaButton.TabIndex = 2;
            this.fecharJanelaButton.UseVisualStyleBackColor = true;
            this.fecharJanelaButton.Click += new System.EventHandler(this.fecharJanelaButton_Click);
            // 
            // maximizarJanelaButton
            // 
            this.maximizarJanelaButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizarJanelaButton.FlatAppearance.BorderSize = 0;
            this.maximizarJanelaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.maximizarJanelaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.maximizarJanelaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizarJanelaButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.maximizarJanelaButton.IconColor = System.Drawing.Color.White;
            this.maximizarJanelaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.maximizarJanelaButton.IconSize = 15;
            this.maximizarJanelaButton.Location = new System.Drawing.Point(958, 0);
            this.maximizarJanelaButton.Name = "maximizarJanelaButton";
            this.maximizarJanelaButton.Size = new System.Drawing.Size(45, 39);
            this.maximizarJanelaButton.TabIndex = 3;
            this.maximizarJanelaButton.UseVisualStyleBackColor = true;
            this.maximizarJanelaButton.Click += new System.EventHandler(this.maximizarJanelaButton_Click);
            // 
            // minimizarJanelaButton
            // 
            this.minimizarJanelaButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizarJanelaButton.FlatAppearance.BorderSize = 0;
            this.minimizarJanelaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minimizarJanelaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.minimizarJanelaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizarJanelaButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizarJanelaButton.IconColor = System.Drawing.Color.White;
            this.minimizarJanelaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.minimizarJanelaButton.IconSize = 20;
            this.minimizarJanelaButton.Location = new System.Drawing.Point(913, 0);
            this.minimizarJanelaButton.Name = "minimizarJanelaButton";
            this.minimizarJanelaButton.Size = new System.Drawing.Size(45, 39);
            this.minimizarJanelaButton.TabIndex = 4;
            this.minimizarJanelaButton.UseVisualStyleBackColor = true;
            this.minimizarJanelaButton.Click += new System.EventHandler(this.minimizarJanelaButton_Click);
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.topBarPanel.Controls.Add(this.pictureBox1);
            this.topBarPanel.Controls.Add(this.minimizarJanelaButton);
            this.topBarPanel.Controls.Add(this.maximizarJanelaButton);
            this.topBarPanel.Controls.Add(this.fecharJanelaButton);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.topBarPanel.Size = new System.Drawing.Size(1048, 39);
            this.topBarPanel.TabIndex = 0;
            this.topBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarPanel_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 39);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // consoleCmdTextBox
            // 
            this.consoleCmdTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.consoleCmdTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.consoleCmdTextBox.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.consoleCmdTextBox.BorderSize = 2;
            this.consoleCmdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleCmdTextBox.ForeColor = System.Drawing.Color.White;
            this.consoleCmdTextBox.Location = new System.Drawing.Point(5, 5);
            this.consoleCmdTextBox.MaxLength = 32767;
            this.consoleCmdTextBox.Multiline = false;
            this.consoleCmdTextBox.Name = "consoleCmdTextBox";
            this.consoleCmdTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.consoleCmdTextBox.Size = new System.Drawing.Size(858, 28);
            this.consoleCmdTextBox.TabIndex = 1;
            this.consoleCmdTextBox.Texts = "";
            this.consoleCmdTextBox.UnderlinedStyle = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1048, 651);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.topBarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.sideBarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.desktopPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.topBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sideBarPanel;
        private FontAwesome.Sharp.IconButton modoAbpButton;
        private FontAwesome.Sharp.IconButton modoOtaaButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton menuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton consoleButton;
        private FontAwesome.Sharp.IconButton fecharJanelaButton;
        private FontAwesome.Sharp.IconButton maximizarJanelaButton;
        private FontAwesome.Sharp.IconButton minimizarJanelaButton;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.RichTextBox consolePanel;
        private CustomControls.CTextBox consoleCmdTextBox;
        private FontAwesome.Sharp.IconButton enviarConsole;
        private FontAwesome.Sharp.IconButton salvarButton;
        private FontAwesome.Sharp.IconButton abrirButton;
        private System.Windows.Forms.Panel panel4;
    }
}

