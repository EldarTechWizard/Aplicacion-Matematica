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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonDisP = new System.Windows.Forms.Button();
            this.ButtonDisB = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Agrandar = new System.Windows.Forms.Button();
            this.Desagrandar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.PanelDerecho = new System.Windows.Forms.Panel();
            this.DistribucionNormal_Button = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.Title.SuspendLayout();
            this.PanelSuperior.SuspendLayout();
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
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.PanelMenu.Controls.Add(this.DistribucionNormal_Button);
            this.PanelMenu.Controls.Add(this.ButtonDisP);
            this.PanelMenu.Controls.Add(this.ButtonDisB);
            this.PanelMenu.Controls.Add(this.Title);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(294, 655);
            this.PanelMenu.TabIndex = 12;
            // 
            // ButtonDisP
            // 
            this.ButtonDisP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.ButtonDisP.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDisP.FlatAppearance.BorderSize = 0;
            this.ButtonDisP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisP.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisP.ForeColor = System.Drawing.Color.White;
            this.ButtonDisP.Location = new System.Drawing.Point(0, 168);
            this.ButtonDisP.Name = "ButtonDisP";
            this.ButtonDisP.Size = new System.Drawing.Size(294, 77);
            this.ButtonDisP.TabIndex = 2;
            this.ButtonDisP.Text = "Distribucion de poisson";
            this.ButtonDisP.UseVisualStyleBackColor = false;
            this.ButtonDisP.Click += new System.EventHandler(this.DistribucionPoisson_text_Click);
            // 
            // ButtonDisB
            // 
            this.ButtonDisB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.ButtonDisB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDisB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDisB.FlatAppearance.BorderSize = 0;
            this.ButtonDisB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisB.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisB.ForeColor = System.Drawing.Color.White;
            this.ButtonDisB.Location = new System.Drawing.Point(0, 93);
            this.ButtonDisB.Name = "ButtonDisB";
            this.ButtonDisB.Size = new System.Drawing.Size(294, 75);
            this.ButtonDisB.TabIndex = 1;
            this.ButtonDisB.Text = "Distribución binomial";
            this.ButtonDisB.UseVisualStyleBackColor = false;
            this.ButtonDisB.Click += new System.EventHandler(this.DistribucionBinomial_text_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Controls.Add(this.Titulo);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(294, 93);
            this.Title.TabIndex = 0;
            this.Title.Paint += new System.Windows.Forms.PaintEventHandler(this.Title_Paint);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Titulo.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.Titulo.Name = "Titulo";
            this.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Titulo.Size = new System.Drawing.Size(296, 93);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "DisGate";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.PanelSuperior.Controls.Add(this.flowLayoutPanel2);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(294, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(979, 32);
            this.PanelSuperior.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Cerrar);
            this.flowLayoutPanel2.Controls.Add(this.Agrandar);
            this.flowLayoutPanel2.Controls.Add(this.Desagrandar);
            this.flowLayoutPanel2.Controls.Add(this.Minimizar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(790, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(189, 32);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cerrar.BackgroundImage")));
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Cerrar.Location = new System.Drawing.Point(146, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(40, 23);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agrandar
            // 
            this.Agrandar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Agrandar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agrandar.BackgroundImage")));
            this.Agrandar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Agrandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agrandar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Agrandar.Location = new System.Drawing.Point(100, 3);
            this.Agrandar.Name = "Agrandar";
            this.Agrandar.Size = new System.Drawing.Size(40, 23);
            this.Agrandar.TabIndex = 1;
            this.Agrandar.UseVisualStyleBackColor = false;
            this.Agrandar.Click += new System.EventHandler(this.Agrandar_click);
            // 
            // Desagrandar
            // 
            this.Desagrandar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Desagrandar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Desagrandar.BackgroundImage")));
            this.Desagrandar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Desagrandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desagrandar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Desagrandar.Location = new System.Drawing.Point(54, 3);
            this.Desagrandar.Name = "Desagrandar";
            this.Desagrandar.Size = new System.Drawing.Size(40, 23);
            this.Desagrandar.TabIndex = 3;
            this.Desagrandar.UseVisualStyleBackColor = false;
            this.Desagrandar.Visible = false;
            this.Desagrandar.Click += new System.EventHandler(this.Desagrandar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizar.BackgroundImage")));
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Minimizar.Location = new System.Drawing.Point(8, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 23);
            this.Minimizar.TabIndex = 2;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // PanelDerecho
            // 
            this.PanelDerecho.BackColor = System.Drawing.Color.White;
            this.PanelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDerecho.Location = new System.Drawing.Point(294, 32);
            this.PanelDerecho.Name = "PanelDerecho";
            this.PanelDerecho.Size = new System.Drawing.Size(979, 623);
            this.PanelDerecho.TabIndex = 14;
            // 
            // DistribucionNormal_Button
            // 
            this.DistribucionNormal_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.DistribucionNormal_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.DistribucionNormal_Button.FlatAppearance.BorderSize = 0;
            this.DistribucionNormal_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DistribucionNormal_Button.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistribucionNormal_Button.ForeColor = System.Drawing.Color.White;
            this.DistribucionNormal_Button.Location = new System.Drawing.Point(0, 245);
            this.DistribucionNormal_Button.Margin = new System.Windows.Forms.Padding(0);
            this.DistribucionNormal_Button.Name = "DistribucionNormal_Button";
            this.DistribucionNormal_Button.Size = new System.Drawing.Size(294, 86);
            this.DistribucionNormal_Button.TabIndex = 3;
            this.DistribucionNormal_Button.Text = "Distribucion normal";
            this.DistribucionNormal_Button.UseVisualStyleBackColor = false;
            this.DistribucionNormal_Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(46)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1273, 655);
            this.Controls.Add(this.PanelDerecho);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.PanelMenu.ResumeLayout(false);
            this.Title.ResumeLayout(false);
            this.PanelSuperior.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button ButtonDisP;
        private System.Windows.Forms.Button ButtonDisB;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Agrandar;
        private System.Windows.Forms.Button Desagrandar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Panel PanelDerecho;
        private System.Windows.Forms.Button DistribucionNormal_Button;
    }
}

