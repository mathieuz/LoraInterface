namespace LoraInterface.Forms
{
    partial class CustomDialog
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
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.fecharJanelaButton = new FontAwesome.Sharp.IconButton();
            this.msgText = new System.Windows.Forms.Label();
            this.windowTitle = new System.Windows.Forms.Label();
            this.topBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.topBarPanel.Controls.Add(this.windowTitle);
            this.topBarPanel.Controls.Add(this.label2);
            this.topBarPanel.Controls.Add(this.fecharJanelaButton);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(334, 39);
            this.topBarPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(8, 25);
            this.label2.TabIndex = 2;
            // 
            // fecharJanelaButton
            // 
            this.fecharJanelaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecharJanelaButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.fecharJanelaButton.FlatAppearance.BorderSize = 0;
            this.fecharJanelaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecharJanelaButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.fecharJanelaButton.IconColor = System.Drawing.Color.White;
            this.fecharJanelaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.fecharJanelaButton.IconSize = 15;
            this.fecharJanelaButton.Location = new System.Drawing.Point(289, 0);
            this.fecharJanelaButton.Name = "fecharJanelaButton";
            this.fecharJanelaButton.Size = new System.Drawing.Size(45, 39);
            this.fecharJanelaButton.TabIndex = 2;
            this.fecharJanelaButton.UseVisualStyleBackColor = true;
            this.fecharJanelaButton.Click += new System.EventHandler(this.fecharJanelaButton_Click);
            // 
            // msgText
            // 
            this.msgText.BackColor = System.Drawing.Color.Gainsboro;
            this.msgText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.msgText.Location = new System.Drawing.Point(0, 39);
            this.msgText.Name = "msgText";
            this.msgText.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.msgText.Size = new System.Drawing.Size(334, 181);
            this.msgText.TabIndex = 0;
            this.msgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.ForeColor = System.Drawing.Color.White;
            this.windowTitle.Location = new System.Drawing.Point(12, 9);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(0, 17);
            this.windowTitle.TabIndex = 3;
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(334, 220);
            this.ControlBox = false;
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.topBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBarPanel;
        private FontAwesome.Sharp.IconButton fecharJanelaButton;
        private System.Windows.Forms.Label msgText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label windowTitle;
    }
}