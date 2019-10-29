namespace testDesign
{
    partial class UI1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bKilep = new System.Windows.Forms.Button();
            this.labelIdo = new System.Windows.Forms.Label();
            this.tIdo = new System.Windows.Forms.Timer(this.components);
            this.labelDatum = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bElfogyott = new System.Windows.Forms.Button();
            this.bMegjegyzes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOsszeg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bLead = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.lbRendelesLista = new System.Windows.Forms.ListBox();
            this.dgvTermékek = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCsoportok = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLezar = new System.Windows.Forms.Button();
            this.dgvTetelek = new System.Windows.Forms.DataGridView();
            this.dgvRendelesek = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bKesz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermékek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsoportok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTetelek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendelesek)).BeginInit();
            this.SuspendLayout();
            // 
            // bKilep
            // 
            this.bKilep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bKilep.BackColor = System.Drawing.Color.Red;
            this.bKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bKilep.Location = new System.Drawing.Point(796, 12);
            this.bKilep.Name = "bKilep";
            this.bKilep.Size = new System.Drawing.Size(50, 50);
            this.bKilep.TabIndex = 1;
            this.bKilep.Text = "X";
            this.bKilep.UseVisualStyleBackColor = false;
            this.bKilep.Click += new System.EventHandler(this.BKilep_Click);
            // 
            // labelIdo
            // 
            this.labelIdo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIdo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdo.ForeColor = System.Drawing.Color.Yellow;
            this.labelIdo.Location = new System.Drawing.Point(9, 17);
            this.labelIdo.Margin = new System.Windows.Forms.Padding(0);
            this.labelIdo.Name = "labelIdo";
            this.labelIdo.Padding = new System.Windows.Forms.Padding(7, 5, 0, 0);
            this.labelIdo.Size = new System.Drawing.Size(114, 38);
            this.labelIdo.TabIndex = 4;
            this.labelIdo.Text = "00:00:00";
            this.labelIdo.UseCompatibleTextRendering = true;
            // 
            // tIdo
            // 
            this.tIdo.Interval = 1000;
            this.tIdo.Tick += new System.EventHandler(this.TIdo_Tick);
            // 
            // labelDatum
            // 
            this.labelDatum.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatum.Location = new System.Drawing.Point(126, 15);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(111, 38);
            this.labelDatum.TabIndex = 5;
            this.labelDatum.Text = "label1";
            this.labelDatum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(9, 68);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bElfogyott);
            this.splitContainer1.Panel1.Controls.Add(this.bMegjegyzes);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.bLead);
            this.splitContainer1.Panel1.Controls.Add(this.bMinus);
            this.splitContainer1.Panel1.Controls.Add(this.bPlus);
            this.splitContainer1.Panel1.Controls.Add(this.lbRendelesLista);
            this.splitContainer1.Panel1.Controls.Add(this.dgvTermékek);
            this.splitContainer1.Panel1.Controls.Add(this.dgvCsoportok);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bKesz);
            this.splitContainer1.Panel2.Controls.Add(this.bLezar);
            this.splitContainer1.Panel2.Controls.Add(this.dgvTetelek);
            this.splitContainer1.Panel2.Controls.Add(this.dgvRendelesek);
            this.splitContainer1.Size = new System.Drawing.Size(837, 449);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 6;
            // 
            // bElfogyott
            // 
            this.bElfogyott.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bElfogyott.BackColor = System.Drawing.Color.White;
            this.bElfogyott.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bElfogyott.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bElfogyott.Location = new System.Drawing.Point(784, 6);
            this.bElfogyott.Name = "bElfogyott";
            this.bElfogyott.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bElfogyott.Size = new System.Drawing.Size(48, 45);
            this.bElfogyott.TabIndex = 15;
            this.bElfogyott.Text = "R";
            this.bElfogyott.UseVisualStyleBackColor = false;
            // 
            // bMegjegyzes
            // 
            this.bMegjegyzes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMegjegyzes.BackColor = System.Drawing.Color.White;
            this.bMegjegyzes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMegjegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMegjegyzes.Location = new System.Drawing.Point(563, 6);
            this.bMegjegyzes.Name = "bMegjegyzes";
            this.bMegjegyzes.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bMegjegyzes.Size = new System.Drawing.Size(48, 45);
            this.bMegjegyzes.TabIndex = 14;
            this.bMegjegyzes.Text = "M";
            this.bMegjegyzes.UseVisualStyleBackColor = false;
            this.bMegjegyzes.Click += new System.EventHandler(this.BMegjegyzes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelOsszeg);
            this.groupBox1.Location = new System.Drawing.Point(599, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 41);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // labelOsszeg
            // 
            this.labelOsszeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOsszeg.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsszeg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOsszeg.Location = new System.Drawing.Point(6, 10);
            this.labelOsszeg.Name = "labelOsszeg";
            this.labelOsszeg.Size = new System.Drawing.Size(150, 24);
            this.labelOsszeg.TabIndex = 10;
            this.labelOsszeg.Text = "0 Ft";
            this.labelOsszeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(509, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fizetendő: ";
            // 
            // bLead
            // 
            this.bLead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bLead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLead.Location = new System.Drawing.Point(784, 235);
            this.bLead.Name = "bLead";
            this.bLead.Size = new System.Drawing.Size(48, 45);
            this.bLead.TabIndex = 12;
            this.bLead.Text = "V";
            this.bLead.UseVisualStyleBackColor = false;
            this.bLead.Click += new System.EventHandler(this.BLead_Click);
            // 
            // bMinus
            // 
            this.bMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMinus.Location = new System.Drawing.Point(730, 6);
            this.bMinus.Name = "bMinus";
            this.bMinus.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bMinus.Size = new System.Drawing.Size(48, 45);
            this.bMinus.TabIndex = 11;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = false;
            this.bMinus.Click += new System.EventHandler(this.BMinus_Click);
            // 
            // bPlus
            // 
            this.bPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlus.Location = new System.Drawing.Point(509, 6);
            this.bPlus.Name = "bPlus";
            this.bPlus.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bPlus.Size = new System.Drawing.Size(48, 45);
            this.bPlus.TabIndex = 8;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = false;
            this.bPlus.Click += new System.EventHandler(this.BPlus_Click);
            // 
            // lbRendelesLista
            // 
            this.lbRendelesLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRendelesLista.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRendelesLista.FormattingEnabled = true;
            this.lbRendelesLista.ItemHeight = 21;
            this.lbRendelesLista.Location = new System.Drawing.Point(509, 57);
            this.lbRendelesLista.Name = "lbRendelesLista";
            this.lbRendelesLista.Size = new System.Drawing.Size(323, 172);
            this.lbRendelesLista.TabIndex = 7;
            // 
            // dgvTermékek
            // 
            this.dgvTermékek.AllowUserToAddRows = false;
            this.dgvTermékek.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTermékek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTermékek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTermékek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermékek.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvTermékek.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTermékek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermékek.ColumnHeadersVisible = false;
            this.dgvTermékek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTermékek.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTermékek.Location = new System.Drawing.Point(289, 3);
            this.dgvTermékek.Name = "dgvTermékek";
            this.dgvTermékek.ReadOnly = true;
            this.dgvTermékek.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvTermékek.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTermékek.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvTermékek.RowTemplate.Height = 36;
            this.dgvTermékek.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTermékek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTermékek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermékek.Size = new System.Drawing.Size(214, 278);
            this.dgvTermékek.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 76.14214F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Státusz";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvCsoportok
            // 
            this.dgvCsoportok.AllowUserToAddRows = false;
            this.dgvCsoportok.AllowUserToDeleteRows = false;
            this.dgvCsoportok.AllowUserToResizeColumns = false;
            this.dgvCsoportok.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvCsoportok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCsoportok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCsoportok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCsoportok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCsoportok.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCsoportok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCsoportok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCsoportok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCsoportok.ColumnHeadersVisible = false;
            this.dgvCsoportok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCsoportok.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCsoportok.Location = new System.Drawing.Point(3, 3);
            this.dgvCsoportok.MultiSelect = false;
            this.dgvCsoportok.Name = "dgvCsoportok";
            this.dgvCsoportok.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCsoportok.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCsoportok.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvCsoportok.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCsoportok.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvCsoportok.RowTemplate.Height = 36;
            this.dgvCsoportok.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCsoportok.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCsoportok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCsoportok.Size = new System.Drawing.Size(280, 278);
            this.dgvCsoportok.TabIndex = 5;
            this.dgvCsoportok.SelectionChanged += new System.EventHandler(this.DgvCsoportok_SelectionChanged);
            // 
            // col1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = null;
            this.col1.DefaultCellStyle = dataGridViewCellStyle6;
            this.col1.FillWeight = 76.14214F;
            this.col1.HeaderText = "Státusz";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // bLezar
            // 
            this.bLezar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bLezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bLezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLezar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLezar.Location = new System.Drawing.Point(784, 54);
            this.bLezar.Name = "bLezar";
            this.bLezar.Size = new System.Drawing.Size(48, 100);
            this.bLezar.TabIndex = 16;
            this.bLezar.Text = "L\r\nE\r\nZ\r\nÁ\r\nR";
            this.bLezar.UseVisualStyleBackColor = false;
            this.bLezar.Click += new System.EventHandler(this.BLezar_Click);
            // 
            // dgvTetelek
            // 
            this.dgvTetelek.AllowUserToAddRows = false;
            this.dgvTetelek.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvTetelek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTetelek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTetelek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTetelek.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvTetelek.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTetelek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTetelek.ColumnHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTetelek.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTetelek.Location = new System.Drawing.Point(396, 3);
            this.dgvTetelek.Name = "dgvTetelek";
            this.dgvTetelek.ReadOnly = true;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvTetelek.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTetelek.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvTetelek.RowTemplate.Height = 36;
            this.dgvTetelek.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTetelek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTetelek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTetelek.Size = new System.Drawing.Size(382, 151);
            this.dgvTetelek.TabIndex = 15;
            // 
            // dgvRendelesek
            // 
            this.dgvRendelesek.AllowUserToAddRows = false;
            this.dgvRendelesek.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgvRendelesek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRendelesek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRendelesek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRendelesek.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvRendelesek.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRendelesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendelesek.ColumnHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRendelesek.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRendelesek.Location = new System.Drawing.Point(3, 3);
            this.dgvRendelesek.Name = "dgvRendelesek";
            this.dgvRendelesek.ReadOnly = true;
            this.dgvRendelesek.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.dgvRendelesek.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRendelesek.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvRendelesek.RowTemplate.Height = 36;
            this.dgvRendelesek.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRendelesek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRendelesek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRendelesek.Size = new System.Drawing.Size(387, 151);
            this.dgvRendelesek.TabIndex = 14;
            this.dgvRendelesek.SelectionChanged += new System.EventHandler(this.DgvRendelesek_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Termék csoportok";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(296, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Termék";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(516, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rendelés leadás";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(479, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ár";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(10, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Leadott rendelések";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(407, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Rendelés tételek";
            // 
            // bKesz
            // 
            this.bKesz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bKesz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bKesz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bKesz.Location = new System.Drawing.Point(784, 3);
            this.bKesz.Name = "bKesz";
            this.bKesz.Size = new System.Drawing.Size(48, 45);
            this.bKesz.TabIndex = 16;
            this.bKesz.Text = "✓";
            this.bKesz.UseVisualStyleBackColor = false;
            this.bKesz.Click += new System.EventHandler(this.BKesz_Click);
            // 
            // UI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 529);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelIdo);
            this.Controls.Add(this.bKilep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI1";
            this.Text = "UI1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UI1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermékek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsoportok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTetelek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendelesek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bKilep;
        private System.Windows.Forms.Label labelIdo;
        private System.Windows.Forms.Timer tIdo;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCsoportok;
        private System.Windows.Forms.DataGridView dgvTermékek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ListBox lbRendelesLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bLead;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.DataGridView dgvTetelek;
        private System.Windows.Forms.DataGridView dgvRendelesek;
        private System.Windows.Forms.Button bLezar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelOsszeg;
        private System.Windows.Forms.Button bElfogyott;
        private System.Windows.Forms.Button bMegjegyzes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.Button bKesz;
    }
}