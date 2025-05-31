using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuenosAires.BodegaBA;
using BuenosAires.Model.Utiles;
using BuenosAires.Model;

namespace BuenosAires.VentaBA
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
     
            if (txtCuenta.Text.Trim() == "")
            {
                this.MensajeInfo("Debe ingresar una cuenta");
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                this.MensajeInfo("Debe ingresar una cuenta");
                return;
            }
            var ventana = new VentanaLogin(txtCuenta.Text);
            this.Hide();
            ventana.ShowDialog();

            /* new VentanaProducto("Carlos Reyes", "Bodeguero").Show();
             Hide();
            Comentado por Tomas (no aparece esta linea en el video 4to)
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }
    }
}
