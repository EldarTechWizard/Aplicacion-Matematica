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
            this.textOcu = new System.Windows.Forms.TextBox();
            this.textLambda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textProb = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textVarianza = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDesv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textMedia = new System.Windows.Forms.Label();
            this.Panek.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distribucion poisson";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lambda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de ocurrencias";
            // 
            // Panek
            // 
            this.Panek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Panek.Controls.Add(this.textOcu);
            this.Panek.Controls.Add(this.textLambda);
            this.Panek.Controls.Add(this.label4);
            this.Panek.Controls.Add(this.label2);
            this.Panek.Controls.Add(this.button1);
            this.Panek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panek.Location = new System.Drawing.Point(64, 76);
            this.Panek.Name = "Panek";
            this.Panek.Size = new System.Drawing.Size(337, 204);
            this.Panek.TabIndex = 2;
            // 
            // textOcu
            // 
            this.textOcu.Location = new System.Drawing.Point(36, 95);
            this.textOcu.Name = "textOcu";
            this.textOcu.Size = new System.Drawing.Size(259, 24);
            this.textOcu.TabIndex = 5;
            // 
            // textLambda
            // 
            this.textLambda.Location = new System.Drawing.Point(36, 37);
            this.textLambda.Name = "textLambda";
            this.textLambda.Size = new System.Drawing.Size(259, 24);
            this.textLambda.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Probabilidad";
            // 
            // textProb
            // 
            this.textProb.BackColor = System.Drawing.Color.White;
            this.textProb.Location = new System.Drawing.Point(28, 48);
            this.textProb.Name = "textProb";
            this.textProb.Size = new System.Drawing.Size(310, 23);
            this.textProb.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel3.Controls.Add(this.textVarianza);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textProb);
            this.panel3.Controls.Add(this.textDesv);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textMedia);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(490, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 304);
            this.panel3.TabIndex = 24;
            // 
            // textVarianza
            // 
            this.textVarianza.BackColor = System.Drawing.Color.White;
            this.textVarianza.Location = new System.Drawing.Point(27, 242);
            this.textVarianza.Name = "textVarianza";
            this.textVarianza.Size = new System.Drawing.Size(314, 23);
            this.textVarianza.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Varianza";
            // 
            // textDesv
            // 
            this.textDesv.BackColor = System.Drawing.Color.White;
            this.textDesv.Location = new System.Drawing.Point(27, 181);
            this.textDesv.Name = "textDesv";
            this.textDesv.Size = new System.Drawing.Size(314, 23);
            this.textDesv.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Desviación Estándar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Media";
            // 
            // textMedia
            // 
            this.textMedia.BackColor = System.Drawing.Color.White;
            this.textMedia.Location = new System.Drawing.Point(27, 113);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(311, 23);
            this.textMedia.TabIndex = 1;
            // 
            // DPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panek);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DPoisson";
            this.Text = "Dbinomial";
            this.Panek.ResumeLayout(false);
            this.Panek.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}