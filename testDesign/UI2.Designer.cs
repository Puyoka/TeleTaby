namespace testDesign
{
    partial class UI2
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
            this.buttonKilep = new System.Windows.Forms.Button();
            this.timerIdo = new System.Windows.Forms.Timer(this.components);
            this.labelIdo = new System.Windows.Forms.Label();
            this.dgvRendelesek = new System.Windows.Forms.DataGridView();
            this.labelNap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonElozmeny_Rendeles = new System.Windows.Forms.Button();
            this.buttonKesz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerLekerdez = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendelesek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKilep
            // 
            this.buttonKilep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKilep.BackColor = System.Drawing.Color.Red;
            this.buttonKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKilep.Location = new System.Drawing.Point(1044, 12);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(50, 50);
            this.buttonKilep.TabIndex = 2;
            this.buttonKilep.Text = "X";
            this.buttonKilep.UseVisualStyleBackColor = false;
            this.buttonKilep.Click += new System.EventHandler(this.ButtonKilep_Click);
            // 
            // timerIdo
            // 
            this.timerIdo.Interval = 1000;
            this.timerIdo.Tick += new System.EventHandler(this.TimerIdo_Tick);
            // 
            // labelIdo
            // 
            this.labelIdo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIdo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdo.ForeColor = System.Drawing.Color.Yellow;
            this.labelIdo.Location = new System.Drawing.Point(12, 12);
            this.labelIdo.Margin = new System.Windows.Forms.Padding(0);
            this.labelIdo.Name = "labelIdo";
            this.labelIdo.Padding = new System.Windows.Forms.Padding(7);
            this.labelIdo.Size = new System.Drawing.Size(114, 38);
            this.labelIdo.TabIndex = 3;
            this.labelIdo.Text = "00:00:00";
            this.labelIdo.UseCompatibleTextRendering = true;
            // 
            // dgvRendelesek
            // 
            this.dgvRendelesek.AllowUserToAddRows = false;
            this.dgvRendelesek.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRendelesek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRendelesek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRendelesek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRendelesek.BackgroundColor = System.Drawing.Color.White;
            this.dgvRendelesek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRendelesek.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRendelesek.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRendelesek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRendelesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendelesek.Location = new System.Drawing.Point(6, 19);
            this.dgvRendelesek.MultiSelect = false;
            this.dgvRendelesek.Name = "dgvRendelesek";
            this.dgvRendelesek.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRendelesek.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvRendelesek.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRendelesek.RowTemplate.Height = 36;
            this.dgvRendelesek.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRendelesek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRendelesek.Size = new System.Drawing.Size(1083, 351);
            this.dgvRendelesek.TabIndex = 4;
            this.dgvRendelesek.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewRendelesek_RowPostPaint);
            this.dgvRendelesek.SelectionChanged += new System.EventHandler(this.DataGridViewRendelesek_SelectionChanged);
            // 
            // labelNap
            // 
            this.labelNap.AutoSize = true;
            this.labelNap.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNap.Location = new System.Drawing.Point(141, 20);
            this.labelNap.Name = "labelNap";
            this.labelNap.Size = new System.Drawing.Size(0, 21);
            this.labelNap.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonElozmeny_Rendeles);
            this.groupBox1.Controls.Add(this.buttonKesz);
            this.groupBox1.Controls.Add(this.dgvRendelesek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(7, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 422);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // buttonElozmeny_Rendeles
            // 
            this.buttonElozmeny_Rendeles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonElozmeny_Rendeles.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonElozmeny_Rendeles.Location = new System.Drawing.Point(4, 376);
            this.buttonElozmeny_Rendeles.Name = "buttonElozmeny_Rendeles";
            this.buttonElozmeny_Rendeles.Size = new System.Drawing.Size(40, 40);
            this.buttonElozmeny_Rendeles.TabIndex = 6;
            this.buttonElozmeny_Rendeles.Text = "<";
            this.buttonElozmeny_Rendeles.UseVisualStyleBackColor = true;
            this.buttonElozmeny_Rendeles.Click += new System.EventHandler(this.ButtonElozmeny_rendeles_Click);
            // 
            // buttonKesz
            // 
            this.buttonKesz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKesz.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKesz.Location = new System.Drawing.Point(948, 376);
            this.buttonKesz.Name = "buttonKesz";
            this.buttonKesz.Size = new System.Drawing.Size(139, 40);
            this.buttonKesz.TabIndex = 5;
            this.buttonKesz.Text = "Kész";
            this.buttonKesz.UseVisualStyleBackColor = true;
            this.buttonKesz.Click += new System.EventHandler(this.ButtonKesz_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1106, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rendelések";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCounter
            // 
            this.labelCounter.BackColor = System.Drawing.Color.Red;
            this.labelCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCounter.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCounter.ForeColor = System.Drawing.Color.Black;
            this.labelCounter.Location = new System.Drawing.Point(12, 59);
            this.labelCounter.Margin = new System.Windows.Forms.Padding(0);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(53, 21);
            this.labelCounter.TabIndex = 7;
            this.labelCounter.Text = "0";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelCounter.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1004, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = " .";
            // 
            // timerLekerdez
            // 
            this.timerLekerdez.Interval = 10000;
            this.timerLekerdez.Tick += new System.EventHandler(this.TimerLekerdez_Tick);
            // 
            // UI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNap);
            this.Controls.Add(this.labelIdo);
            this.Controls.Add(this.buttonKilep);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI2";
            this.Text = "UI2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UI2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendelesek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKilep;
        private System.Windows.Forms.Timer timerIdo;
        private System.Windows.Forms.Label labelIdo;
        private System.Windows.Forms.DataGridView dgvRendelesek;
        private System.Windows.Forms.Label labelNap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonElozmeny_Rendeles;
        private System.Windows.Forms.Button buttonKesz;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerLekerdez;
    }
}