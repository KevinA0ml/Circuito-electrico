namespace circuito_electrico
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Vtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Ctotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Rtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.r6 = new System.Windows.Forms.TextBox();
            this.r7 = new System.Windows.Forms.TextBox();
            this.r10 = new System.Windows.Forms.TextBox();
            this.r8 = new System.Windows.Forms.TextBox();
            this.r9 = new System.Windows.Forms.TextBox();
            this.r5 = new System.Windows.Forms.TextBox();
            this.r1 = new System.Windows.Forms.TextBox();
            this.r2 = new System.Windows.Forms.TextBox();
            this.bateria = new System.Windows.Forms.TextBox();
            this.r4 = new System.Windows.Forms.TextBox();
            this.r3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circuitos electronicos";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-35, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 643);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(41, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(41, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reiniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(41, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar tabla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(272, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 667);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Controls.Add(this.Vtotal);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Ctotal);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Rtotal);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.r6);
            this.tabPage1.Controls.Add(this.r7);
            this.tabPage1.Controls.Add(this.r10);
            this.tabPage1.Controls.Add(this.r8);
            this.tabPage1.Controls.Add(this.r9);
            this.tabPage1.Controls.Add(this.r5);
            this.tabPage1.Controls.Add(this.r1);
            this.tabPage1.Controls.Add(this.r2);
            this.tabPage1.Controls.Add(this.bateria);
            this.tabPage1.Controls.Add(this.r4);
            this.tabPage1.Controls.Add(this.r3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Circuito";
            // 
            // Vtotal
            // 
            this.Vtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vtotal.ForeColor = System.Drawing.Color.Maroon;
            this.Vtotal.Location = new System.Drawing.Point(426, 554);
            this.Vtotal.Name = "Vtotal";
            this.Vtotal.Size = new System.Drawing.Size(98, 26);
            this.Vtotal.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(279, 554);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "voltaje total:";
            // 
            // Ctotal
            // 
            this.Ctotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ctotal.ForeColor = System.Drawing.Color.Maroon;
            this.Ctotal.Location = new System.Drawing.Point(717, 510);
            this.Ctotal.Name = "Ctotal";
            this.Ctotal.Size = new System.Drawing.Size(98, 26);
            this.Ctotal.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(527, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Corriente total:";
            // 
            // Rtotal
            // 
            this.Rtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtotal.ForeColor = System.Drawing.Color.Maroon;
            this.Rtotal.Location = new System.Drawing.Point(281, 510);
            this.Rtotal.Name = "Rtotal";
            this.Rtotal.Size = new System.Drawing.Size(98, 26);
            this.Rtotal.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(91, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Resistencia total:";
            // 
            // r6
            // 
            this.r6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r6.ForeColor = System.Drawing.Color.Maroon;
            this.r6.Location = new System.Drawing.Point(478, 123);
            this.r6.Name = "r6";
            this.r6.Size = new System.Drawing.Size(98, 26);
            this.r6.TabIndex = 49;
            // 
            // r7
            // 
            this.r7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r7.ForeColor = System.Drawing.Color.Maroon;
            this.r7.Location = new System.Drawing.Point(622, 63);
            this.r7.Name = "r7";
            this.r7.Size = new System.Drawing.Size(98, 26);
            this.r7.TabIndex = 48;
            // 
            // r10
            // 
            this.r10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r10.ForeColor = System.Drawing.Color.Maroon;
            this.r10.Location = new System.Drawing.Point(786, 289);
            this.r10.Name = "r10";
            this.r10.Size = new System.Drawing.Size(98, 26);
            this.r10.TabIndex = 47;
            // 
            // r8
            // 
            this.r8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r8.ForeColor = System.Drawing.Color.Maroon;
            this.r8.Location = new System.Drawing.Point(639, 165);
            this.r8.Name = "r8";
            this.r8.Size = new System.Drawing.Size(98, 26);
            this.r8.TabIndex = 46;
            // 
            // r9
            // 
            this.r9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r9.ForeColor = System.Drawing.Color.Maroon;
            this.r9.Location = new System.Drawing.Point(558, 409);
            this.r9.Name = "r9";
            this.r9.Size = new System.Drawing.Size(98, 26);
            this.r9.TabIndex = 45;
            // 
            // r5
            // 
            this.r5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r5.ForeColor = System.Drawing.Color.Maroon;
            this.r5.Location = new System.Drawing.Point(446, 211);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(98, 26);
            this.r5.TabIndex = 43;
            // 
            // r1
            // 
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.ForeColor = System.Drawing.Color.Maroon;
            this.r1.Location = new System.Drawing.Point(226, 25);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(98, 26);
            this.r1.TabIndex = 42;
            // 
            // r2
            // 
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.ForeColor = System.Drawing.Color.Maroon;
            this.r2.Location = new System.Drawing.Point(243, 165);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(98, 26);
            this.r2.TabIndex = 41;
            // 
            // bateria
            // 
            this.bateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bateria.ForeColor = System.Drawing.Color.Maroon;
            this.bateria.Location = new System.Drawing.Point(56, 177);
            this.bateria.Name = "bateria";
            this.bateria.Size = new System.Drawing.Size(98, 26);
            this.bateria.TabIndex = 40;
            // 
            // r4
            // 
            this.r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r4.ForeColor = System.Drawing.Color.Maroon;
            this.r4.Location = new System.Drawing.Point(264, 453);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(98, 26);
            this.r4.TabIndex = 39;
            // 
            // r3
            // 
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3.ForeColor = System.Drawing.Color.Maroon;
            this.r3.Location = new System.Drawing.Point(264, 302);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(98, 26);
            this.r3.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dgvdatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla de valores";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3.Location = new System.Drawing.Point(655, 315);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 26);
            this.textBox3.TabIndex = 45;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(655, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 26);
            this.textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(655, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 26);
            this.textBox1.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(521, 259);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(350, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Resistencia equivalente de R8 y R10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(521, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Resistencia equivalente de R3 y R4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(521, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(339, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Resistencia equivalente de R1 y R2";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(119, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 46);
            this.button5.TabIndex = 12;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvdatos
            // 
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(27, 22);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            this.dgvdatos.Size = new System.Drawing.Size(457, 437);
            this.dgvdatos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1217, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Proyecto Final Fisica II";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Vtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Ctotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Rtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox r6;
        private System.Windows.Forms.TextBox r7;
        private System.Windows.Forms.TextBox r10;
        private System.Windows.Forms.TextBox r8;
        private System.Windows.Forms.TextBox r9;
        private System.Windows.Forms.TextBox r5;
        private System.Windows.Forms.TextBox r1;
        private System.Windows.Forms.TextBox r2;
        private System.Windows.Forms.TextBox bateria;
        private System.Windows.Forms.TextBox r4;
        private System.Windows.Forms.TextBox r3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

