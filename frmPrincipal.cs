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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            slide.Height = btninicio.Height;
            CambiarPanel(new frmBienvenida());

        }
        private void CambiarPanel(object Formulario)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
            {
                this.pnlPrincipal.Controls.RemoveAt(0);
            }

            Form fh = Formulario as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(fh);
            this.pnlPrincipal.Tag = fh;
            fh.Show();
        }
        private void btninicio_Click(object sender, EventArgs e)
        {
            slide.Height = btninicio.Height;
            slide.Top = btninicio.Top;
            CambiarPanel(new frmBienvenida());
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            slide.Height = btnproductos.Height;
            slide.Top = btnproductos.Top;
            CambiarPanel(new frmProductos());
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            slide.Height = btnproveedores.Height;
            slide.Top = btnproveedores.Top;
            CambiarPanel(new frmProvedor());
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            slide.Height =  btnuser.Height;
            slide.Top = btnuser.Top;
            CambiarPanel(new frmUsuarios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir","Mercado online", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmSplash login = new frmSplash();
            if (MessageBox.Show("Esta Seguro que desea cerrar sesion", "Mercado Online", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login.Show();
                this.Close();
            }
            else
            {

            }
        }
    }
}
