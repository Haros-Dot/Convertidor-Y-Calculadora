using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_Basica;
using Convertidor_Y_Calculadora;


namespace Convertidor_Usd_a_Mxn
{
    
    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbsalidadatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnconversor_Click(object sender, EventArgs e)
        {
            double pantalla = 0.0;
            double resultado = 0.0;

            pantalla = Convert.ToDouble(tbentradadatos.Text);

            if (rbmxnausd.Checked)
                resultado = pantalla / 21.13;

            if (rbusdamxn.Checked)
                resultado = pantalla * 21.13;

            lbresultado.Text = resultado.ToString();

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora cal = new Calculadora();
            cal.Show();
        }

    }
}
