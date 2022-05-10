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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Agrandar = new System.Windows.Forms.Button();
            this.Desagrandar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelDeTrabajo = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DistribucionBinomial_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelDeTrabajo.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Cerrar);
            this.flowLayoutPanel2.Controls.Add(this.Agrandar);
            this.flowLayoutPanel2.Controls.Add(this.Desagrandar);
            this.flowLayoutPanel2.Controls.Add(this.Minimizar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(351, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(560, 29);
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
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Lato Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(347, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "DISTRIBUCION DE PROBABILIDAD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 29);
            this.panel2.TabIndex = 9;
            // 
            // PanelDeTrabajo
            // 
            this.PanelDeTrabajo.Controls.Add(this.PanelPrincipal);
            this.PanelDeTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeTrabajo.Location = new System.Drawing.Point(5, 34);
            this.PanelDeTrabajo.Name = "PanelDeTrabajo";
            this.PanelDeTrabajo.Size = new System.Drawing.Size(911, 411);
            this.PanelDeTrabajo.TabIndex = 10;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Controls.Add(this.panel3);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(911, 411);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione la distribucion a resolver:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.DistribucionBinomial_text);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(40, 98);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25);
            this.panel1.Size = new System.Drawing.Size(405, 270);
            this.panel1.TabIndex = 11;
            // 
            // DistribucionBinomial_text
            // 
            this.DistribucionBinomial_text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DistribucionBinomial_text.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistribucionBinomial_text.Location = new System.Drawing.Point(25, 204);
            this.DistribucionBinomial_text.Name = "DistribucionBinomial_text";
            this.DistribucionBinomial_text.Size = new System.Drawing.Size(355, 41);
            this.DistribucionBinomial_text.TabIndex = 1;
            this.DistribucionBinomial_text.Text = "DISTRIBUCION BINOMIAL";
            this.DistribucionBinomial_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DistribucionBinomial_text.Click += new System.EventHandler(this.DistribucionBinomial_text_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(504, 98);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(25);
            this.panel3.Size = new System.Drawing.Size(372, 270);
            this.panel3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "DISTRIBUCION DE POISSON";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.PanelDeTrabajo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelDeTrabajo.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Agrandar;
        private System.Windows.Forms.Button Minimizar;
        private System.Windows.Forms.Button Desagrandar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelDeTrabajo;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DistribucionBinomial_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

