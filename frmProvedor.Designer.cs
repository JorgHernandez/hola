namespace Prueba
{
    partial class frmProvedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProvedor));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtapPat = new System.Windows.Forms.TextBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.txtapMat = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btneliminarproducto = new System.Windows.Forms.Button();
            this.btneditarproducto = new System.Windows.Forms.Button();
            this.btnguardarproducto = new System.Windows.Forms.Button();
            this.btnnuevoproducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 45);
            this.label6.TabIndex = 84;
            this.label6.Text = "PROVEEDORES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "APELLIDO PATERNO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 237);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "APELLIDO MATERNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "TELEFONO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "DIRECCION:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(185, 136);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 72;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtapPat
            // 
            this.txtapPat.Location = new System.Drawing.Point(185, 173);
            this.txtapPat.Name = "txtapPat";
            this.txtapPat.Size = new System.Drawing.Size(100, 20);
            this.txtapPat.TabIndex = 73;
            this.txtapPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapPat_KeyPress);
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(415, 176);
            this.txtDirec.Multiline = true;
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(152, 57);
            this.txtDirec.TabIndex = 76;
            // 
            // txtapMat
            // 
            this.txtapMat.Location = new System.Drawing.Point(185, 213);
            this.txtapMat.Name = "txtapMat";
            this.txtapMat.Size = new System.Drawing.Size(100, 20);
            this.txtapMat.TabIndex = 74;
            this.txtapMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapMat_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(415, 133);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 75;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(675, 518);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(153, 36);
            this.btnReporte.TabIndex = 92;
            this.btnReporte.Text = "GENERAR REPORTE";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Prueba.Properties.Resources.iconcalcell1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(64, 515);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 43);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btneliminarproducto
            // 
            this.btneliminarproducto.Image = ((System.Drawing.Image)(resources.GetObject("btneliminarproducto.Image")));
            this.btneliminarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarproducto.Location = new System.Drawing.Point(64, 452);
            this.btneliminarproducto.Name = "btneliminarproducto";
            this.btneliminarproducto.Size = new System.Drawing.Size(97, 44);
            this.btneliminarproducto.TabIndex = 80;
            this.btneliminarproducto.Text = "ELIMINAR";
            this.btneliminarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarproducto.UseVisualStyleBackColor = true;
            this.btneliminarproducto.Click += new System.EventHandler(this.btneliminarproducto_Click);
            // 
            // btneditarproducto
            // 
            this.btneditarproducto.Image = ((System.Drawing.Image)(resources.GetObject("btneditarproducto.Image")));
            this.btneditarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditarproducto.Location = new System.Drawing.Point(64, 392);
            this.btneditarproducto.Name = "btneditarproducto";
            this.btneditarproducto.Size = new System.Drawing.Size(97, 45);
            this.btneditarproducto.TabIndex = 79;
            this.btneditarproducto.Text = "EDITAR";
            this.btneditarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditarproducto.UseVisualStyleBackColor = true;
            this.btneditarproducto.Click += new System.EventHandler(this.btneditarproducto_Click);
            // 
            // btnguardarproducto
            // 
            this.btnguardarproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarproducto.Image")));
            this.btnguardarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardarproducto.Location = new System.Drawing.Point(64, 332);
            this.btnguardarproducto.Name = "btnguardarproducto";
            this.btnguardarproducto.Size = new System.Drawing.Size(97, 42);
            this.btnguardarproducto.TabIndex = 78;
            this.btnguardarproducto.Text = "GUARDAR";
            this.btnguardarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarproducto.UseVisualStyleBackColor = true;
            this.btnguardarproducto.Click += new System.EventHandler(this.btnguardarproducto_Click);
            // 
            // btnnuevoproducto
            // 
            this.btnnuevoproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevoproducto.Image")));
            this.btnnuevoproducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnnuevoproducto.Location = new System.Drawing.Point(64, 272);
            this.btnnuevoproducto.Name = "btnnuevoproducto";
            this.btnnuevoproducto.Size = new System.Drawing.Size(97, 44);
            this.btnnuevoproducto.TabIndex = 77;
            this.btnnuevoproducto.Text = "NUEVO";
            this.btnnuevoproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevoproducto.UseVisualStyleBackColor = true;
            this.btnnuevoproducto.Click += new System.EventHandler(this.btnnuevoproducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba.Properties.Resources.Floppy;
            this.pictureBox1.Location = new System.Drawing.Point(64, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 44);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // frmProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneliminarproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneditarproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnguardarproducto);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnnuevoproducto);
            this.Controls.Add(this.txtapPat);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.txtapMat);
            this.Controls.Add(this.txtTel);
            this.Name = "frmProvedor";
            this.Text = "frmProvedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btneliminarproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneditarproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguardarproducto;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnnuevoproducto;
        private System.Windows.Forms.TextBox txtapPat;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtapMat;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}