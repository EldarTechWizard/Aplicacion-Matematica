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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var a = 5;
            var b = 6;

            var c = a + b;

            label1.Text = c.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
