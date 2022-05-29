namespace Aplicacion_Matematica
{
    partial class Dnormal
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
            this.textValor = new System.Windows.Forms.TextBox();
            this.textDesvEs = new System.Windows.Forms.TextBox();
            this.textMedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aceptarCalc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textValor
            // 
            this.textValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textValor.ForeColor = System.Drawing.Color.Black;
            this.textValor.Location = new System.Drawing.Point(38, 50);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(256, 27);
            this.textValor.TabIndex = 1;
            // 
            // textDesvEs
            // 
            this.textDesvEs.Location = new System.Drawing.Point(38, 184);
            this.textDesvEs.Name = "textDesvEs";
            this.textDesvEs.Size = new System.Drawing.Size(255, 27);
            this.textDesvEs.TabIndex = 2;
            // 
            // textMedia
            // 
            this.textMedia.Location = new System.Drawing.Point(38, 116);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(255, 27);
            this.textMedia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Media:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desviacion estandar:";
            // 
            // aceptarCalc
            // 
            this.aceptarCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.aceptarCalc.FlatAppearance.BorderSize = 0;
            this.aceptarCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarCalc.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarCalc.ForeColor = System.Drawing.Color.White;
            this.aceptarCalc.Location = new System.Drawing.Point(38, 237);
            this.aceptarCalc.Name = "aceptarCalc";
            this.aceptarCalc.Size = new System.Drawing.Size(255, 35);
            this.aceptarCalc.TabIndex = 7;
            this.aceptarCalc.Text = "Calcular ";
            this.aceptarCalc.UseVisualStyleBackColor = false;
            this.aceptarCalc.Click += new System.EventHandler(this.aceptarCalc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.textValor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.aceptarCalc);
            this.panel1.Controls.Add(this.textMedia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textDesvEs);
            this.panel1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(88, 174);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(337, 300);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.zText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(542, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 109);
            this.panel2.TabIndex = 10;
            // 
            // zText
            // 
            this.zText.BackColor = System.Drawing.Color.White;
            this.zText.Font = new System.Drawing.Font("Lato", 12F);
            this.zText.Location = new System.Drawing.Point(42, 51);
            this.zText.Name = "zText";
            this.zText.Padding = new System.Windows.Forms.Padding(5);
            this.zText.Size = new System.Drawing.Size(255, 22);
            this.zText.TabIndex = 1;
            this.zText.Click += new System.EventHandler(this.zText_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor de Z:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 64);
            this.panel3.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Distribucion normal";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(542, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 35);
            this.panel4.TabIndex = 29;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(88, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 35);
            this.panel5.TabIndex = 28;
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lato", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dnormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 623);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dnormal";
            this.Text = "Dnormal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.TextBox textDesvEs;
        private System.Windows.Forms.TextBox textMedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aceptarCalc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label zText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}