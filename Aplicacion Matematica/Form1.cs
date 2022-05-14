using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Matematica
{
    public partial class Form1 : Form
    {

        private Form currentChildForm;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    

        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
      
            currentChildForm = childForm;

            childForm.TopLevel = false;

            PanelDerecho.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }
        private void MovePanel(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Agrandar_click(object sender, EventArgs e)
        {
            MaximizedAction();
        }

        private void Desagrandar_Click(object sender, EventArgs e)
        {
            NormalAction();
        }

        private void MaximizedAction()
        {
            this.WindowState = FormWindowState.Maximized;
            Desagrandar.Visible = true;
            Agrandar.Visible = false;
            flowLayoutPanel2.Size = new Size(1010, 31);
        }
        private void NormalAction()
        {
            Desagrandar.Visible = false;
            Agrandar.Visible = true;
            this.WindowState = FormWindowState.Normal;
            flowLayoutPanel2.Size = new Size(560, 31);
        }

        private void DistribucionBinomial_text_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void DistribucionPoisson_text_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dbinomial());
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
