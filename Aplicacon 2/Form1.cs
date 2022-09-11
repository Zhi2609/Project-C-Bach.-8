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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el Formulario.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt1.Text=="Juancho" && txt2.Text=="Tamarindo")
            {
                MessageBox.Show("Bienvenido Señor Don Juancho");
                //Creamos y Cargamos la Nueva Ventana
                this.Hide();//Minimiza o Esconde el Login
                VentanaPrincipal CursosVentana = new VentanaPrincipal();
                CursosVentana.Show();//Llamamos la ventana
            }else
            {
                MessageBox.Show("Error en Contraseña O Usuario, Vuelva a Intentarlo");
                txt1.Text = "";
                txt2.Text = "";
                txt1.Focus();
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
