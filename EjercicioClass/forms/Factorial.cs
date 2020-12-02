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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int calcular = int.Parse(txtNumero.Text);
            string cad = TIC.Utilidades.factorial(calcular);
            this.txtRespuesta.Text = cad;
        }
    }
}
