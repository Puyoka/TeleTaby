namespace testDesign
{
    partial class belepes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(belepes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKilep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFelhaszn = new System.Windows.Forms.ComboBox();
            this.textBoxJelszo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBejelentkezes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonKilep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 109);
            this.panel1.TabIndex = 0;
            // 
            // buttonKilep
            // 
            this.buttonKilep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKilep.BackColor = System.Drawing.Color.Red;
            this.buttonKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKilep.Location = new System.Drawing.Point(272, 12);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(50, 50);
            this.buttonKilep.TabIndex = 3;
            this.buttonKilep.Text = "X";
            this.buttonKilep.UseVisualStyleBackColor = false;
            this.buttonKilep.Click += new System.EventHandler(this.buttonKilep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(80, -20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 151);
            this.label1.TabIndex = 0;
            this.label1.Text = "BELÉPÉS";
            // 
            // comboBoxFelhaszn
            // 
            this.comboBoxFelhaszn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxFelhaszn.Location = new System.Drawing.Point(76, 158);
            this.comboBoxFelhaszn.Name = "comboBoxFelhaszn";
            this.comboBoxFelhaszn.Size = new System.Drawing.Size(184, 21);
            this.comboBoxFelhaszn.TabIndex = 4;
            this.comboBoxFelhaszn.Enter += new System.EventHandler(this.ComboBoxFelhaszn_Enter);
            // 
            // textBoxJelszo
            // 
            this.textBoxJelszo.Location = new System.Drawing.Point(76, 233);
            this.textBoxJelszo.Name = "textBoxJelszo";
            this.textBoxJelszo.PasswordChar = '*';
            this.textBoxJelszo.Size = new System.Drawing.Size(184, 20);
            this.textBoxJelszo.TabIndex = 5;
            this.textBoxJelszo.Enter += new System.EventHandler(this.TextBoxJelszo_Enter);
            this.textBoxJelszo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxJelszo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(72, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Felhasználónév";
            // 
            // buttonBejelentkezes
            // 
            this.buttonBejelentkezes.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBejelentkezes.Location = new System.Drawing.Point(76, 294);
            this.buttonBejelentkezes.Name = "buttonBejelentkezes";
            this.buttonBejelentkezes.Size = new System.Drawing.Size(184, 46);
            this.buttonBejelentkezes.TabIndex = 8;
            this.buttonBejelentkezes.Text = "Bejelentkezés";
            this.buttonBejelentkezes.UseVisualStyleBackColor = true;
            this.buttonBejelentkezes.Click += new System.EventHandler(this.buttonBejelentkezes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(72, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jelszó";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b9.Location = new System.Drawing.Point(467, 127);
            this.b9.Margin = new System.Windows.Forms.Padding(0);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(55, 55);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b8.Location = new System.Drawing.Point(405, 127);
            this.b8.Margin = new System.Windows.Forms.Padding(0);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(55, 55);
            this.b8.TabIndex = 11;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b7.Location = new System.Drawing.Point(343, 127);
            this.b7.Margin = new System.Windows.Forms.Padding(0);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(55, 55);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b0.Location = new System.Drawing.Point(405, 312);
            this.b0.Margin = new System.Windows.Forms.Padding(0);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(55, 55);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b6.Location = new System.Drawing.Point(467, 188);
            this.b6.Margin = new System.Windows.Forms.Padding(0);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(55, 55);
            this.b6.TabIndex = 14;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b5.Location = new System.Drawing.Point(405, 189);
            this.b5.Margin = new System.Windows.Forms.Padding(0);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(55, 55);
            this.b5.TabIndex = 15;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(343, 188);
            this.b4.Margin = new System.Windows.Forms.Padding(0);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(55, 55);
            this.b4.TabIndex = 16;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(467, 250);
            this.b3.Margin = new System.Windows.Forms.Padding(0);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(55, 55);
            this.b3.TabIndex = 17;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(405, 250);
            this.b2.Margin = new System.Windows.Forms.Padding(0);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(55, 55);
            this.b2.TabIndex = 18;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(343, 250);
            this.b1.Margin = new System.Windows.Forms.Padding(0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(55, 55);
            this.b1.TabIndex = 19;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // bEnter
            // 
            this.bEnter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bEnter.Location = new System.Drawing.Point(467, 312);
            this.bEnter.Margin = new System.Windows.Forms.Padding(5);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(55, 55);
            this.bEnter.TabIndex = 20;
            this.bEnter.Text = "ENT";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // bDel
            // 
            this.bDel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDel.Location = new System.Drawing.Point(343, 312);
            this.bDel.Margin = new System.Windows.Forms.Padding(0);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(55, 55);
            this.bDel.TabIndex = 21;
            this.bDel.Text = "←";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 386);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBejelentkezes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxJelszo);
            this.Controls.Add(this.comboBoxFelhaszn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "belepes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Belepes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Belepes_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKilep;
        private System.Windows.Forms.ComboBox comboBoxFelhaszn;
        private System.Windows.Forms.TextBox textBoxJelszo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBejelentkezes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
    }
}

