namespace testDesign
{
    partial class Email
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
            this.tbTargy = new System.Windows.Forms.TextBox();
            this.tbUzenet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bKuldes = new System.Windows.Forms.Button();
            this.bMegse = new System.Windows.Forms.Button();
            this.Border = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbTargy
            // 
            this.tbTargy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTargy.Location = new System.Drawing.Point(12, 25);
            this.tbTargy.Name = "tbTargy";
            this.tbTargy.Size = new System.Drawing.Size(198, 20);
            this.tbTargy.TabIndex = 0;
            this.tbTargy.Enter += new System.EventHandler(this.tb_Enter);
            // 
            // tbUzenet
            // 
            this.tbUzenet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUzenet.Location = new System.Drawing.Point(12, 64);
            this.tbUzenet.Multiline = true;
            this.tbUzenet.Name = "tbUzenet";
            this.tbUzenet.Size = new System.Drawing.Size(198, 283);
            this.tbUzenet.TabIndex = 1;
            this.tbUzenet.Enter += new System.EventHandler(this.tb_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tárgy:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üzenet:";
            // 
            // bKuldes
            // 
            this.bKuldes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bKuldes.Location = new System.Drawing.Point(12, 353);
            this.bKuldes.Name = "bKuldes";
            this.bKuldes.Size = new System.Drawing.Size(142, 41);
            this.bKuldes.TabIndex = 4;
            this.bKuldes.Text = "Küldés";
            this.bKuldes.UseVisualStyleBackColor = true;
            this.bKuldes.Click += new System.EventHandler(this.bKuldes_Click);
            // 
            // bMegse
            // 
            this.bMegse.Location = new System.Drawing.Point(160, 353);
            this.bMegse.Name = "bMegse";
            this.bMegse.Size = new System.Drawing.Size(50, 41);
            this.bMegse.TabIndex = 5;
            this.bMegse.Text = "Mégse";
            this.bMegse.UseVisualStyleBackColor = true;
            this.bMegse.Click += new System.EventHandler(this.bMegse_Click);
            // 
            // Border
            // 
            this.Border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(227, 411);
            this.Border.TabIndex = 6;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 411);
            this.Controls.Add(this.bMegse);
            this.Controls.Add(this.bKuldes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUzenet);
            this.Controls.Add(this.tbTargy);
            this.Controls.Add(this.Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Email";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bKuldes;
        private System.Windows.Forms.Button bMegse;
        private System.Windows.Forms.Panel Border;
        public System.Windows.Forms.TextBox tbTargy;
        public System.Windows.Forms.TextBox tbUzenet;
    }
}