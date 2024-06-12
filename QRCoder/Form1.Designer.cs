
namespace QRSplit
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.comboBoxECC = new System.Windows.Forms.ComboBox();
            this.labelECC = new System.Windows.Forms.Label();
            this.labelIcon = new System.Windows.Forms.Label();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.selectIconBtn = new System.Windows.Forms.Button();
            this.labelIconsize = new System.Windows.Forms.Label();
            this.iconSize = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.colorDialogPrimaryColor = new System.Windows.Forms.ColorDialog();
            this.labelPreviewPrimaryColor = new System.Windows.Forms.Label();
            this.panelPreviewPrimaryColor = new System.Windows.Forms.Panel();
            this.labelPreviewBackgroundColor = new System.Windows.Forms.Label();
            this.panelPreviewBackgroundColor = new System.Windows.Forms.Panel();
            this.colorDialogBackgroundColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(513, 27);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(72, 27);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQRCode.Location = new System.Drawing.Point(47, 27);
            this.textBoxQRCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.Size = new System.Drawing.Size(459, 23);
            this.textBoxQRCode.TabIndex = 1;
            this.textBoxQRCode.Text = "1234567890";
            this.textBoxQRCode.TextChanged += new System.EventHandler(this.textBoxQRCode_TextChanged);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(47, 122);
            this.pictureBoxQRCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(539, 482);
            this.pictureBoxQRCode.TabIndex = 2;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBoxECC.Location = new System.Drawing.Point(113, 57);
            this.comboBoxECC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(145, 23);
            this.comboBoxECC.TabIndex = 3;
            this.comboBoxECC.SelectedIndexChanged += new System.EventHandler(this.comboBoxECC_SelectedIndexChanged);
            // 
            // labelECC
            // 
            this.labelECC.AutoSize = true;
            this.labelECC.Location = new System.Drawing.Point(43, 60);
            this.labelECC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelECC.Name = "labelECC";
            this.labelECC.Size = new System.Drawing.Size(61, 15);
            this.labelECC.TabIndex = 4;
            this.labelECC.Text = "ECC-Level";
            // 
            // labelIcon
            // 
            this.labelIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(290, 620);
            this.labelIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(33, 15);
            this.labelIcon.TabIndex = 5;
            this.labelIcon.Text = "Icon:";
            // 
            // iconPath
            // 
            this.iconPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPath.Location = new System.Drawing.Point(334, 616);
            this.iconPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPath.Name = "iconPath";
            this.iconPath.Size = new System.Drawing.Size(172, 23);
            this.iconPath.TabIndex = 6;
            // 
            // selectIconBtn
            // 
            this.selectIconBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectIconBtn.Location = new System.Drawing.Point(514, 613);
            this.selectIconBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectIconBtn.Name = "selectIconBtn";
            this.selectIconBtn.Size = new System.Drawing.Size(71, 29);
            this.selectIconBtn.TabIndex = 7;
            this.selectIconBtn.Text = "Select";
            this.selectIconBtn.UseVisualStyleBackColor = true;
            this.selectIconBtn.Click += new System.EventHandler(this.selectIconBtn_Click);
            // 
            // labelIconsize
            // 
            this.labelIconsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconsize.AutoSize = true;
            this.labelIconsize.Location = new System.Drawing.Point(49, 620);
            this.labelIconsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIconsize.Name = "labelIconsize";
            this.labelIconsize.Size = new System.Drawing.Size(55, 15);
            this.labelIconsize.TabIndex = 8;
            this.labelIconsize.Text = "Icon size:";
            // 
            // iconSize
            // 
            this.iconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconSize.Location = new System.Drawing.Point(117, 616);
            this.iconSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconSize.Name = "iconSize";
            this.iconSize.Size = new System.Drawing.Size(146, 23);
            this.iconSize.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(478, 647);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 29);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save QR code";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelPreviewPrimaryColor
            // 
            this.labelPreviewPrimaryColor.AutoSize = true;
            this.labelPreviewPrimaryColor.Location = new System.Drawing.Point(43, 95);
            this.labelPreviewPrimaryColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreviewPrimaryColor.Name = "labelPreviewPrimaryColor";
            this.labelPreviewPrimaryColor.Size = new System.Drawing.Size(78, 15);
            this.labelPreviewPrimaryColor.TabIndex = 12;
            this.labelPreviewPrimaryColor.Text = "Primary color";
            // 
            // panelPreviewPrimaryColor
            // 
            this.panelPreviewPrimaryColor.BackColor = System.Drawing.Color.Black;
            this.panelPreviewPrimaryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreviewPrimaryColor.Location = new System.Drawing.Point(203, 88);
            this.panelPreviewPrimaryColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPreviewPrimaryColor.Name = "panelPreviewPrimaryColor";
            this.panelPreviewPrimaryColor.Size = new System.Drawing.Size(56, 27);
            this.panelPreviewPrimaryColor.TabIndex = 13;
            this.panelPreviewPrimaryColor.Click += new System.EventHandler(this.panelPreviewPrimaryColor_Click);
            // 
            // labelPreviewBackgroundColor
            // 
            this.labelPreviewBackgroundColor.AutoSize = true;
            this.labelPreviewBackgroundColor.Location = new System.Drawing.Point(290, 95);
            this.labelPreviewBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreviewBackgroundColor.Name = "labelPreviewBackgroundColor";
            this.labelPreviewBackgroundColor.Size = new System.Drawing.Size(101, 15);
            this.labelPreviewBackgroundColor.TabIndex = 14;
            this.labelPreviewBackgroundColor.Text = "Background color";
            // 
            // panelPreviewBackgroundColor
            // 
            this.panelPreviewBackgroundColor.BackColor = System.Drawing.Color.White;
            this.panelPreviewBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreviewBackgroundColor.Location = new System.Drawing.Point(450, 88);
            this.panelPreviewBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPreviewBackgroundColor.Name = "panelPreviewBackgroundColor";
            this.panelPreviewBackgroundColor.Size = new System.Drawing.Size(56, 27);
            this.panelPreviewBackgroundColor.TabIndex = 15;
            this.panelPreviewBackgroundColor.Click += new System.EventHandler(this.panelPreviewBackgroundColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 690);
            this.Controls.Add(this.panelPreviewBackgroundColor);
            this.Controls.Add(this.labelPreviewBackgroundColor);
            this.Controls.Add(this.panelPreviewPrimaryColor);
            this.Controls.Add(this.labelPreviewPrimaryColor);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.iconSize);
            this.Controls.Add(this.labelIconsize);
            this.Controls.Add(this.selectIconBtn);
            this.Controls.Add(this.iconPath);
            this.Controls.Add(this.labelIcon);
            this.Controls.Add(this.labelECC);
            this.Controls.Add(this.comboBoxECC);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.textBoxQRCode);
            this.Controls.Add(this.buttonGenerate);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(650, 689);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRSplit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxQRCode;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.ComboBox comboBoxECC;
        private System.Windows.Forms.Label labelECC;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.Button selectIconBtn;
        private System.Windows.Forms.Label labelIconsize;
        private System.Windows.Forms.NumericUpDown iconSize;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ColorDialog colorDialogPrimaryColor;
        private System.Windows.Forms.Label labelPreviewPrimaryColor;
        private System.Windows.Forms.Panel panelPreviewPrimaryColor;
        private System.Windows.Forms.Label labelPreviewBackgroundColor;
        private System.Windows.Forms.Panel panelPreviewBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialogBackgroundColor;
    }
}