namespace DemosCommonCode
{
    public partial class AboutBoxBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxBaseForm));
            this.vintasoftLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productFAQLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.productLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.okButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagingSDKVersionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forumsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.decriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vintasoftLogoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vintasoftLogoPictureBox
            // 
            this.vintasoftLogoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.vintasoftLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vintasoftLogoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vintasoftLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("vintasoftLogoPictureBox.Image")));
            this.vintasoftLogoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.vintasoftLogoPictureBox.Name = "vintasoftLogoPictureBox";
            this.vintasoftLogoPictureBox.Size = new System.Drawing.Size(114, 100);
            this.vintasoftLogoPictureBox.TabIndex = 12;
            this.vintasoftLogoPictureBox.TabStop = false;
            this.vintasoftLogoPictureBox.Click += new System.EventHandler(this.vintasoftLogoPictureBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "FAQ:";
            // 
            // productFAQLinkLabel
            // 
            this.productFAQLinkLabel.AutoSize = true;
            this.productFAQLinkLabel.Location = new System.Drawing.Point(175, 45);
            this.productFAQLinkLabel.Name = "productFAQLinkLabel";
            this.productFAQLinkLabel.Size = new System.Drawing.Size(222, 13);
            this.productFAQLinkLabel.TabIndex = 28;
            this.productFAQLinkLabel.TabStop = true;
            this.productFAQLinkLabel.Text = "www.vintasoft.com/vsimaging-dotnet-faq.html";
            this.productFAQLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Web:";
            // 
            // productLinkLabel
            // 
            this.productLinkLabel.AutoSize = true;
            this.productLinkLabel.Location = new System.Drawing.Point(175, 24);
            this.productLinkLabel.Name = "productLinkLabel";
            this.productLinkLabel.Size = new System.Drawing.Size(166, 13);
            this.productLinkLabel.TabIndex = 26;
            this.productLinkLabel.TabStop = true;
            this.productLinkLabel.Text = "www.vintasoft.com/{0}-index.html";
            this.productLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Register:";
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Location = new System.Drawing.Point(175, 67);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(158, 13);
            this.registerLinkLabel.TabIndex = 30;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "www.vintasoft.com/register.html";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.Location = new System.Drawing.Point(191, 339);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 26);
            this.okButton.TabIndex = 32;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imagingSDKVersionLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.forumsLinkLabel);
            this.panel1.Controls.Add(this.vintasoftLogoPictureBox);
            this.panel1.Controls.Add(this.productLinkLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.registerLinkLabel);
            this.panel1.Controls.Add(this.productFAQLinkLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(5, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 110);
            this.panel1.TabIndex = 33;
            // 
            // imagingSDKVersionLabel
            // 
            this.imagingSDKVersionLabel.AutoSize = true;
            this.imagingSDKVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagingSDKVersionLabel.Location = new System.Drawing.Point(175, 4);
            this.imagingSDKVersionLabel.Name = "imagingSDKVersionLabel";
            this.imagingSDKVersionLabel.Size = new System.Drawing.Size(141, 13);
            this.imagingSDKVersionLabel.TabIndex = 35;
            this.imagingSDKVersionLabel.Text = "VintaSoft Imaging .NET v{0}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "SDK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Forums:";
            // 
            // forumsLinkLabel
            // 
            this.forumsLinkLabel.AutoSize = true;
            this.forumsLinkLabel.Location = new System.Drawing.Point(175, 89);
            this.forumsLinkLabel.Name = "forumsLinkLabel";
            this.forumsLinkLabel.Size = new System.Drawing.Size(138, 13);
            this.forumsLinkLabel.TabIndex = 32;
            this.forumsLinkLabel.TabStop = true;
            this.forumsLinkLabel.Text = "www.vintasoft.com/forums/";
            this.forumsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(5, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(444, 26);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "{0} v{1}";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decriptionRichTextBox
            // 
            this.decriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.decriptionRichTextBox.Location = new System.Drawing.Point(5, 45);
            this.decriptionRichTextBox.Name = "decriptionRichTextBox";
            this.decriptionRichTextBox.ReadOnly = true;
            this.decriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.decriptionRichTextBox.Size = new System.Drawing.Size(459, 160);
            this.decriptionRichTextBox.TabIndex = 35;
            this.decriptionRichTextBox.Tag = "";
            this.decriptionRichTextBox.Text = "";
            // 
            // AboutBoxBaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(469, 374);
            this.Controls.Add(this.decriptionRichTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBoxBaseForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            ((System.ComponentModel.ISupportInitialize)(this.vintasoftLogoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vintasoftLogoPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel productFAQLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel productLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel forumsLinkLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label imagingSDKVersionLabel;
        protected System.Windows.Forms.RichTextBox decriptionRichTextBox;

    }
}
