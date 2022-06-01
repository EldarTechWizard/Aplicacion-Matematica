namespace Aplicacion_Matematica
{
    partial class DPoisson
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panek = new System.Windows.Forms.Panel();
            this.textVac2 = new System.Windows.Forms.Label();
            this.textVac = new System.Windows.Forms.Label();
            this.textOcu = new System.Windows.Forms.TextBox();
            this.textLambda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textProb = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textVarianza = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDesv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textMedia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Panek.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribucion poisson";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "(λ) Lambda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "(x) Numero de ocurrencia:";
            // 
            // Panek
            // 
            this.Panek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Panek.Controls.Add(this.textVac2);
            this.Panek.Controls.Add(this.textVac);
            this.Panek.Controls.Add(this.textOcu);
            this.Panek.Controls.Add(this.textLambda);
            this.Panek.Controls.Add(this.label4);
            this.Panek.Controls.Add(this.label2);
            this.Panek.Controls.Add(this.button1);
            this.Panek.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panek.Location = new System.Drawing.Point(79, 162);
            this.Panek.Name = "Panek";
            this.Panek.Size = new System.Drawing.Size(337, 240);
            this.Panek.TabIndex = 2;
            // 
            // textVac2
            // 
            this.textVac2.AutoSize = true;
            this.textVac2.Font = new System.Drawing.Font("Lato", 8F);
            this.textVac2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textVac2.Location = new System.Drawing.Point(38, 151);
            this.textVac2.Margin = new System.Windows.Forms.Padding(0);
            this.textVac2.Name = "textVac2";
            this.textVac2.Size = new System.Drawing.Size(240, 13);
            this.textVac2.TabIndex = 7;
            this.textVac2.Text = "* Ingrese el Numero de ocurrencia para continuar";
            this.textVac2.Visible = false;
            // 
            // textVac
            // 
            this.textVac.AutoSize = true;
            this.textVac.Font = new System.Drawing.Font("Lato", 8F);
            this.textVac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textVac.Location = new System.Drawing.Point(38, 72);
            this.textVac.Margin = new System.Windows.Forms.Padding(0);
            this.textVac.Name = "textVac";
            this.textVac.Size = new System.Drawing.Size(162, 13);
            this.textVac.TabIndex = 6;
            this.textVac.Text = "* Ingrese Lambda para continuar";
            this.textVac.Visible = false;
            // 
            // textOcu
            // 
            this.textOcu.Location = new System.Drawing.Point(36, 122);
            this.textOcu.Name = "textOcu";
            this.textOcu.Size = new System.Drawing.Size(259, 25);
            this.textOcu.TabIndex = 5;
            // 
            // textLambda
            // 
            this.textLambda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLambda.Location = new System.Drawing.Point(36, 44);
            this.textLambda.Name = "textLambda";
            this.textLambda.Size = new System.Drawing.Size(259, 25);
            this.textLambda.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "(%) Probabilidad:";
            // 
            // textProb
            // 
            this.textProb.BackColor = System.Drawing.Color.White;
            this.textProb.Location = new System.Drawing.Point(28, 49);
            this.textProb.Name = "textProb";
            this.textProb.Size = new System.Drawing.Size(283, 23);
            this.textProb.TabIndex = 1;
            this.textProb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textVarianza);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textProb);
            this.panel3.Controls.Add(this.textDesv);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textMedia);
            this.panel3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(554, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 315);
            this.panel3.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lato", 9F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(35, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "2";
            // 
            // textVarianza
            // 
            this.textVarianza.BackColor = System.Drawing.Color.White;
            this.textVarianza.Location = new System.Drawing.Point(27, 259);
            this.textVarianza.Name = "textVarianza";
            this.textVarianza.Size = new System.Drawing.Size(284, 23);
            this.textVarianza.TabIndex = 6;
            this.textVarianza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "(σ  ) Varianza:";
            // 
            // textDesv
            // 
            this.textDesv.BackColor = System.Drawing.Color.White;
            this.textDesv.Location = new System.Drawing.Point(27, 188);
            this.textDesv.Name = "textDesv";
            this.textDesv.Size = new System.Drawing.Size(284, 23);
            this.textDesv.TabIndex = 4;
            this.textDesv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "(σ) Desviacion estándar:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "(μ) Media:";
            // 
            // textMedia
            // 
            this.textMedia.BackColor = System.Drawing.Color.White;
            this.textMedia.Location = new System.Drawing.Point(27, 117);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(284, 23);
            this.textMedia.TabIndex = 1;
            this.textMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 64);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(79, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 35);
            this.panel2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Lato", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 35);
            this.label9.TabIndex = 1;
            this.label9.Text = "Datos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Lato", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(554, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 35);
            this.panel4.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Lato", 11.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Resultados";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 623);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DPoisson";
            this.Text = "Dbinomial";
            this.Panek.ResumeLayout(false);
            this.Panek.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panek;
        private System.Windows.Forms.TextBox textOcu;
        private System.Windows.Forms.TextBox textLambda;
        private System.Windows.Forms.Label textProb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label textDesv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label textVarianza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label textVac;
        private System.Windows.Forms.Label textVac2;
    }
}