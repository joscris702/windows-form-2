using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2
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

        private void button1_Click(object sender, EventArgs e)
        {
            double Prestamo = double.Parse(txt_Monto_Prestamo.Text);
            double Plazo = double.Parse(txt_Plazo.Text);
            double Interes = double.Parse(txt_Interes_Anual.Text);
            double Interes_Mensual = Interes / 100;
            double Cuota_Mensual = (Prestamo * Interes_Mensual * Math.Pow((1 + Interes_Mensual), Plazo)) / ((Math.Pow((1 + Interes_Mensual), Plazo)) - 1);


            MessageBox.Show("La cuota mensula del prestamo es de aproximadamente de: " + Cuota_Mensual);




        }
    }
}
