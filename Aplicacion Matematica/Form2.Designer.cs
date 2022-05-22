namespace Aplicacion_Matematica
{
    partial class Form2
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 13);
            label3.TabIndex = 0;
            label3.Text = "(x) Numero de exitos deseados";
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 579);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.xText);
            this.panel2.Controls.Add(label3);
            this.panel2.Location = new System.Drawing.Point(56, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 233);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar ->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pText
            // 
            this.pText.Location = new System.Drawing.Point(22, 145);
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(172, 20);
            this.pText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "(p) Probabilidad de exito";
            // 
            // nText
            // 
            this.nText.Location = new System.Drawing.Point(22, 97);
            this.nText.Name = "nText";
            this.nText.Size = new System.Drawing.Size(172, 20);
            this.nText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "(n) Numero de veces que se realiza la operacion";
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(22, 30);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(172, 20);
            this.xText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Distribucion binomial";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}