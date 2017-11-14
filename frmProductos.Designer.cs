namespace Prueba
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.btnReporte = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnimg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewproductos = new System.Windows.Forms.DataGridView();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btneliminarproducto = new System.Windows.Forms.Button();
            this.btnnewproducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btneditarproducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(670, 526);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(153, 36);
            this.btnReporte.TabIndex = 91;
            this.btnReporte.Text = "GENERAR REPORTE";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "DESCRIPCION:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "IMAGEN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "PRECIO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "CATEGORIA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "NOMBRE:";
            // 
            // btnimg
            // 
            this.btnimg.Location = new System.Drawing.Point(502, 204);
            this.btnimg.Name = "btnimg";
            this.btnimg.Size = new System.Drawing.Size(204, 23);
            this.btnimg.TabIndex = 81;
            this.btnimg.Text = "Imagen";
            this.btnimg.UseVisualStyleBackColor = true;
            this.btnimg.Click += new System.EventHandler(this.btnimg_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(339, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 13);
            this.textBox1.TabIndex = 73;
            // 
            // dataGridViewproductos
            // 
            this.dataGridViewproductos.AllowUserToAddRows = false;
            this.dataGridViewproductos.AllowUserToDeleteRows = false;
            this.dataGridViewproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproductos.Location = new System.Drawing.Point(174, 276);
            this.dataGridViewproductos.Name = "dataGridViewproductos";
            this.dataGridViewproductos.ReadOnly = true;
            this.dataGridViewproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewproductos.Size = new System.Drawing.Size(643, 237);
            this.dataGridViewproductos.TabIndex = 80;
            this.dataGridViewproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewproductos_CellClick);
            this.dataGridViewproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewproductos_CellContentClick);
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(174, 177);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(184, 21);
            this.cmbcategoria.TabIndex = 79;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(502, 233);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(204, 37);
            this.txtdescripcion.TabIndex = 74;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(174, 217);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 72;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(174, 140);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(184, 20);
            this.txtnombreproducto.TabIndex = 77;
            this.txtnombreproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreproducto_KeyPress);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(174, 102);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 20);
            this.txtidproducto.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 45);
            this.label1.TabIndex = 70;
            this.label1.Text = "PRODUCTOS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Prueba.Properties.Resources.actualizar_con_dos_flechas_circulares_hacia_la_izquierda_de_simbolo_de_interfaz;
            this.pictureBox3.Location = new System.Drawing.Point(53, 336);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 45);
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Prueba.Properties.Resources.Floppy;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(53, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Prueba.Properties.Resources.iconcalcell;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(53, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 43);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btneliminarproducto
            // 
            this.btneliminarproducto.Image = global::Prueba.Properties.Resources.Close;
            this.btneliminarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarproducto.Location = new System.Drawing.Point(53, 397);
            this.btneliminarproducto.Name = "btneliminarproducto";
            this.btneliminarproducto.Size = new System.Drawing.Size(97, 45);
            this.btneliminarproducto.TabIndex = 84;
            this.btneliminarproducto.Text = "ELIMINAR";
            this.btneliminarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarproducto.UseVisualStyleBackColor = true;
            this.btneliminarproducto.Click += new System.EventHandler(this.btneliminarproducto_Click);
            // 
            // btnnewproducto
            // 
            this.btnnewproducto.Image = global::Prueba.Properties.Resources.Add;
            this.btnnewproducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnnewproducto.Location = new System.Drawing.Point(53, 276);
            this.btnnewproducto.Name = "btnnewproducto";
            this.btnnewproducto.Size = new System.Drawing.Size(97, 44);
            this.btnnewproducto.TabIndex = 83;
            this.btnnewproducto.Text = "NUEVO";
            this.btnnewproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnewproducto.UseVisualStyleBackColor = true;
            this.btnnewproducto.Click += new System.EventHandler(this.btnnewproducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(502, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // btneditarproducto
            // 
            this.btneditarproducto.Image = ((System.Drawing.Image)(resources.GetObject("btneditarproducto.Image")));
            this.btneditarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditarproducto.Location = new System.Drawing.Point(53, 336);
            this.btneditarproducto.Name = "btneditarproducto";
            this.btneditarproducto.Size = new System.Drawing.Size(97, 45);
            this.btneditarproducto.TabIndex = 78;
            this.btneditarproducto.Text = "EDITAR";
            this.btneditarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditarproducto.UseVisualStyleBackColor = true;
            this.btneditarproducto.Click += new System.EventHandler(this.btneditarproducto_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 574);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btneliminarproducto);
            this.Controls.Add(this.btnnewproducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnimg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btneditarproducto);
            this.Controls.Add(this.dataGridViewproductos);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btneliminarproducto;
        private System.Windows.Forms.Button btnnewproducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnimg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btneditarproducto;
        private System.Windows.Forms.DataGridView dataGridViewproductos;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}