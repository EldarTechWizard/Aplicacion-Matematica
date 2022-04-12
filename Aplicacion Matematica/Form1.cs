using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Matematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += CreateButtonDelegate;
    

        }


        private void CreateButtonDelegate(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            Panel panel1 = new Panel();
            this.Controls.Add(panel1);
            panel1.Location = new Point(0, 0);
            panel1.BackColor = Color.Black;
            panel1.Size = new Size(Form1.ActiveForm.Size.Width, 35);
            

            Button newButton = new Button();
            this.Controls.Add(newButton);
            newButton.Text = "X";
            newButton.BackColor = Color.AntiqueWhite;
            newButton.Size = new Size(20, 20);
            newButton.Location = new Point(Form1.ActiveForm.Size.Width - newButton.Size.Width, 1);
            newButton.Click += new System.EventHandler(this.newButton_Click);


            label1.Text = Form1.ActiveForm.Size.Width.ToString();

            panel1.Controls.Add(newButton);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            var a = 5;
            var b = 6;

            var c = a * b;

            
        }



       private void newButton_Click(object sender, EventArgs e)
       {
            Close();
       }
    }
}
