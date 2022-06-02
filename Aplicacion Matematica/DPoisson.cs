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
            
            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textProb.Text = "";
            textMedia.Text = "";
            textDesv.Text = "";
            textVarianza.Text = "";

            textVac.Visible = false;
            textVac2.Visible = false;

            bool error = false;

            if(textLambda.Text == "")
            {
                textVac.Visible = true;
                textVac.Text = "* Ingrese Lambda para continuar";
                error = true;
            }
            if (textOcu.Text == "")
            {
                textVac2.Visible = true;
                textVac2.Text = "* Ingrese el Numero de ocurrencia para continuar";
                error = true;
            }

            if(error == true)
            {
                return;
            }


            double numOc = 1;//numero de ocurrencias
            double lambda = 1;
            double desvEst = 0;
            double prob1 = 0;


            
            try
            {
                lambda = Convert.ToDouble(textLambda.Text);
            }
            catch (FormatException)
            {
                textVac.Text = "* ingrese un valor correcto";
                textVac.Visible = true;
                error = true;
            }

            try
            {
                numOc = Convert.ToDouble(textOcu.Text);
            }
            catch (FormatException)
            {
                textVac2.Text = "* ingrese un valor correcto";
                textVac2.Visible = true;
                error = true;
            }

            if (error == true)
            {
                return;
            }

            prob1 = prob(lambda, numOc) * 100;
            prob1 = Math.Round(prob1, 2);

            textProb.Text = prob1.ToString()+"%";
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
