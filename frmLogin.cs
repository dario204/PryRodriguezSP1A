using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryRodriguezSP1A
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
     
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "administrador" && txtContraseña.Text == "adm135$")
            {
                this.Hide();
                frmBienvenido f = new frmBienvenido();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
    
            }
            if (txtUsuario.Text=="operador"&& txtContraseña.Text=="ope246$")
            {
                this.Hide();
                frmBienvenido f = new frmBienvenido();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
