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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.pTermek = new System.Windows.Forms.Panel();
            this.bVegrehajtTermek = new System.Windows.Forms.Button();
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
            this.rbTorol1 = new System.Windows.Forms.RadioButton();
            this.rbUj1 = new System.Windows.Forms.RadioButton();
            this.rbSzerk1 = new System.Windows.Forms.RadioButton();
            this.tv = new System.Windows.Forms.TreeView();
            this.pFelhasz = new System.Windows.Forms.Panel();
            this.dgvFelhasznalok = new System.Windows.Forms.DataGridView();
            this.bVegrehajtFelhasz = new System.Windows.Forms.Button();
            this.gbFelhaszMuveletek = new System.Windows.Forms.GroupBox();
            this.tbUI = new System.Windows.Forms.ComboBox();
            this.tbFelhsznev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.rbTorol2 = new System.Windows.Forms.RadioButton();
            this.rbUj2 = new System.Windows.Forms.RadioButton();
            this.rbSzerk2 = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pTermek.SuspendLayout();
            this.gbMuvelet.SuspendLayout();
            this.gbMuveletek.SuspendLayout();
            this.pFelhasz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelhasznalok)).BeginInit();
            this.gbFelhaszMuveletek.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.pTermek.Controls.Add(this.bVegrehajtTermek);
            this.pTermek.Controls.Add(this.gbMuvelet);
            this.pTermek.Controls.Add(this.gbMuveletek);
            this.pTermek.Controls.Add(this.tv);
            this.pTermek.Location = new System.Drawing.Point(2, 39);
            this.pTermek.Name = "pTermek";
            this.pTermek.Size = new System.Drawing.Size(467, 520);
            this.pTermek.TabIndex = 1;
            this.pTermek.Visible = false;
            // 
            // bVegrehajtTermek
            // 
            this.bVegrehajtTermek.Location = new System.Drawing.Point(311, 411);
            this.bVegrehajtTermek.Name = "bVegrehajtTermek";
            this.bVegrehajtTermek.Size = new System.Drawing.Size(305, 41);
            this.bVegrehajtTermek.TabIndex = 12;
            this.bVegrehajtTermek.Text = "Végrehajt";
            this.bVegrehajtTermek.UseVisualStyleBackColor = true;
            this.bVegrehajtTermek.Click += new System.EventHandler(this.BVegrehajtTermek_Click);
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
            this.gbMuvelet.Size = new System.Drawing.Size(305, 332);
            this.gbMuvelet.TabIndex = 11;
            this.gbMuvelet.TabStop = false;
            this.gbMuvelet.Text = "Hozzáadás";
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
            this.tbMertekegyseg.Size = new System.Drawing.Size(273, 20);
            this.tbMertekegyseg.TabIndex = 9;
            // 
            // cbCsopNev
            // 
            this.cbCsopNev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCsopNev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCsopNev.Location = new System.Drawing.Point(10, 295);
            this.cbCsopNev.Name = "cbCsopNev";
            this.cbCsopNev.Size = new System.Drawing.Size(273, 21);
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
            this.cbGyujtonev.Size = new System.Drawing.Size(273, 21);
            this.cbGyujtonev.TabIndex = 7;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(10, 114);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(273, 20);
            this.tbNev.TabIndex = 8;
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(10, 235);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(273, 20);
            this.tbAr.TabIndex = 10;
            this.tbAr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_KeyPress);
            // 
            // gbMuveletek
            // 
            this.gbMuveletek.Controls.Add(this.rbTorol1);
            this.gbMuveletek.Controls.Add(this.rbUj1);
            this.gbMuveletek.Controls.Add(this.rbSzerk1);
            this.gbMuveletek.Location = new System.Drawing.Point(311, 3);
            this.gbMuveletek.Name = "gbMuveletek";
            this.gbMuveletek.Size = new System.Drawing.Size(305, 64);
            this.gbMuveletek.TabIndex = 6;
            this.gbMuveletek.TabStop = false;
            this.gbMuveletek.Text = "Műveletek";
            // 
            // rbTorol1
            // 
            this.rbTorol1.AutoSize = true;
            this.rbTorol1.Location = new System.Drawing.Point(234, 28);
            this.rbTorol1.Name = "rbTorol1";
            this.rbTorol1.Size = new System.Drawing.Size(54, 17);
            this.rbTorol1.TabIndex = 5;
            this.rbTorol1.Text = "Törlés";
            this.rbTorol1.UseVisualStyleBackColor = true;
            this.rbTorol1.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbUj1
            // 
            this.rbUj1.AutoSize = true;
            this.rbUj1.Checked = true;
            this.rbUj1.Location = new System.Drawing.Point(15, 28);
            this.rbUj1.Name = "rbUj1";
            this.rbUj1.Size = new System.Drawing.Size(95, 17);
            this.rbUj1.TabIndex = 3;
            this.rbUj1.TabStop = true;
            this.rbUj1.Text = "Új hozzáadása";
            this.rbUj1.UseVisualStyleBackColor = true;
            this.rbUj1.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbSzerk1
            // 
            this.rbSzerk1.AutoSize = true;
            this.rbSzerk1.Location = new System.Drawing.Point(131, 28);
            this.rbSzerk1.Name = "rbSzerk1";
            this.rbSzerk1.Size = new System.Drawing.Size(82, 17);
            this.rbSzerk1.TabIndex = 4;
            this.rbSzerk1.Text = "Szerkesztés";
            this.rbSzerk1.UseVisualStyleBackColor = true;
            this.rbSzerk1.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(9, 3);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(296, 449);
            this.tv.TabIndex = 2;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_AfterSelect);
            // 
            // pFelhasz
            // 
            this.pFelhasz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFelhasz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFelhasz.Controls.Add(this.dgvFelhasznalok);
            this.pFelhasz.Controls.Add(this.bVegrehajtFelhasz);
            this.pFelhasz.Controls.Add(this.gbFelhaszMuveletek);
            this.pFelhasz.Controls.Add(this.gb2);
            this.pFelhasz.Location = new System.Drawing.Point(2, 39);
            this.pFelhasz.Name = "pFelhasz";
            this.pFelhasz.Size = new System.Drawing.Size(467, 520);
            this.pFelhasz.TabIndex = 13;
            this.pFelhasz.Visible = false;
            // 
            // dgvFelhasznalok
            // 
            this.dgvFelhasznalok.AllowUserToAddRows = false;
            this.dgvFelhasznalok.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvFelhasznalok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFelhasznalok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFelhasznalok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFelhasznalok.BackgroundColor = System.Drawing.Color.White;
            this.dgvFelhasznalok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFelhasznalok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFelhasznalok.Location = new System.Drawing.Point(3, 73);
            this.dgvFelhasznalok.MultiSelect = false;
            this.dgvFelhasznalok.Name = "dgvFelhasznalok";
            this.dgvFelhasznalok.ReadOnly = true;
            this.dgvFelhasznalok.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvFelhasznalok.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFelhasznalok.RowTemplate.Height = 36;
            this.dgvFelhasznalok.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFelhasznalok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFelhasznalok.Size = new System.Drawing.Size(455, 168);
            this.dgvFelhasznalok.TabIndex = 13;
            this.dgvFelhasznalok.SelectionChanged += new System.EventHandler(this.DgvFelhasznalok_SelectionChanged);
            // 
            // bVegrehajtFelhasz
            // 
            this.bVegrehajtFelhasz.Location = new System.Drawing.Point(323, 415);
            this.bVegrehajtFelhasz.Name = "bVegrehajtFelhasz";
            this.bVegrehajtFelhasz.Size = new System.Drawing.Size(132, 41);
            this.bVegrehajtFelhasz.TabIndex = 12;
            this.bVegrehajtFelhasz.Text = "Végrehajt";
            this.bVegrehajtFelhasz.UseVisualStyleBackColor = true;
            this.bVegrehajtFelhasz.Click += new System.EventHandler(this.BVegrehajtFelhasz_Click);
            // 
            // gbFelhaszMuveletek
            // 
            this.gbFelhaszMuveletek.Controls.Add(this.tbUI);
            this.gbFelhaszMuveletek.Controls.Add(this.tbFelhsznev);
            this.gbFelhaszMuveletek.Controls.Add(this.label6);
            this.gbFelhaszMuveletek.Controls.Add(this.label8);
            this.gbFelhaszMuveletek.Controls.Add(this.label10);
            this.gbFelhaszMuveletek.Controls.Add(this.tbJelszo);
            this.gbFelhaszMuveletek.Location = new System.Drawing.Point(3, 251);
            this.gbFelhaszMuveletek.Name = "gbFelhaszMuveletek";
            this.gbFelhaszMuveletek.Size = new System.Drawing.Size(302, 214);
            this.gbFelhaszMuveletek.TabIndex = 11;
            this.gbFelhaszMuveletek.TabStop = false;
            this.gbFelhaszMuveletek.Text = "Hozzáadás";
            // 
            // tbUI
            // 
            this.tbUI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbUI.FormattingEnabled = true;
            this.tbUI.Items.AddRange(new object[] {
            "Pultos",
            "Munkás",
            "Admin"});
            this.tbUI.Location = new System.Drawing.Point(10, 175);
            this.tbUI.Name = "tbUI";
            this.tbUI.Size = new System.Drawing.Size(273, 21);
            this.tbUI.TabIndex = 19;
            // 
            // tbFelhsznev
            // 
            this.tbFelhsznev.Location = new System.Drawing.Point(10, 50);
            this.tbFelhsznev.Name = "tbFelhsznev";
            this.tbFelhsznev.Size = new System.Drawing.Size(273, 20);
            this.tbFelhsznev.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "UI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Felhasználónév";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Jelszó";
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(10, 114);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(273, 20);
            this.tbJelszo.TabIndex = 18;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.rbTorol2);
            this.gb2.Controls.Add(this.rbUj2);
            this.gb2.Controls.Add(this.rbSzerk2);
            this.gb2.Location = new System.Drawing.Point(3, 3);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(455, 64);
            this.gb2.TabIndex = 6;
            this.gb2.TabStop = false;
            this.gb2.Text = "Műveletek";
            // 
            // rbTorol2
            // 
            this.rbTorol2.AutoSize = true;
            this.rbTorol2.Location = new System.Drawing.Point(354, 28);
            this.rbTorol2.Name = "rbTorol2";
            this.rbTorol2.Size = new System.Drawing.Size(54, 17);
            this.rbTorol2.TabIndex = 5;
            this.rbTorol2.Text = "Törlés";
            this.rbTorol2.UseVisualStyleBackColor = true;
            this.rbTorol2.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbUj2
            // 
            this.rbUj2.AutoSize = true;
            this.rbUj2.Checked = true;
            this.rbUj2.Location = new System.Drawing.Point(31, 28);
            this.rbUj2.Name = "rbUj2";
            this.rbUj2.Size = new System.Drawing.Size(95, 17);
            this.rbUj2.TabIndex = 3;
            this.rbUj2.TabStop = true;
            this.rbUj2.Text = "Új hozzáadása";
            this.rbUj2.UseVisualStyleBackColor = true;
            this.rbUj2.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // rbSzerk2
            // 
            this.rbSzerk2.AutoSize = true;
            this.rbSzerk2.Location = new System.Drawing.Point(192, 28);
            this.rbSzerk2.Name = "rbSzerk2";
            this.rbSzerk2.Size = new System.Drawing.Size(82, 17);
            this.rbSzerk2.TabIndex = 4;
            this.rbSzerk2.Text = "Szerkesztés";
            this.rbSzerk2.UseVisualStyleBackColor = true;
            this.rbSzerk2.CheckedChanged += new System.EventHandler(this.Rb_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UI3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 560);
            this.Controls.Add(this.pFelhasz);
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
            this.pFelhasz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelhasznalok)).EndInit();
            this.gbFelhaszMuveletek.ResumeLayout(false);
            this.gbFelhaszMuveletek.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.Panel pTermek;
        private System.Windows.Forms.GroupBox gbMuveletek;
        private System.Windows.Forms.RadioButton rbTorol1;
        private System.Windows.Forms.RadioButton rbUj1;
        private System.Windows.Forms.RadioButton rbSzerk1;
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
        private System.Windows.Forms.Button bVegrehajtTermek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMertekegyseg;
        private System.Windows.Forms.Panel pFelhasz;
        private System.Windows.Forms.Button bVegrehajtFelhasz;
        private System.Windows.Forms.GroupBox gbFelhaszMuveletek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.RadioButton rbTorol2;
        private System.Windows.Forms.RadioButton rbUj2;
        private System.Windows.Forms.RadioButton rbSzerk2;
        private System.Windows.Forms.TextBox tbFelhsznev;
        private System.Windows.Forms.DataGridView dgvFelhasznalok;
        private System.Windows.Forms.ComboBox tbUI;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}