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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI3));
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.pTermek = new System.Windows.Forms.Panel();
            this.bVegrehajtTermek = new System.Windows.Forms.Button();
            this.gbMezokTermek = new System.Windows.Forms.GroupBox();
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
            this.gbMuvTermek = new System.Windows.Forms.GroupBox();
            this.rbTorol1 = new System.Windows.Forms.RadioButton();
            this.rbUj1 = new System.Windows.Forms.RadioButton();
            this.rbSzerk1 = new System.Windows.Forms.RadioButton();
            this.tv = new System.Windows.Forms.TreeView();
            this.pFelhasz = new System.Windows.Forms.Panel();
            this.dgvFelhasznalok = new System.Windows.Forms.DataGridView();
            this.bVegrehajtFelhasz = new System.Windows.Forms.Button();
            this.gbMezokFelhasz = new System.Windows.Forms.GroupBox();
            this.tbUI = new System.Windows.Forms.ComboBox();
            this.tbFelhsznev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.gbMuvFelhasz = new System.Windows.Forms.GroupBox();
            this.rbTorol2 = new System.Windows.Forms.RadioButton();
            this.rbUj2 = new System.Windows.Forms.RadioButton();
            this.rbSzerk2 = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bBezár = new System.Windows.Forms.Button();
            this.pStat = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lOsszesRendeles = new System.Windows.Forms.Label();
            this.lOsszesTetel = new System.Windows.Forms.Label();
            this.lBevetel = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.rbFoly = new System.Windows.Forms.RadioButton();
            this.rbKesz = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbRend = new System.Windows.Forms.RadioButton();
            this.rbTerm = new System.Windows.Forms.RadioButton();
            this.bFrissit = new System.Windows.Forms.Button();
            this.dgvStat = new System.Windows.Forms.DataGridView();
            this.bLeft = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.lTest = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.tIdo = new System.Windows.Forms.Timer(this.components);
            this.lIdo = new System.Windows.Forms.Label();
            this.pAdatbazis = new System.Windows.Forms.Panel();
            this.dgvDT = new System.Windows.Forms.DataGridView();
            this.cbAdatbazis = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bMentesUrites = new System.Windows.Forms.Button();
            this.cBoxMentes = new System.Windows.Forms.CheckBox();
            this.pTermek.SuspendLayout();
            this.gbMezokTermek.SuspendLayout();
            this.gbMuvTermek.SuspendLayout();
            this.pFelhasz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelhasznalok)).BeginInit();
            this.gbMezokFelhasz.SuspendLayout();
            this.gbMuvFelhasz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pStat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).BeginInit();
            this.pAdatbazis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTabla
            // 
            this.cbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTabla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTabla.Items.AddRange(new object[] {
            "Felhasználók",
            "Termékek",
            "Rendelések",
            "Adatbázis"});
            this.cbTabla.Location = new System.Drawing.Point(11, 12);
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
            this.pTermek.Controls.Add(this.gbMezokTermek);
            this.pTermek.Controls.Add(this.gbMuvTermek);
            this.pTermek.Controls.Add(this.tv);
            this.pTermek.Location = new System.Drawing.Point(2, 50);
            this.pTermek.Name = "pTermek";
            this.pTermek.Size = new System.Drawing.Size(581, 327);
            this.pTermek.TabIndex = 1;
            this.pTermek.Visible = false;
            // 
            // bVegrehajtTermek
            // 
            this.bVegrehajtTermek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVegrehajtTermek.Location = new System.Drawing.Point(294, 276);
            this.bVegrehajtTermek.Name = "bVegrehajtTermek";
            this.bVegrehajtTermek.Size = new System.Drawing.Size(243, 41);
            this.bVegrehajtTermek.TabIndex = 12;
            this.bVegrehajtTermek.Text = "Végrehajt";
            this.bVegrehajtTermek.UseVisualStyleBackColor = true;
            this.bVegrehajtTermek.Click += new System.EventHandler(this.BVegrehajtTermek_Click);
            // 
            // gbMezokTermek
            // 
            this.gbMezokTermek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMezokTermek.Controls.Add(this.label5);
            this.gbMezokTermek.Controls.Add(this.label2);
            this.gbMezokTermek.Controls.Add(this.label4);
            this.gbMezokTermek.Controls.Add(this.label3);
            this.gbMezokTermek.Controls.Add(this.tbMertekegyseg);
            this.gbMezokTermek.Controls.Add(this.cbCsopNev);
            this.gbMezokTermek.Controls.Add(this.label1);
            this.gbMezokTermek.Controls.Add(this.cbGyujtonev);
            this.gbMezokTermek.Controls.Add(this.tbNev);
            this.gbMezokTermek.Controls.Add(this.tbAr);
            this.gbMezokTermek.Location = new System.Drawing.Point(267, 73);
            this.gbMezokTermek.Name = "gbMezokTermek";
            this.gbMezokTermek.Size = new System.Drawing.Size(305, 198);
            this.gbMezokTermek.TabIndex = 11;
            this.gbMezokTermek.TabStop = false;
            this.gbMezokTermek.Text = "Hozzáadás";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mértékegység";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tartozás";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, -39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gyűjtőnév";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ár";
            // 
            // tbMertekegyseg
            // 
            this.tbMertekegyseg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMertekegyseg.Location = new System.Drawing.Point(10, 110);
            this.tbMertekegyseg.Name = "tbMertekegyseg";
            this.tbMertekegyseg.Size = new System.Drawing.Size(273, 20);
            this.tbMertekegyseg.TabIndex = 9;
            // 
            // cbCsopNev
            // 
            this.cbCsopNev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCsopNev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCsopNev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCsopNev.Location = new System.Drawing.Point(10, 230);
            this.cbCsopNev.Name = "cbCsopNev";
            this.cbCsopNev.Size = new System.Drawing.Size(273, 21);
            this.cbCsopNev.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Név";
            // 
            // cbGyujtonev
            // 
            this.cbGyujtonev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGyujtonev.FormattingEnabled = true;
            this.cbGyujtonev.Location = new System.Drawing.Point(10, -12);
            this.cbGyujtonev.Name = "cbGyujtonev";
            this.cbGyujtonev.Size = new System.Drawing.Size(273, 21);
            this.cbGyujtonev.TabIndex = 7;
            // 
            // tbNev
            // 
            this.tbNev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNev.Location = new System.Drawing.Point(10, 49);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(273, 20);
            this.tbNev.TabIndex = 8;
            // 
            // tbAr
            // 
            this.tbAr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAr.Location = new System.Drawing.Point(10, 170);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(273, 20);
            this.tbAr.TabIndex = 10;
            this.tbAr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_KeyPress);
            // 
            // gbMuvTermek
            // 
            this.gbMuvTermek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMuvTermek.Controls.Add(this.rbTorol1);
            this.gbMuvTermek.Controls.Add(this.rbUj1);
            this.gbMuvTermek.Controls.Add(this.rbSzerk1);
            this.gbMuvTermek.Location = new System.Drawing.Point(267, 3);
            this.gbMuvTermek.Name = "gbMuvTermek";
            this.gbMuvTermek.Size = new System.Drawing.Size(305, 64);
            this.gbMuvTermek.TabIndex = 6;
            this.gbMuvTermek.TabStop = false;
            this.gbMuvTermek.Text = "Műveletek";
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
            this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv.Location = new System.Drawing.Point(9, 3);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(252, 315);
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
            this.pFelhasz.Controls.Add(this.gbMezokFelhasz);
            this.pFelhasz.Controls.Add(this.gbMuvFelhasz);
            this.pFelhasz.Location = new System.Drawing.Point(2, 50);
            this.pFelhasz.Name = "pFelhasz";
            this.pFelhasz.Size = new System.Drawing.Size(581, 327);
            this.pFelhasz.TabIndex = 13;
            this.pFelhasz.Visible = false;
            // 
            // dgvFelhasznalok
            // 
            this.dgvFelhasznalok.AllowUserToAddRows = false;
            this.dgvFelhasznalok.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvFelhasznalok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvFelhasznalok.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFelhasznalok.RowTemplate.Height = 36;
            this.dgvFelhasznalok.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFelhasznalok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFelhasznalok.Size = new System.Drawing.Size(569, 31);
            this.dgvFelhasznalok.TabIndex = 13;
            this.dgvFelhasznalok.SelectionChanged += new System.EventHandler(this.DgvFelhasznalok_SelectionChanged);
            // 
            // bVegrehajtFelhasz
            // 
            this.bVegrehajtFelhasz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVegrehajtFelhasz.Location = new System.Drawing.Point(442, 278);
            this.bVegrehajtFelhasz.Name = "bVegrehajtFelhasz";
            this.bVegrehajtFelhasz.Size = new System.Drawing.Size(132, 41);
            this.bVegrehajtFelhasz.TabIndex = 12;
            this.bVegrehajtFelhasz.Text = "Végrehajt";
            this.bVegrehajtFelhasz.UseVisualStyleBackColor = true;
            this.bVegrehajtFelhasz.Click += new System.EventHandler(this.BVegrehajtFelhasz_Click);
            // 
            // gbMezokFelhasz
            // 
            this.gbMezokFelhasz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMezokFelhasz.Controls.Add(this.tbUI);
            this.gbMezokFelhasz.Controls.Add(this.tbFelhsznev);
            this.gbMezokFelhasz.Controls.Add(this.label6);
            this.gbMezokFelhasz.Controls.Add(this.label8);
            this.gbMezokFelhasz.Controls.Add(this.label10);
            this.gbMezokFelhasz.Controls.Add(this.tbJelszo);
            this.gbMezokFelhasz.Location = new System.Drawing.Point(3, 107);
            this.gbMezokFelhasz.Name = "gbMezokFelhasz";
            this.gbMezokFelhasz.Size = new System.Drawing.Size(433, 214);
            this.gbMezokFelhasz.TabIndex = 11;
            this.gbMezokFelhasz.TabStop = false;
            this.gbMezokFelhasz.Text = "Hozzáadás";
            // 
            // tbUI
            // 
            this.tbUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbUI.FormattingEnabled = true;
            this.tbUI.Items.AddRange(new object[] {
            "Pultos",
            "Munkás",
            "Admin"});
            this.tbUI.Location = new System.Drawing.Point(10, 175);
            this.tbUI.Name = "tbUI";
            this.tbUI.Size = new System.Drawing.Size(392, 21);
            this.tbUI.TabIndex = 19;
            // 
            // tbFelhsznev
            // 
            this.tbFelhsznev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFelhsznev.Location = new System.Drawing.Point(10, 50);
            this.tbFelhsznev.Name = "tbFelhsznev";
            this.tbFelhsznev.Size = new System.Drawing.Size(392, 20);
            this.tbFelhsznev.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tbJelszo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJelszo.Location = new System.Drawing.Point(10, 114);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(392, 20);
            this.tbJelszo.TabIndex = 18;
            // 
            // gbMuvFelhasz
            // 
            this.gbMuvFelhasz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMuvFelhasz.Controls.Add(this.rbTorol2);
            this.gbMuvFelhasz.Controls.Add(this.rbUj2);
            this.gbMuvFelhasz.Controls.Add(this.rbSzerk2);
            this.gbMuvFelhasz.Location = new System.Drawing.Point(3, 3);
            this.gbMuvFelhasz.Name = "gbMuvFelhasz";
            this.gbMuvFelhasz.Size = new System.Drawing.Size(569, 64);
            this.gbMuvFelhasz.TabIndex = 6;
            this.gbMuvFelhasz.TabStop = false;
            this.gbMuvFelhasz.Text = "Műveletek";
            // 
            // rbTorol2
            // 
            this.rbTorol2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTorol2.AutoSize = true;
            this.rbTorol2.Location = new System.Drawing.Point(499, 28);
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
            this.rbSzerk2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSzerk2.AutoSize = true;
            this.rbSzerk2.Location = new System.Drawing.Point(256, 28);
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
            // bBezár
            // 
            this.bBezár.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBezár.Location = new System.Drawing.Point(508, 8);
            this.bBezár.Name = "bBezár";
            this.bBezár.Size = new System.Drawing.Size(75, 23);
            this.bBezár.TabIndex = 14;
            this.bBezár.Text = "Bezár";
            this.bBezár.UseVisualStyleBackColor = true;
            this.bBezár.Click += new System.EventHandler(this.bBezár_Click);
            // 
            // pStat
            // 
            this.pStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pStat.Controls.Add(this.groupBox1);
            this.pStat.Controls.Add(this.gb2);
            this.pStat.Controls.Add(this.gb1);
            this.pStat.Controls.Add(this.bFrissit);
            this.pStat.Controls.Add(this.dgvStat);
            this.pStat.Controls.Add(this.bLeft);
            this.pStat.Controls.Add(this.bRight);
            this.pStat.Controls.Add(this.lTest);
            this.pStat.Location = new System.Drawing.Point(2, 50);
            this.pStat.Name = "pStat";
            this.pStat.Size = new System.Drawing.Size(581, 328);
            this.pStat.TabIndex = 15;
            this.pStat.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lOsszesRendeles);
            this.groupBox1.Controls.Add(this.lOsszesTetel);
            this.groupBox1.Controls.Add(this.lBevetel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 91);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eddigi adatok";
            // 
            // lOsszesRendeles
            // 
            this.lOsszesRendeles.AutoSize = true;
            this.lOsszesRendeles.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOsszesRendeles.Location = new System.Drawing.Point(6, 21);
            this.lOsszesRendeles.Name = "lOsszesRendeles";
            this.lOsszesRendeles.Size = new System.Drawing.Size(78, 17);
            this.lOsszesRendeles.TabIndex = 17;
            this.lOsszesRendeles.Text = "Rendelés: ";
            // 
            // lOsszesTetel
            // 
            this.lOsszesTetel.AutoSize = true;
            this.lOsszesTetel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOsszesTetel.Location = new System.Drawing.Point(6, 44);
            this.lOsszesTetel.Name = "lOsszesTetel";
            this.lOsszesTetel.Size = new System.Drawing.Size(44, 17);
            this.lOsszesTetel.TabIndex = 18;
            this.lOsszesTetel.Text = "Tétel:";
            // 
            // lBevetel
            // 
            this.lBevetel.AutoSize = true;
            this.lBevetel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBevetel.Location = new System.Drawing.Point(6, 68);
            this.lBevetel.Name = "lBevetel";
            this.lBevetel.Size = new System.Drawing.Size(60, 17);
            this.lBevetel.TabIndex = 19;
            this.lBevetel.Text = "Bevétel:";
            // 
            // gb2
            // 
            this.gb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb2.Controls.Add(this.rbFoly);
            this.gb2.Controls.Add(this.rbKesz);
            this.gb2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb2.Location = new System.Drawing.Point(373, 233);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(120, 81);
            this.gb2.TabIndex = 5;
            this.gb2.TabStop = false;
            this.gb2.Text = "Kész/Folyamatban";
            // 
            // rbFoly
            // 
            this.rbFoly.AutoSize = true;
            this.rbFoly.Location = new System.Drawing.Point(7, 48);
            this.rbFoly.Name = "rbFoly";
            this.rbFoly.Size = new System.Drawing.Size(110, 21);
            this.rbFoly.TabIndex = 3;
            this.rbFoly.Text = "Folyamatban";
            this.rbFoly.UseVisualStyleBackColor = true;
            // 
            // rbKesz
            // 
            this.rbKesz.AutoSize = true;
            this.rbKesz.Checked = true;
            this.rbKesz.Location = new System.Drawing.Point(7, 21);
            this.rbKesz.Name = "rbKesz";
            this.rbKesz.Size = new System.Drawing.Size(60, 21);
            this.rbKesz.TabIndex = 2;
            this.rbKesz.TabStop = true;
            this.rbKesz.Text = "Kész";
            this.rbKesz.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.Controls.Add(this.rbRend);
            this.gb1.Controls.Add(this.rbTerm);
            this.gb1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb1.Location = new System.Drawing.Point(247, 233);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(120, 81);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Termék/Rendelés";
            // 
            // rbRend
            // 
            this.rbRend.AutoSize = true;
            this.rbRend.Location = new System.Drawing.Point(6, 48);
            this.rbRend.Name = "rbRend";
            this.rbRend.Size = new System.Drawing.Size(88, 21);
            this.rbRend.TabIndex = 1;
            this.rbRend.Text = "Rendelés";
            this.rbRend.UseVisualStyleBackColor = true;
            // 
            // rbTerm
            // 
            this.rbTerm.AutoSize = true;
            this.rbTerm.Checked = true;
            this.rbTerm.Location = new System.Drawing.Point(6, 21);
            this.rbTerm.Name = "rbTerm";
            this.rbTerm.Size = new System.Drawing.Size(74, 21);
            this.rbTerm.TabIndex = 0;
            this.rbTerm.TabStop = true;
            this.rbTerm.Text = "Termék";
            this.rbTerm.UseVisualStyleBackColor = true;
            // 
            // bFrissit
            // 
            this.bFrissit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFrissit.Location = new System.Drawing.Point(499, 233);
            this.bFrissit.Name = "bFrissit";
            this.bFrissit.Size = new System.Drawing.Size(75, 23);
            this.bFrissit.TabIndex = 3;
            this.bFrissit.Text = "Frissítés";
            this.bFrissit.UseVisualStyleBackColor = true;
            this.bFrissit.Click += new System.EventHandler(this.bFrissit_Click);
            // 
            // dgvStat
            // 
            this.dgvStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStat.Location = new System.Drawing.Point(40, 3);
            this.dgvStat.Name = "dgvStat";
            this.dgvStat.Size = new System.Drawing.Size(497, 224);
            this.dgvStat.TabIndex = 0;
            // 
            // bLeft
            // 
            this.bLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bLeft.Location = new System.Drawing.Point(-1, 3);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(40, 224);
            this.bLeft.TabIndex = 1;
            this.bLeft.Text = "<";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bRight
            // 
            this.bRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bRight.Location = new System.Drawing.Point(538, 3);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(40, 224);
            this.bRight.TabIndex = 2;
            this.bRight.Text = ">";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // lTest
            // 
            this.lTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTest.Location = new System.Drawing.Point(-11, 229);
            this.lTest.Name = "lTest";
            this.lTest.Size = new System.Drawing.Size(598, 21);
            this.lTest.TabIndex = 16;
            this.lTest.Text = "1";
            this.lTest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDatum
            // 
            this.labelDatum.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatum.Location = new System.Drawing.Point(139, 8);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(83, 33);
            this.labelDatum.TabIndex = 16;
            this.labelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tIdo
            // 
            this.tIdo.Tick += new System.EventHandler(this.tIdo_Tick);
            // 
            // lIdo
            // 
            this.lIdo.AutoSize = true;
            this.lIdo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lIdo.Location = new System.Drawing.Point(228, 13);
            this.lIdo.Name = "lIdo";
            this.lIdo.Size = new System.Drawing.Size(57, 20);
            this.lIdo.TabIndex = 17;
            this.lIdo.Text = "00:00:00";
            this.lIdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pAdatbazis
            // 
            this.pAdatbazis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAdatbazis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAdatbazis.Controls.Add(this.dgvDT);
            this.pAdatbazis.Controls.Add(this.cbAdatbazis);
            this.pAdatbazis.Controls.Add(this.label14);
            this.pAdatbazis.Controls.Add(this.bMentesUrites);
            this.pAdatbazis.Controls.Add(this.cBoxMentes);
            this.pAdatbazis.Location = new System.Drawing.Point(2, 50);
            this.pAdatbazis.Name = "pAdatbazis";
            this.pAdatbazis.Size = new System.Drawing.Size(581, 327);
            this.pAdatbazis.TabIndex = 18;
            // 
            // dgvDT
            // 
            this.dgvDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDT.Location = new System.Drawing.Point(137, 8);
            this.dgvDT.Name = "dgvDT";
            this.dgvDT.ReadOnly = true;
            this.dgvDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDT.Size = new System.Drawing.Size(437, 312);
            this.dgvDT.TabIndex = 9;
            // 
            // cbAdatbazis
            // 
            this.cbAdatbazis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdatbazis.FormattingEnabled = true;
            this.cbAdatbazis.Items.AddRange(new object[] {
            "Rendelések",
            "Rendelés tételek"});
            this.cbAdatbazis.Location = new System.Drawing.Point(6, 16);
            this.cbAdatbazis.Name = "cbAdatbazis";
            this.cbAdatbazis.Size = new System.Drawing.Size(121, 21);
            this.cbAdatbazis.TabIndex = 8;
            this.cbAdatbazis.SelectedIndexChanged += new System.EventHandler(this.cbAdatbazis_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Az adatbázis ürítése:";
            // 
            // bMentesUrites
            // 
            this.bMentesUrites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bMentesUrites.Location = new System.Drawing.Point(10, 289);
            this.bMentesUrites.Name = "bMentesUrites";
            this.bMentesUrites.Size = new System.Drawing.Size(103, 23);
            this.bMentesUrites.TabIndex = 6;
            this.bMentesUrites.Text = "Végrehajt";
            this.bMentesUrites.UseVisualStyleBackColor = true;
            this.bMentesUrites.Click += new System.EventHandler(this.button2_Click);
            // 
            // cBoxMentes
            // 
            this.cBoxMentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxMentes.AutoSize = true;
            this.cBoxMentes.Location = new System.Drawing.Point(9, 266);
            this.cBoxMentes.Name = "cBoxMentes";
            this.cBoxMentes.Size = new System.Drawing.Size(74, 17);
            this.cBoxMentes.TabIndex = 5;
            this.cBoxMentes.Text = "Mentéssel";
            this.cBoxMentes.UseVisualStyleBackColor = true;
            // 
            // UI3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 381);
            this.Controls.Add(this.pAdatbazis);
            this.Controls.Add(this.pStat);
            this.Controls.Add(this.pTermek);
            this.Controls.Add(this.pFelhasz);
            this.Controls.Add(this.lIdo);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.bBezár);
            this.Controls.Add(this.cbTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI3";
            this.Text = "UI3";
            this.Load += new System.EventHandler(this.UI3_Load);
            this.pTermek.ResumeLayout(false);
            this.gbMezokTermek.ResumeLayout(false);
            this.gbMezokTermek.PerformLayout();
            this.gbMuvTermek.ResumeLayout(false);
            this.gbMuvTermek.PerformLayout();
            this.pFelhasz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelhasznalok)).EndInit();
            this.gbMezokFelhasz.ResumeLayout(false);
            this.gbMezokFelhasz.PerformLayout();
            this.gbMuvFelhasz.ResumeLayout(false);
            this.gbMuvFelhasz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pStat.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).EndInit();
            this.pAdatbazis.ResumeLayout(false);
            this.pAdatbazis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.Panel pTermek;
        private System.Windows.Forms.GroupBox gbMuvTermek;
        private System.Windows.Forms.RadioButton rbTorol1;
        private System.Windows.Forms.RadioButton rbUj1;
        private System.Windows.Forms.RadioButton rbSzerk1;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.GroupBox gbMezokTermek;
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
        private System.Windows.Forms.GroupBox gbMezokFelhasz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.GroupBox gbMuvFelhasz;
        private System.Windows.Forms.RadioButton rbTorol2;
        private System.Windows.Forms.RadioButton rbUj2;
        private System.Windows.Forms.RadioButton rbSzerk2;
        private System.Windows.Forms.TextBox tbFelhsznev;
        private System.Windows.Forms.DataGridView dgvFelhasznalok;
        private System.Windows.Forms.ComboBox tbUI;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button bBezár;
        private System.Windows.Forms.Panel pStat;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.DataGridView dgvStat;
        private System.Windows.Forms.Button bFrissit;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.RadioButton rbFoly;
        private System.Windows.Forms.RadioButton rbKesz;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rbRend;
        private System.Windows.Forms.RadioButton rbTerm;
        private System.Windows.Forms.Label lTest;
        private System.Windows.Forms.Label lBevetel;
        private System.Windows.Forms.Label lOsszesTetel;
        private System.Windows.Forms.Label lOsszesRendeles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Timer tIdo;
        private System.Windows.Forms.Label lIdo;
        private System.Windows.Forms.Panel pAdatbazis;
        private System.Windows.Forms.DataGridView dgvDT;
        private System.Windows.Forms.ComboBox cbAdatbazis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bMentesUrites;
        private System.Windows.Forms.CheckBox cBoxMentes;
    }
}