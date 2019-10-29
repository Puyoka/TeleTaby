namespace testDesign
{
    partial class UI3
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
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.pTermek = new System.Windows.Forms.Panel();
            this.bVegrehajt = new System.Windows.Forms.Button();
            this.gbMuvelet = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMertekegyseg = new System.Windows.Forms.TextBox();
            this.cbCsopNev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGyujtonev = new System.Windows.Forms.ComboBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.gbMuveletek = new System.Windows.Forms.GroupBox();
            this.rbTorol = new System.Windows.Forms.RadioButton();
            this.rbUj = new System.Windows.Forms.RadioButton();
            this.rbSzerk = new System.Windows.Forms.RadioButton();
            this.tv = new System.Windows.Forms.TreeView();
            this.pTermek.SuspendLayout();
            this.gbMuvelet.SuspendLayout();
            this.gbMuveletek.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTabla
            // 
            this.cbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTabla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTabla.Items.AddRange(new object[] {
            "Felhasználók",
            "Termékek",
            "Rendelések"});
            this.cbTabla.Location = new System.Drawing.Point(12, 12);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(121, 21);
            this.cbTabla.TabIndex = 0;
            this.cbTabla.SelectedIndexChanged += new System.EventHandler(this.cbTabla_SelectedIndexChanged);
            // 
            // pTermek
            // 
            this.pTermek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTermek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTermek.Controls.Add(this.bVegrehajt);
            this.pTermek.Controls.Add(this.gbMuvelet);
            this.pTermek.Controls.Add(this.gbMuveletek);
            this.pTermek.Controls.Add(this.tv);
            this.pTermek.Location = new System.Drawing.Point(2, 39);
            this.pTermek.Name = "pTermek";
            this.pTermek.Size = new System.Drawing.Size(797, 410);
            this.pTermek.TabIndex = 1;
            this.pTermek.Visible = false;
            // 
            // bVegrehajt
            // 
            this.bVegrehajt.Location = new System.Drawing.Point(636, 185);
            this.bVegrehajt.Name = "bVegrehajt";
            this.bVegrehajt.Size = new System.Drawing.Size(75, 47);
            this.bVegrehajt.TabIndex = 12;
            this.bVegrehajt.Text = "Végrehajt";
            this.bVegrehajt.UseVisualStyleBackColor = true;
            this.bVegrehajt.Click += new System.EventHandler(this.BVegrehajt_Click);
            // 
            // gbMuvelet
            // 
            this.gbMuvelet.Controls.Add(this.label5);
            this.gbMuvelet.Controls.Add(this.label2);
            this.gbMuvelet.Controls.Add(this.label4);
            this.gbMuvelet.Controls.Add(this.label3);
            this.gbMuvelet.Controls.Add(this.tbMertekegyseg);
            this.gbMuvelet.Controls.Add(this.cbCsopNev);
            this.gbMuvelet.Controls.Add(this.label1);
            this.gbMuvelet.Controls.Add(this.cbGyujtonev);
            this.gbMuvelet.Controls.Add(this.tbNev);
            this.gbMuvelet.Controls.Add(this.tbAr);
            this.gbMuvelet.Location = new System.Drawing.Point(311, 73);
            this.gbMuvelet.Name = "gbMuvelet";
            this.gbMuvelet.Size = new System.Drawing.Size(244, 332);
            this.gbMuvelet.TabIndex = 11;
            this.gbMuvelet.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mértékegység";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tartozás";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gyűjtőnév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ár";
            // 
            // tbMertekegyseg
            // 
            this.tbMertekegyseg.Location = new System.Drawing.Point(10, 175);
            this.tbMertekegyseg.Name = "tbMertekegyseg";
            this.tbMertekegyseg.Size = new System.Drawing.Size(215, 20);
            this.tbMertekegyseg.TabIndex = 9;
            // 
            // cbCsopNev
            // 
            this.cbCsopNev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCsopNev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCsopNev.Location = new System.Drawing.Point(10, 295);
            this.cbCsopNev.Name = "cbCsopNev";
            this.cbCsopNev.Size = new System.Drawing.Size(215, 21);
            this.cbCsopNev.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Név";
            // 
            // cbGyujtonev
            // 
            this.cbGyujtonev.FormattingEnabled = true;
            this.cbGyujtonev.Location = new System.Drawing.Point(10, 53);
            this.cbGyujtonev.Name = "cbGyujtonev";
            this.cbGyujtonev.Size = new System.Drawing.Size(215, 21);
            this.cbGyujtonev.TabIndex = 7;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(10, 114);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(215, 20);
            this.tbNev.TabIndex = 8;
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(10, 235);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(215, 20);
            this.tbAr.TabIndex = 10;
            this.tbAr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAr_KeyPress);
            // 
            // gbMuveletek
            // 
            this.gbMuveletek.Controls.Add(this.rbTorol);
            this.gbMuveletek.Controls.Add(this.rbUj);
            this.gbMuveletek.Controls.Add(this.rbSzerk);
            this.gbMuveletek.Location = new System.Drawing.Point(311, 3);
            this.gbMuveletek.Name = "gbMuveletek";
            this.gbMuveletek.Size = new System.Drawing.Size(481, 64);
            this.gbMuveletek.TabIndex = 6;
            this.gbMuveletek.TabStop = false;
            this.gbMuveletek.Text = "Műveletek";
            // 
            // rbTorol
            // 
            this.rbTorol.AutoSize = true;
            this.rbTorol.Location = new System.Drawing.Point(313, 29);
            this.rbTorol.Name = "rbTorol";
            this.rbTorol.Size = new System.Drawing.Size(49, 17);
            this.rbTorol.TabIndex = 5;
            this.rbTorol.Text = "Töröl";
            this.rbTorol.UseVisualStyleBackColor = true;
            this.rbTorol.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbUj
            // 
            this.rbUj.AutoSize = true;
            this.rbUj.Checked = true;
            this.rbUj.Location = new System.Drawing.Point(94, 29);
            this.rbUj.Name = "rbUj";
            this.rbUj.Size = new System.Drawing.Size(95, 17);
            this.rbUj.TabIndex = 3;
            this.rbUj.TabStop = true;
            this.rbUj.Text = "Új hozzáadása";
            this.rbUj.UseVisualStyleBackColor = true;
            this.rbUj.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbSzerk
            // 
            this.rbSzerk.AutoSize = true;
            this.rbSzerk.Location = new System.Drawing.Point(210, 29);
            this.rbSzerk.Name = "rbSzerk";
            this.rbSzerk.Size = new System.Drawing.Size(82, 17);
            this.rbSzerk.TabIndex = 4;
            this.rbSzerk.Text = "Szerkesztés";
            this.rbSzerk.UseVisualStyleBackColor = true;
            this.rbSzerk.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(9, 3);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(296, 402);
            this.tv.TabIndex = 2;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_AfterSelect);
            // 
            // UI3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pTermek);
            this.Controls.Add(this.cbTabla);
            this.Name = "UI3";
            this.Text = "UI3";
            this.Load += new System.EventHandler(this.UI3_Load);
            this.pTermek.ResumeLayout(false);
            this.gbMuvelet.ResumeLayout(false);
            this.gbMuvelet.PerformLayout();
            this.gbMuveletek.ResumeLayout(false);
            this.gbMuveletek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.Panel pTermek;
        private System.Windows.Forms.GroupBox gbMuveletek;
        private System.Windows.Forms.RadioButton rbTorol;
        private System.Windows.Forms.RadioButton rbUj;
        private System.Windows.Forms.RadioButton rbSzerk;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.GroupBox gbMuvelet;
        private System.Windows.Forms.ComboBox cbGyujtonev;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.ComboBox cbCsopNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVegrehajt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMertekegyseg;
    }
}