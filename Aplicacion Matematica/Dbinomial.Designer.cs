namespace Aplicacion_Matematica
{
    partial class Dbinomial
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
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelProbF = new System.Windows.Forms.Panel();
            this.textProbf = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textDesv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textMedia = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelProbF.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(19, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(215, 18);
            label3.TabIndex = 0;
            label3.Text = "(x) Número de éxitos deseados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 623);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel3.Controls.Add(this.panelProbF);
            this.panel3.Controls.Add(this.textDesv);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textMedia);
            this.panel3.Controls.Add(this.textTitle);
            this.panel3.Location = new System.Drawing.Point(506, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 261);
            this.panel3.TabIndex = 23;
            // 
            // panelProbF
            // 
            this.panelProbF.Controls.Add(this.textProbf);
            this.panelProbF.Controls.Add(this.label10);
            this.panelProbF.Location = new System.Drawing.Point(21, 175);
            this.panelProbF.Name = "panelProbF";
            this.panelProbF.Size = new System.Drawing.Size(331, 63);
            this.panelProbF.TabIndex = 5;
            this.panelProbF.Visible = false;
            // 
            // textProbf
            // 
            this.textProbf.BackColor = System.Drawing.Color.White;
            this.textProbf.Location = new System.Drawing.Point(7, 27);
            this.textProbf.Name = "textProbf";
            this.textProbf.Size = new System.Drawing.Size(314, 23);
            this.textProbf.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Probabilidad de fracaso";
            // 
            // textDesv
            // 
            this.textDesv.BackColor = System.Drawing.Color.White;
            this.textDesv.Location = new System.Drawing.Point(28, 137);
            this.textDesv.Name = "textDesv";
            this.textDesv.Size = new System.Drawing.Size(314, 23);
            this.textDesv.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "(σ) Desviación Estándar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Media";
            // 
            // textMedia
            // 
            this.textMedia.BackColor = System.Drawing.Color.White;
            this.textMedia.Location = new System.Drawing.Point(29, 75);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(314, 23);
            this.textMedia.TabIndex = 1;
            // 
            // textTitle
            // 
            this.textTitle.AutoSize = true;
            this.textTitle.ForeColor = System.Drawing.Color.White;
            this.textTitle.Location = new System.Drawing.Point(26, 20);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(152, 18);
            this.textTitle.TabIndex = 0;
            this.textTitle.Text = "Para población infinita";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.xText);
            this.panel2.Controls.Add(label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(56, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 290);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pText
            // 
            this.pText.Location = new System.Drawing.Point(22, 181);
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(319, 24);
            this.pText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "(p) Probabilidad de éxito";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nText
            // 
            this.nText.Location = new System.Drawing.Point(22, 114);
            this.nText.Name = "nText";
            this.nText.Size = new System.Drawing.Size(319, 24);
            this.nText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "(n) Número de veces que se realiza la operación";
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(22, 44);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(319, 24);
            this.xText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Distribución binomial";
            // 
            // Dbinomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dbinomial";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelProbF.ResumeLayout(false);
            this.panelProbF.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label textMedia;
        private System.Windows.Forms.Label textTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelProbF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label textDesv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textProbf;
    }
}