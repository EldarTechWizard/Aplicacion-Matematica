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
	public partial class Form2 : Form
	{



		public Form2()
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



			
		
		private void button1_Click(object sender, EventArgs e)
        {
			double n = 0, x = 0, N = 2;
			double p = 0;

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

			answer = ((fact.factorial(n) / ( fact.factorial(x) * fact.factorial(n - x) )) * p_1 * q_1 * 100);

			if (x < n1)
			{
				Console.WriteLine("Para poblacion infinita ");
				double media = n * p;
				Console.WriteLine("La media es: " + media);
				Console.WriteLine ("La desviacion estandar es: " + DE);

			}
			if (x > n1)
			{
				Console.WriteLine("Para poblacion finita");
				double Media = x * p;
				double FC = Math.Sqrt(n - x) / (n - 1);
				double DEF = DE * FC;
				Console.WriteLine("La media es: " + Media);
				Console.WriteLine("La desviacion estandar es: " + DEF);
				Console.WriteLine("La probabilidad de fracaso es: " + FC);
			}



		}

       
			
			
    
    }
}
