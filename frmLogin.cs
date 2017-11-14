using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsLogin login = new clsLogin();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            login.user = txtuser.Text;
            login.pass = txtpass.Text;
            if (login.ingresar())
            {
                new frmPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ACCESO DENEGADO");
            }
        }
    }
}
