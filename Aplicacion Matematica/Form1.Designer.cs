namespace Aplicacion_Matematica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Agrandar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Desagrandar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(921, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Cerrar);
            this.flowLayoutPanel2.Controls.Add(this.Agrandar);
            this.flowLayoutPanel2.Controls.Add(this.Desagrandar);
            this.flowLayoutPanel2.Controls.Add(this.Minimizar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(584, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(337, 100);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(259, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agrandar
            // 
            this.Agrandar.Location = new System.Drawing.Point(178, 3);
            this.Agrandar.Name = "Agrandar";
            this.Agrandar.Size = new System.Drawing.Size(75, 23);
            this.Agrandar.TabIndex = 1;
            this.Agrandar.Text = "Agrandar";
            this.Agrandar.UseVisualStyleBackColor = true;
            this.Agrandar.Click += new System.EventHandler(this.Agrandar_click);
            // 
            // Minimizar
            // 
            this.Minimizar.Location = new System.Drawing.Point(6, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(75, 23);
            this.Minimizar.TabIndex = 2;
            this.Minimizar.Text = "Minimizar";
            this.Minimizar.UseVisualStyleBackColor = true;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "GRAFICA";
            // 
            // Desagrandar
            // 
            this.Desagrandar.Location = new System.Drawing.Point(87, 3);
            this.Desagrandar.Name = "Desagrandar";
            this.Desagrandar.Size = new System.Drawing.Size(85, 23);
            this.Desagrandar.TabIndex = 3;
            this.Desagrandar.Text = "Desagrandar";
            this.Desagrandar.UseVisualStyleBackColor = true;
            this.Desagrandar.Visible = false;
            this.Desagrandar.Click += new System.EventHandler(this.Desagrandar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Agrandar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Button Desagrandar;
    }
}

