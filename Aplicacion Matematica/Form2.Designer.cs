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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Agrandar = new System.Windows.Forms.Button();
            this.Desagrandar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(907, 34);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Cerrar);
            this.flowLayoutPanel2.Controls.Add(this.Agrandar);
            this.flowLayoutPanel2.Controls.Add(this.Desagrandar);
            this.flowLayoutPanel2.Controls.Add(this.Minimizar);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(347, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(560, 31);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.White;
            this.Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cerrar.BackgroundImage")));
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.Cerrar.Location = new System.Drawing.Point(517, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(40, 23);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agrandar
            // 
            this.Agrandar.BackColor = System.Drawing.Color.White;
            this.Agrandar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agrandar.BackgroundImage")));
            this.Agrandar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Agrandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agrandar.ForeColor = System.Drawing.Color.Transparent;
            this.Agrandar.Location = new System.Drawing.Point(471, 3);
            this.Agrandar.Name = "Agrandar";
            this.Agrandar.Size = new System.Drawing.Size(40, 23);
            this.Agrandar.TabIndex = 1;
            this.Agrandar.UseVisualStyleBackColor = false;
            this.Agrandar.Click += new System.EventHandler(this.Agrandar_click);
            // 
            // Desagrandar
            // 
            this.Desagrandar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Desagrandar.BackgroundImage")));
            this.Desagrandar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Desagrandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desagrandar.ForeColor = System.Drawing.Color.Transparent;
            this.Desagrandar.Location = new System.Drawing.Point(425, 3);
            this.Desagrandar.Name = "Desagrandar";
            this.Desagrandar.Size = new System.Drawing.Size(40, 23);
            this.Desagrandar.TabIndex = 3;
            this.Desagrandar.UseVisualStyleBackColor = true;
            this.Desagrandar.Visible = false;
            this.Desagrandar.Click += new System.EventHandler(this.Desagrandar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.White;
            this.Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizar.BackgroundImage")));
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.ForeColor = System.Drawing.Color.Transparent;
            this.Minimizar.Location = new System.Drawing.Point(379, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 23);
            this.Minimizar.TabIndex = 2;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Font = new System.Drawing.Font("Lato Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(347, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "DISTRIBUCION DE PROBABILIDAD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Agrandar;
        private System.Windows.Forms.Button Desagrandar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}