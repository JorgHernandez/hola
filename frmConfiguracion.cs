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
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }
        ClsConexion conectar = new ClsConexion();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClsConexion.servidor = txtServidor.Text;
            ClsConexion.bd = txtBd.Text;
            ClsConexion.user = txtUser.Text;
            ClsConexion.password = txtPassword.Text;
            ClsConexion.creararchivo();
            this.Close();
            Application.Restart();
            Application.Exit();
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
