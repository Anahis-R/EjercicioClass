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
            int resul = 0;
            int inicio = int.Parse(txtinicio.Text);
            int fin = int.Parse(txtfin.Text);
            sumatoria(inicio, fin, resul);
        }
        void sumatoria(int inicio, int fin, int resultado)
        {
            int op;
            for (int j = inicio; j <= fin; j++)
            {
                op = (2 ^ (j + 1) - 2 ^ (j)) / j + 1;
                resultado = resultado + op;
            }
            lblRespuesta.Text = "Respuesta  " + resultado ;
        }
    }
}
