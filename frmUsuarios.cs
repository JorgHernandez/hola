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
    public partial class frmUsuarios : Form
    {
        clsUsuarios user = new clsUsuarios();
        public frmUsuarios()
        {
            InitializeComponent();
         
            dtgvUsuarios.DataSource = user.MuestraUsuarios();
            txtidusuario.Enabled = false;
            Deshabilitar();
            this.btnCancelar.Enabled = false;
        }

        private void btnnuevousuario_Click(object sender, EventArgs e)
        {
            nuevo();
            Limpiar();
            this.btnnuevousuario.Enabled = false;
            this.btnCancelar.Enabled = true;
        }

        private void btnguardarusuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombreusuario.Text) || string.IsNullOrWhiteSpace(txtapMaterno.Text) || string.IsNullOrWhiteSpace(txtapPaterno.Text) || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                user.Nombre = txtnombreusuario.Text.Trim();
                user.apmaterno = txtapMaterno.Text.Trim();
                user.appaterno = txtapPaterno.Text.Trim();
                user.usuarioUser = txtUser.Text.Trim();
                user.Email = txtEmail.Text.Trim();
                user.passwordUser = txtPass.Text.Trim();

                int resultado = clsUsuarios.Agregar(user);
                if (resultado > 0)
                {


                    MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*Limpiar();
                    Deshabilitar();*/
                    dtgvUsuarios.DataSource = user.MuestraUsuarios();
                    //dataGridViewusuarios.DataSource = user.consultar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Limpiar();
            }
        }

        private void btneditarusuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombreusuario.Text) || string.IsNullOrWhiteSpace(txtapMaterno.Text) || string.IsNullOrWhiteSpace(txtapPaterno.Text) || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                user.Nombre = txtnombreusuario.Text.Trim();
                user.apmaterno = txtapMaterno.Text.Trim();
                user.appaterno = txtapPaterno.Text.Trim();
                user.usuarioUser = txtUser.Text.Trim();
                user.Email = txtEmail.Text.Trim();
                user.passwordUser = txtPass.Text.Trim();
                user.Id = int.Parse(txtidusuario.Text);

                if (clsUsuarios.Actualizar(user) > 0)
                {
                    MessageBox.Show("Los datos del Usuario se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                dtgvUsuarios.DataSource = user.MuestraUsuarios();
                //dataGridViewusuarios.DataSource = user.consultar();
            }
        }

        private void btneliminarusuario_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta Seguro que desea eliminar el Proveedor Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUsuarios.Eliminar(int.Parse(txtidusuario.Text)) > 0)
                {
                    MessageBox.Show("Usuario Eliminado Correctamente!", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                    dtgvUsuarios.DataSource = user.MuestraUsuarios();
                    //dataGridViewusuarios.DataSource = user.consultar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Usuario", "Usuario No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
            this.btnnuevousuario.Enabled = true;
            this.btnCancelar.Enabled = false;
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidusuario.Text = dtgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtnombreusuario.Text = dtgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtapPaterno.Text = dtgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtapMaterno.Text = dtgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtUser.Text = dtgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtPass.Text = dtgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dtgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            enab();
            btneditarusuario.Enabled = true;
            btneliminarusuario.Enabled = true;
        }
        void enab()
        {
            txtnombreusuario.Enabled = true;
            txtapMaterno.Enabled = true;
            txtapPaterno.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtEmail.Enabled = true;

            btnguardarusuario.Enabled = false;
            btneliminarusuario.Enabled = false;
            btneditarusuario.Enabled = false;
        }
        void nuevo()
        {

            txtnombreusuario.Enabled = true;
            txtapMaterno.Enabled = true;
            txtapPaterno.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            btnguardarusuario.Enabled = true;
            btneliminarusuario.Enabled = false;
            btneditarusuario.Enabled = false;

        }

        void Deshabilitar()
        {
            txtnombreusuario.Enabled = false;
            txtapMaterno.Enabled = false;
            txtapPaterno.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtEmail.Enabled = false;
            btnguardarusuario.Enabled = false;
            btneliminarusuario.Enabled = false;
            btneditarusuario.Enabled = false;

        }
        void Limpiar()
        {
            txtnombreusuario.Clear();
            txtapMaterno.Clear();
            txtapPaterno.Clear();
            txtUser.Clear();
            txtPass.Clear();
        }

        private void txtnombreusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion(e);
        }

        private void txtapPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion(e);
        }

        private void txtapMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion(e);
        }
        public void validacion(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            new frmRptUsuarios().Show();
            //new frmReporteUsuarios().Show();
        }
    }
}
