using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Matematica
{
	public partial class Dbinomial : Form
	{



		public Dbinomial()
		{
			InitializeComponent();
		}


		class Factorial
		{
			public double factorial(double a)
			{
				double fac = 1;
				while (a > 1)
				{
					fac = fac * a;
					a--;
				}
				return fac;
			}
		}


		//rdtr programa saca resultados xd


		private void button1_Click(object sender, EventArgs e)
		{
			textMedia.Text = "";
			textDesv.Text = "";
			textProbf.Text = "";


			double n = 0, x = 0, N = 2;
			double p = 0;

			bool error = false;

			if (xText.Text == "")
			{
				textVac.Visible = true;
				error = true;
			}
			else
			{
				textVac.Visible = false;
			}

			if (nText.Text == "")
			{
				textVac2.Visible = true;
				error = true;
			}
			else
			{
				textVac2.Visible = false;
			}

			if (pText.Text == "")
			{
				textVac3.Visible = true;
				error = true;
			}
			else
			{
				textVac3.Visible = false;
			}

			if (error == true)
			{
				return;
			}



			Factorial fact = new Factorial();

			n = Convert.ToDouble(nText.Text);
			x = Convert.ToDouble(xText.Text);
			p = Convert.ToDouble(pText.Text);


			double q = 1 - p;
			double q_1 = Math.Pow(q, n - 1);
			double p_1 = Math.Pow(p, x);
			double n1 = n * 0.05;
			double DE = Math.Sqrt(n * p * q);

			double answer = 0;

			answer = ((fact.factorial(n) / (fact.factorial(x) * fact.factorial(n - x))) * p_1 * q_1 * 100);

			if (x < n1)
			{
				panelProbF.Visible = false;
				textTitle.Text = "Para poblacion Infinita";
				double media = n * p;
				textMedia.Text = media.ToString();
				textDesv.Text = DE.ToString();
			}
			if (x > n1)
			{
				textTitle.Text = "Para poblacion Finita";
				double Media = x * p;
				double FC = Math.Sqrt(n - x) / (n - 1);
				double DEF = DE * FC;

				panelProbF.Visible = true;

				textMedia.Text = Media.ToString();
				textDesv.Text = DEF.ToString();
				textProbf.Text = FC.ToString();
			}



		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

        private void controlText1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
