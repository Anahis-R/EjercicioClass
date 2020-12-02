using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClass.forms
{
    public partial class Formula : Form
    {
        public Formula()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int inicio = int.Parse(txtinicio.Text);
            int fin = int.Parse(txtfin.Text);
            sumatoria(inicio, fin, resultado);
        }
        void sumatoria(int inicio, int fin, int resultado)
        {
            int operacion;
            for (int i = inicio; i <= fin; i++)
            {
                operacion = (2 ^ (i + 1) - 2 ^ (i)) / i + 1;
                resultado = resultado + operacion;
            }
            lbrespuesta.Text = "La respuesta es : " + resultado;
        }
    }
}
