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
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribución normal";
            // 
            // textValor
            // 
            this.textValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textValor.Location = new System.Drawing.Point(15, 36);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(256, 26);
            this.textValor.TabIndex = 1;
            // 
            // textDesvEs
            // 
            this.textDesvEs.Location = new System.Drawing.Point(15, 163);
            this.textDesvEs.Name = "textDesvEs";
            this.textDesvEs.Size = new System.Drawing.Size(255, 26);
            this.textDesvEs.TabIndex = 2;
            // 
            // textMedia
            // 
            this.textMedia.Location = new System.Drawing.Point(15, 101);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(255, 26);
            this.textMedia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Media";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desviación estándar";
            // 
            // aceptarCalc
            // 
            this.aceptarCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.aceptarCalc.FlatAppearance.BorderSize = 0;
            this.aceptarCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarCalc.ForeColor = System.Drawing.Color.White;
            this.aceptarCalc.Location = new System.Drawing.Point(15, 214);
            this.aceptarCalc.Name = "aceptarCalc";
            this.aceptarCalc.Size = new System.Drawing.Size(255, 27);
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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(44, 79);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(292, 268);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.zText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(44, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 88);
            this.panel2.TabIndex = 10;
            // 
            // zText
            // 
            this.zText.BackColor = System.Drawing.Color.White;
            this.zText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zText.Location = new System.Drawing.Point(19, 44);
            this.zText.Name = "zText";
            this.zText.Padding = new System.Windows.Forms.Padding(5);
            this.zText.Size = new System.Drawing.Size(251, 22);
            this.zText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor de Z";
            // 
            // Dnormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dnormal";
            this.Text = "Dnormal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}