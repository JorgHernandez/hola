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
    public partial class frmProvedor : Form
    {
        clsProveedores proveedor = new clsProveedores();
        public frmProvedor()
        {
            InitializeComponent();
            dataGridView1.DataSource = proveedor.MuestraProveedor();
            Deshabilitar();
            textBox1.Enabled = false;
            this.btnCancelar.Enabled = false;
        }

        private void btnnuevoproducto_Click(object sender, EventArgs e)
        {
            nuevo();
            Limpiar();
            this.btnnuevoproducto.Enabled = false;
            this.btnCancelar.Enabled = true;
        }

        private void btnguardarproducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtapPat.Text) || string.IsNullOrWhiteSpace(txtapMat.Text) || string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtDirec.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {


                proveedor.Nombre = txtname.Text.Trim();
                proveedor.apmaterno = txtapPat.Text.Trim();
                proveedor.appaterno = txtapMat.Text.Trim();
                proveedor.telefonoProv = txtTel.Text.Trim();
                proveedor.direccionPro = txtDirec.Text.Trim();

                int resultado = clsProveedores.Agregar(proveedor);
                if (resultado > 0)
                {


                    MessageBox.Show("Proveedor Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                    dataGridView1.DataSource = proveedor.MuestraProveedor();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Proveedor", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Limpiar();
            }
        }

        private void btneditarproducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtapPat.Text) || string.IsNullOrWhiteSpace(txtapMat.Text) || string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtDirec.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                proveedor.Nombre = txtname.Text.Trim();
                proveedor.apmaterno = txtapPat.Text.Trim();
                proveedor.appaterno = txtapMat.Text.Trim();
                proveedor.telefonoProv = txtTel.Text.Trim();
                proveedor.direccionPro = txtDirec.Text.Trim();
                proveedor.Id = int.Parse(textBox1.Text);
                if (clsProveedores.Actualizar(proveedor) > 0)
                {
                    MessageBox.Show("Los datos del Proveedor se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                dataGridView1.DataSource = proveedor.MuestraProveedor();
            }
        }

        private void btneliminarproducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Proveedor Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsProveedores.Eliminar(int.Parse(textBox1.Text)) > 0)
                {
                    MessageBox.Show("Proveedor Eliminado Correctamente!", "Proveedor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                    dataGridView1.DataSource = proveedor.MuestraProveedor();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Proveedor", "Proveedor No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
            this.btnnuevoproducto.Enabled = true;
            this.btnCancelar.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtapPat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtapMat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDirec.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            enab();
            btneditarproducto.Enabled = true;
            btneliminarproducto.Enabled = true;
        }
        void nuevo()
        {

            btnguardarproducto.Enabled = true;
            btneliminarproducto.Enabled = false;
            btneditarproducto.Enabled = false;
            txtname.Enabled = true;
            txtapPat.Enabled = true;
            txtapMat.Enabled = true;
            txtTel.Enabled = true;
            txtDirec.Enabled = true;
        }
        void Deshabilitar()
        {
            txtname.Enabled = false;
            txtapPat.Enabled = false;
            txtapMat.Enabled = false;
            txtTel.Enabled = false;
            txtDirec.Enabled = false;
            btnguardarproducto.Enabled = false;
            btneliminarproducto.Enabled = false;
            btneditarproducto.Enabled = false;
        }
        void Limpiar()
        {
            txtname.Clear();
            txtapPat.Clear();
            txtapMat.Clear();
            txtTel.Clear();
            txtDirec.Clear();
        }
        void enab()
        {
            txtname.Enabled = true;
            txtapPat.Enabled = true;
            txtapMat.Enabled = true;
            txtTel.Enabled = true;
            txtDirec.Enabled = true;

            btnguardarproducto.Enabled = false;
            btneliminarproducto.Enabled = false;
            btneditarproducto.Enabled = false;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion(e);
        }

        private void txtapMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion(e);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            new frmRptProveedor().Show();
          //  new frmReporteProveedor().Show();
        }
    }
}
