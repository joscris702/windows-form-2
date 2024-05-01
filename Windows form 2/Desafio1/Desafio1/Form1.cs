using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_montoInicial_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
  
            double monto_inicial = double.Parse(txt_Monto_Inicial.Text);
            double Interes_anual = double.Parse(txt_Interes.Text);
            double periodo = double.Parse(txt_Periodo_Inversion.Text);
            double Capital_final = monto_inicial * (1 + Interes_anual / 100 * periodo);

            MessageBox.Show("El capital final es: " + Capital_final); 
            
        }

       
    }
}
