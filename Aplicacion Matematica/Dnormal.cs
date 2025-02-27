﻿using System;
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
    public partial class Dnormal : Form
    {
        public Dnormal()
        {
            InitializeComponent();
        }

        private void aceptarCalc_Click(object sender, EventArgs e)
        {
            zText.Text = "";
            textABC.Text = "";

            double[] u = new double[] { 0.00,0.01,0.02,0.03,0.04,0.05,0.06,0.07,0.08,0.09,0.10,0.11,0.12,0.13,0.14,0.15,0.16,0.17,0.18,0.19,0.20,0.21,0.22,0.23,0.24,0.25,0.26,0.27,0.28,
            0.29,0.30,0.31,0.32,0.33,0.34, 0.35,0.36,0.37,0.38,0.39,0.40,0.41,0.42,0.43,0.44,0.45,0.46,0.47,0.48,0.49,0.50,0.51,0.52,0.53,0.54,0.55,0.56,0.57,0.58,0.59,0.60,0.61,
            0.62,0.63,0.64,0.65,0.66,0.67,0.68,0.69,0.70,0.71,0.72,0.73,0.74,0.75,0.76,0.77,0.78,0.79,0.80,0.81,0.82,0.83,0.84,0.85,0.86,0.87,0.88,0.89,0.90,0.91,0.92,0.93,0.94,
            0.95,0.96,0.97,0.98,0.99,1.00,1.01,1.02,1.03,1.04,1.05,1.06,1.07,1.08,1.09,1.10,1.11,1.12,1.13,1.14,1.15,1.16,1.17,1.18,1.19,1.20,1.21,1.22,1.23,1.24,1.25,1.26,
             1.27,1.28,1.29,1.30,1.31,1.32,1.33,1.34,1.35,1.36,1.37,1.38,1.39,1.40,1.41,1.42,1.43,1.44,1.45,1.46,1.47,1.48,1.49,1.50,1.51,1.52,1.53,1.54,1.55,1.56,1.57,1.58,
            1.59,1.60,1.61,1.62,1.63,1.64,1.65,1.66,1.67,1.68,1.69,1.70,1.71,1.72,1.73,1.74,1.75,1.76,1.77,1.78,1.79,1.80,1.81,1.82,1.83,1.84,1.85,1.86,1.87,1.88,1.89,1.90,1.91,
            1.92,1.93,1.94,1.95,1.96,1.97,1.98,1.99,2.00,2.01,2.02,2.03,2.04,2.05,2.06,2.07,2.08,2.09,2.10,2.11,2.12,2.13,2.14,2.15,2.16,2.17,2.18,2.19,2.20,2.21,2.22,2.23,
            2.24,2.25,2.26,2.27,2.28,2.29,2.30,2.31,2.32,2.33,2.34,2.35,2.36,2.37,2.38,2.39,2.40,2.41,2.42,2.43,2.44,2.45,2.46,2.47,2.48,2.49,2.50,2.51,2.52,2.53,2.54,2.55,2.56,
            2.57,2.58,2.59,2.60,2.61,2.62,2.63,2.64,2.65,2.66,2.67,2.68,2.69,2.70,2.71,2.72,2.73,2.74,2.75,2.76,2.77,2.78,2.79,2.80,2.81,2.82,2.83,2.84,2.85,2.86,2.87,2.88,2.89,
            2.90,2.91,2.92,2.93,2.94,2.95,2.96,2.97,2.98,2.99,3.00,3.01,3.02,3.03,3.04,3.05,3.06,3.07,3.08};
            double[] p = new double[] { 0, 0.004,0.008,0.012,0.016,0.0199,0.0239,0.0279,0.0319,0.0359,0.0398,0.0438,0.0478,0.0517,0.0557,0.0596,0.0636,0.0675,0.0714,0.0753,
             0.0793,0.832,0.0871,0.091,0.0948,0.0987,0.1026,0.01064,0.1103,0.1141,0.1179,0.1217,0.1179,0.1255,0.1293,0.1368,0.1406,0.1443,0.148,0.1517,0.1554,0.1591,0.1628,0.1664,0.17,
             0.1736,0.1772,0.1808,0.1844,0.1879,0.1915,0.195,0.1985,0.2019,0.2054,0.2088,0.2123,0.2157,0.219,0.2224,0.2257,0.2291,0.2324,0.2357,0.2389,0.2422,0.2454,0.2486,
             0.2517,0.2549,0.258,0.2611,0.2642,0.2673,0.2704,0.2734,0.2764,0.2794,0.2823,0.2852,0.2881,0.291,0.2939,0.2967,0.2995,0.3023,0.3051,0.3078,0.3106,0.3133,0.3159,
             0.3186,0.3212,0.3238,0.3264,0.3289,0.3315,0.334,0.3365,0.3389,0.3413,0.3438,0.3461,0.3485,0.3508,0.3531,0.3554,0.3577,0.3599,0.3621,0.3643,0.3665,0.3686,0.3708,
             0.3729,0.3749,0.377,0.379,0.381,0.383,0.3849,0.3869,0.3888,0.3907,0.3925,0.3944,0.3962,0.398,0.3997,0.4015,0.4032,0.4049,0.4066,0.4082,0.4099,0.4115,0.4131,0.4147,0.4162,0.4177,
             0.4192,0.4207,0.4222,0.4236,0.4251,0.4265,0.4279,0.4292,0.4306,0.4319,0.4332,0.4345,0.4357,0.437,0.4382,0.4394,0.4406,0.4418,0.4429,0.4441,0.4452,0.4463,
             0.4474,0.4484,0.4495,0.4505,0.4515,0.4525,0.4535,0.4545,0.4554,0.4564,0.4573,0.4582,0.4591,0.4599,0.4608,0.4616,0.4625,0.4633,0.4641,0.4649,0.4656,0.4664,0.4671,
             0.4678,0.4686,0.4693,0.4699,0.4706,0.4713,0.4719,0.4726,0.4732,0.4738,0.4744,0.475,0.4756,0.4761,0.4767,0.4772,0.4778,0.4783,0.4788,0.4793,0.4798,0.4803,
             0.4808,0.4812,0.4817,0.4821,0.4826,0.483,0.4834,0.4838,0.4842,0.4846,0.485,0.4854,0.4857,0.4861,0.4864,0.4868,0.4871,0.4875,0.4878,0.4881,0.4884,0.4887,0.489,
             0.4893,0.4896,0.4898,0.4901,0.4904,0.4906,0.4909,0.4911,0.4913,0.4916,0.4918,0.492,0.4922,0.4925,0.4927,0.4929,0.4931,0.4932,0.4934,0.4936,0.4938,0.494,0.4941,0.4943,
             0.4945,0.4946,0.4948,0.4949,0.4951,0.4952,0.4953,0.4955,0.4956,0.4957,0.4959,0.496,0.4961,0.4962,0.463,0.4964,0.4965,0.4966,0.4967,0.4968,0.4969,0.497,0.4971,
             0.4972,0.4973,0.4974,0.4974,0.4975,0.4976,0.4977,0.4977,0.4978,0.4979,0.4979,0.498,0.4981,0.4981,0.4982,0.4982,0.4983,0.4984,0.4984,0.4985,0.4985,0.4986,0.4986,
             0.4987,0.4987,0.4987,0.4988,0.4988,0.4989,0.4989,0.4989,0.499,0.499 };

            IDictionary<Double, Double> valores = new Dictionary<Double, Double>();

            for(int i = 0; i < u.Length; i++)
            {
                valores.Add(u[i], p[i]);
            }


            double valor = 0, media = 0, disEs = 0;

            bool error = false;

            if (textValor.Text == "")
            {
                textVac.Visible = true;
                textVac.Text = "* Ingrese un Valor para continuar";
                error = true;
            }
            else
            {
                textVac.Visible = false;   
            }

            if (textMedia.Text == "")
            {
                textVac2.Visible = true;
                textVac2.Text = "* Ingrese la Media para continuar";
                error = true;
            }
            else
            {
                textVac2.Visible = false;
            }

            if (textDesvEs.Text == "")
            {
                textVac3.Visible = true;
                textVac3.Text = "* Ingrese la Desviacion estandar para continuar";
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



            try
            {
                valor = Convert.ToDouble(textValor.Text);//try
            }
            catch (FormatException)
            {
                textVac.Text = "* ingrese un valor correcto";
                textVac.Visible = true;
                error = true;
            }

            try
            {
                media = Convert.ToDouble(textMedia.Text);//try
            }
            catch (FormatException)
            {
                textVac2.Text = "* ingrese un valor correcto";
                textVac2.Visible = true;
                error = true;
            }


            try
            {
                disEs = Convert.ToDouble(textDesvEs.Text);//try
            }
            catch (FormatException)
            {
                textVac3.Text = "* ingrese un valor correcto";
                textVac3.Visible = true;
                error = true;
            }

            if(error == true)
            {
                return;
            }
          

            double answer = (valor - media) / disEs;
            double answer2;
            answer = Math.Round(answer, 2);

            if(answer < 0)
            {
                answer2 = answer * -1;
            }
            else
            {
                answer2 = answer;
            }

            if (!valores.ContainsKey(answer2)) 
            {
                errorDic.Visible = true;
            }
            else
            {
                errorDic.Visible = false;
                double z = valores[answer2];
                textAnswer.Text = z.ToString();
                zText.Text = answer.ToString();
            }
             

        }

        private void zText_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//derecha
        {
            textZError.Visible = false;

            if (zText.Text == "")
            {
                textZError.Visible = true;
                return;
            }

            double z = Convert.ToDouble(zText.Text);
            double ABC;
            double a = Convert.ToDouble(textAnswer.Text);//valor de la tabla
            if (z < 0)
            {

                ABC = 50 + (a * 100);
                textABC.Text = ABC.ToString() + "%";
            }
            if (z > 0)
            {

                ABC = 50 - (a * 100);
                textABC.Text = ABC.ToString() + "%";
            }
        }

        private void button3_Click(object sender, EventArgs e)//izquierda
        {

            textZError.Visible = false;

            if (zText.Text == "")
            {
                textZError.Visible = true;
                return;
            }


            double z = Convert.ToDouble(zText.Text);
            double ABC;
            double a = Convert.ToDouble(textAnswer.Text);//valor de la tabla
            if (z > 0)
            {

                ABC = 50 + (a * 100);
                textABC.Text = ABC.ToString() + "%";
            }
            if (z < 0)
            {

                ABC = 50 - (a * 100);
                textABC.Text = ABC.ToString() + "%";
            }
        }
    }
}
