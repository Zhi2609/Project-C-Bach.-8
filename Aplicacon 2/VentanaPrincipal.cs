using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacon_2
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BTNComprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;

            if(CursoVC.Checked==true)
            {
                conteo++;
            }
            if(CursoVC2.Checked==true)
            {
                conteo++;
            }
            if(PagoCredito.Checked==true)
            {
                seleccion = "Tarjeta de Credito";
            }else
            {
                seleccion = "Paypal";
            }

            MessageBox.Show("Has Seleccionado " + conteo + "curso y su metodo de pago es mediante " + seleccion);
        }
    }
}
