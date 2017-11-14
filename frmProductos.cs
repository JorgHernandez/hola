using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmProductos : Form
    {
        clsProductos datos = new clsProductos();
        public frmProductos()
        {
            InitializeComponent();
            dataGridViewproductos.DataSource = datos.MuestraProductos();
            //datos.miconeccion();
            //dataGridViewproductos.DataSource = datos.consultar();


            cmbcategoria.DataSource = clsProductos.categ();
            cmbcategoria.DisplayMember = "Categoria";
            cmbcategoria.ValueMember = "Categoria";
            txtidproducto.Enabled = false;
            Deshabilitar();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            this.btnCancelar.Enabled = false;
        }
        string urlimageni;
        OpenFileDialog open = new OpenFileDialog();

        
        
        clsDatosgenerales product = new clsDatosgenerales();
        private void btnReporte_Click(object sender, EventArgs e)
        {
            new frmRptProductos().Show();
        }

        private void btnnewproducto_Click(object sender, EventArgs e)
        {
            if (btnnewproducto.Text == "NUEVO")
            {
                nuevo();
                Limpiar();
                this.btnnewproducto.Enabled = true;
                this.btnCancelar.Enabled = true;
                btnnewproducto.Text = "GUARDAR";
                pictureBox2.Visible = true;
            }
            else
            {
                registrar();
                pictureBox2.Visible = false;
            }
          
        }
        public void registrar()
        {
            if (string.IsNullOrWhiteSpace(txtnombreproducto.Text) || string.IsNullOrWhiteSpace(txtprecio.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                //string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                //correctfilename = System.IO.Path.GetFileName(open.FileName);
                //  System.IO.File.Copy(open.FileName, paths + "\\Images\\" + correctfilename);

                //  textBox1.Text = @url;

                try
                {
                    product.Nombre = txtnombreproducto.Text.Trim();
                    product.Categoria = cmbcategoria.SelectedValue.ToString();
                    product.Precio = int.Parse(txtprecio.Text.Trim());
                    product.Imagen = urlimagen;
                    product.Descripcion = txtdescripcion.Text.Trim();

                    int resultado = clsProductos.Agregar(product);
                    if (resultado > 0)
                    {


                        MessageBox.Show("Producto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Deshabilitar();

                        dataGridViewproductos.DataSource = datos.MuestraProductos();
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el Producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("error al elegir la categoria");
                }
            }
            btnnewproducto.Text = "NUEVO";
        }
        private void btnguardarproducto_Click(object sender, EventArgs e)
        {
        }

        private void btneditarproducto_Click(object sender, EventArgs e)
        {
            if (btneditarproducto.Text == "EDITAR")
            {
                
                Habilitar();
                btneditarproducto.Text = "ACTUALIZAR";
                pictureBox3.Visible = true;

            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtnombreproducto.Text) || string.IsNullOrWhiteSpace(txtprecio.Text))
                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    product.Nombre = txtnombreproducto.Text.Trim();
                    product.Categoria = cmbcategoria.SelectedValue.ToString();
                    product.Precio = int.Parse(txtprecio.Text.Trim());
                    //product.Imagen = urlimagen;
                    product.Imagen = urlimageni;
                    product.Descripcion = txtdescripcion.Text.Trim();
                    product.Id = int.Parse(txtidproducto.Text);

                    if (clsProductos.Actualizar(product) > 0)
                    {
                        MessageBox.Show("Los datos del Producto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Deshabilitar();
                        pictureBox3.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    dataGridViewproductos.DataSource = datos.MuestraProductos();
                    btneditarproducto.Text = "EDITAR";
                }
            }
            
           
        }

        private void btneliminarproducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el producto Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsProductos.Eliminar(int.Parse(txtidproducto.Text)) > 0)
                {
                    MessageBox.Show("Producto Eliminado Correctamente!", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                    dataGridViewproductos.DataSource = datos.MuestraProductos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Producto", "Producto No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            Limpiar();
            Deshabilitar();
            this.btnnewproducto.Enabled = true;
            this.btnCancelar.Enabled = false;
            btnnewproducto.Text = "NUEVO";
        }

        private void dataGridViewproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                //pictureBox1.Image = Image.FromFile(urlImagen);
                txtidproducto.Text = dataGridViewproductos.CurrentRow.Cells[0].Value.ToString();
                txtnombreproducto.Text = dataGridViewproductos.CurrentRow.Cells[1].Value.ToString();
                cmbcategoria.Text = dataGridViewproductos.CurrentRow.Cells[2].Value.ToString();
                txtprecio.Text = dataGridViewproductos.CurrentRow.Cells[3].Value.ToString();
                textBox1.Text = dataGridViewproductos.CurrentRow.Cells[4].Value.ToString();
                txtdescripcion.Text = dataGridViewproductos.CurrentRow.Cells[5].Value.ToString();
                string urlImagen = Path.Combine(Application.StartupPath, @"imagenes\" + dataGridViewproductos.CurrentRow.Cells[4].Value.ToString()); //***Nueva modificación
                urlimageni = urlimagen;
                pictureBox1.ImageLocation = urlImagen;
                btnimg.Enabled = true;

                btnnewproducto.Text = "NUEVO";
                btneditarproducto.Text = "EDITAR";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                
                
                // textBox1.Text = dataGridViewproductos.CurrentRow.Cells[6].Value.ToString();

                // pictureBox1.Image = Image.FromFile(url + textBox1.Text);

                //pictureBox1.Image = Image.FromFile(open.FileName);



            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
            Deshabilitar();
            btneliminarproducto.Enabled = true;
            btneditarproducto.Enabled = true;
        }
        string urlimagen = "";
        private void btnimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string rutainicial = getImage.FileName;
                    DirectoryInfo di = new DirectoryInfo(rutainicial);
                    urlimagen = di.Name;
                    string rutafinal = Path.Combine(Application.StartupPath, @"imagenes\" + di.Name);
                    string path = Path.Combine(Application.StartupPath, @"imagenes");
                    if (Directory.Exists(path))
                    {
                        File.Copy(rutainicial, rutafinal, true);
                        pictureBox1.ImageLocation = rutafinal;


                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                        File.Copy(rutainicial, rutafinal, true);
                        pictureBox1.ImageLocation = rutafinal;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        void nuevo()
        {

            //btnguardarproducto.Enabled = true;
            btnimg.Enabled = true;
            pictureBox1.Image = null;
            btneliminarproducto.Enabled = false;
            btneditarproducto.Enabled = false;
            txtnombreproducto.Enabled = true;
            cmbcategoria.Enabled = true;
            txtprecio.Enabled = true;
            txtdescripcion.Enabled = true;
            textBox1.Enabled = true;
        }
        void enab()
        {
            txtnombreproducto.Enabled = true;
            cmbcategoria.Enabled = true;
            txtprecio.Enabled = true;
            txtdescripcion.Enabled = true;
            textBox1.Enabled = true;

            //btnguardarproducto.Enabled = false;
            btneliminarproducto.Enabled = false;
            btneditarproducto.Enabled = false;
        }
        void Limpiar()
        {
            txtidproducto.Clear();
            txtnombreproducto.Clear();
            txtprecio.Clear();
            textBox1.Clear();
            txtdescripcion.Clear();
        }
        void Deshabilitar()
        {
            txtnombreproducto.Enabled = false;
            cmbcategoria.Enabled = false;
            btnimg.Enabled = false;
            pictureBox1.Image = null;
            txtprecio.Enabled = false;
            txtdescripcion.Enabled = false;
            textBox1.Enabled = false;
            //btnguardarproducto.Enabled = false;
            btneliminarproducto.Enabled = false;
            btneditarproducto.Enabled = false;
        }
        void Habilitar()
        {
            txtnombreproducto.Enabled = true;
            cmbcategoria.Enabled = true;
            txtprecio.Enabled = true;
            txtdescripcion.Enabled = true;
            textBox1.Enabled = true;
            //btnguardarproducto.Enabled = true;
            btneliminarproducto.Enabled = true;
            btneditarproducto.Enabled = true;
        }

        private void txtnombreproducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridViewproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
