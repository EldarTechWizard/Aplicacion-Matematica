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
    public partial class DPoisson : Form
    {
        public DPoisson()
        {
            InitializeComponent();
        }


        double prob(double lambda, double numOc)
        {
            double factorial = 1;
            for (double i = 1; i <= numOc; i++)
            {
                factorial *= i;
            }
            double result = (Math.Exp(-lambda) * Math.Pow(lambda, numOc)) / factorial;
            Console.WriteLine(result + "->" + result * 100 + "%");
            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double numOc = 1;//numero de ocurrencias
            double lambda = 1;
            double desvEst = 0;

            lambda = Convert.ToDouble(textLambda.Text);

            numOc = Convert.ToDouble(textOcu.Text);

            textProb.Text = prob(lambda,numOc).ToString();
            textMedia.Text = lambda.ToString();
            textVarianza.Text = lambda.ToString();


            desvEst = Math.Sqrt(lambda);
            textDesv.Text = desvEst.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//Derecha
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//Izquierda
        {

        }
    }
}
