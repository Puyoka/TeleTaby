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
            this.dataGridViewRendelesek = new System.Windows.Forms.DataGridView();
            this.labelNap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonElozmenyek = new System.Windows.Forms.Button();
            this.buttonKesz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonVissza = new System.Windows.Forms.Button();
            this.dataGridViewElozmenyek = new System.Windows.Forms.DataGridView();
            this.labelCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerLekerdez = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendelesek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElozmenyek)).BeginInit();
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
            // dataGridViewRendelesek
            // 
            this.dataGridViewRendelesek.AllowUserToAddRows = false;
            this.dataGridViewRendelesek.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRendelesek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRendelesek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRendelesek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRendelesek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRendelesek.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRendelesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRendelesek.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewRendelesek.Name = "dataGridViewRendelesek";
            this.dataGridViewRendelesek.ReadOnly = true;
            this.dataGridViewRendelesek.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRendelesek.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRendelesek.RowTemplate.Height = 36;
            this.dataGridViewRendelesek.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRendelesek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRendelesek.Size = new System.Drawing.Size(1083, 351);
            this.dataGridViewRendelesek.TabIndex = 4;
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonElozmenyek);
            this.groupBox1.Controls.Add(this.buttonKesz);
            this.groupBox1.Controls.Add(this.dataGridViewRendelesek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(7, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 422);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendelések";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Előzmények";
            // 
            // buttonElozmenyek
            // 
            this.buttonElozmenyek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonElozmenyek.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonElozmenyek.Location = new System.Drawing.Point(4, 376);
            this.buttonElozmenyek.Name = "buttonElozmenyek";
            this.buttonElozmenyek.Size = new System.Drawing.Size(40, 40);
            this.buttonElozmenyek.TabIndex = 6;
            this.buttonElozmenyek.Text = "<";
            this.buttonElozmenyek.UseVisualStyleBackColor = true;
            this.buttonElozmenyek.Click += new System.EventHandler(this.ButtonElozmenyek_Click);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonVissza);
            this.groupBox2.Controls.Add(this.dataGridViewElozmenyek);
            this.groupBox2.Location = new System.Drawing.Point(7, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1093, 422);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Előzmények";
            this.groupBox2.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(50, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rendelések";
            // 
            // buttonVissza
            // 
            this.buttonVissza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVissza.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVissza.Location = new System.Drawing.Point(4, 376);
            this.buttonVissza.Name = "buttonVissza";
            this.buttonVissza.Size = new System.Drawing.Size(40, 40);
            this.buttonVissza.TabIndex = 8;
            this.buttonVissza.Text = ">";
            this.buttonVissza.UseVisualStyleBackColor = true;
            this.buttonVissza.Click += new System.EventHandler(this.ButtonVissza_Click);
            // 
            // dataGridViewElozmenyek
            // 
            this.dataGridViewElozmenyek.AccessibleName = "";
            this.dataGridViewElozmenyek.AllowUserToAddRows = false;
            this.dataGridViewElozmenyek.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewElozmenyek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewElozmenyek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewElozmenyek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewElozmenyek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewElozmenyek.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewElozmenyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElozmenyek.ColumnHeadersVisible = false;
            this.dataGridViewElozmenyek.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewElozmenyek.Name = "dataGridViewElozmenyek";
            this.dataGridViewElozmenyek.ReadOnly = true;
            this.dataGridViewElozmenyek.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewElozmenyek.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewElozmenyek.RowTemplate.Height = 36;
            this.dataGridViewElozmenyek.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewElozmenyek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewElozmenyek.Size = new System.Drawing.Size(1083, 351);
            this.dataGridViewElozmenyek.TabIndex = 5;
            this.dataGridViewElozmenyek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewElozmenyek_CellContentClick);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNap);
            this.Controls.Add(this.labelIdo);
            this.Controls.Add(this.buttonKilep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI2";
            this.Text = "UI2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UI2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendelesek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElozmenyek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKilep;
        private System.Windows.Forms.Timer timerIdo;
        private System.Windows.Forms.Label labelIdo;
        private System.Windows.Forms.DataGridView dataGridViewRendelesek;
        private System.Windows.Forms.Label labelNap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonElozmenyek;
        private System.Windows.Forms.Button buttonKesz;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonVissza;
        private System.Windows.Forms.DataGridView dataGridViewElozmenyek;
        private System.Windows.Forms.Timer timerLekerdez;
    }
}