namespace Prueba
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtapPaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtapMaterno = new System.Windows.Forms.TextBox();
            this.txtnombreusuario = new System.Windows.Forms.TextBox();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.USUARIOS = new System.Windows.Forms.Label();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btneliminarusuario = new System.Windows.Forms.Button();
            this.btneditarusuario = new System.Windows.Forms.Button();
            this.btnguardarusuario = new System.Windows.Forms.Button();
            this.btnnuevousuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(411, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 84;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Prueba.Properties.Resources.iconcalcell;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(51, 513);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 43);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "PASSWORD:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(411, 213);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 81;
            // 
            // txtapPaterno
            // 
            this.txtapPaterno.Location = new System.Drawing.Point(172, 174);
            this.txtapPaterno.Name = "txtapPaterno";
            this.txtapPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtapPaterno.TabIndex = 80;
            this.txtapPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapPaterno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "APELLIDO PATERNO:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(411, 137);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 74;
            // 
            // txtapMaterno
            // 
            this.txtapMaterno.Location = new System.Drawing.Point(171, 213);
            this.txtapMaterno.Name = "txtapMaterno";
            this.txtapMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtapMaterno.TabIndex = 73;
            this.txtapMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapMaterno_KeyPress);
            // 
            // txtnombreusuario
            // 
            this.txtnombreusuario.Location = new System.Drawing.Point(172, 137);
            this.txtnombreusuario.Name = "txtnombreusuario";
            this.txtnombreusuario.Size = new System.Drawing.Size(100, 20);
            this.txtnombreusuario.TabIndex = 72;
            this.txtnombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreusuario_KeyPress);
            // 
            // txtidusuario
            // 
            this.txtidusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidusuario.Location = new System.Drawing.Point(172, 107);
            this.txtidusuario.Margin = new System.Windows.Forms.Padding(3, 3, 5, 7);
            this.txtidusuario.Multiline = true;
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(100, 20);
            this.txtidusuario.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "APELLIDO MATERNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID:";
            // 
            // USUARIOS
            // 
            this.USUARIOS.AutoSize = true;
            this.USUARIOS.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIOS.Location = new System.Drawing.Point(62, 2);
            this.USUARIOS.Name = "USUARIOS";
            this.USUARIOS.Size = new System.Drawing.Size(198, 45);
            this.USUARIOS.TabIndex = 66;
            this.USUARIOS.Text = "USUARIOS";
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(180, 274);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.Size = new System.Drawing.Size(746, 237);
            this.dtgvUsuarios.TabIndex = 86;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(773, 517);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(153, 36);
            this.btnReporte.TabIndex = 93;
            this.btnReporte.Text = "GENERAR REPORTE";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btneliminarusuario
            // 
            this.btneliminarusuario.Image = ((System.Drawing.Image)(resources.GetObject("btneliminarusuario.Image")));
            this.btneliminarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarusuario.Location = new System.Drawing.Point(51, 448);
            this.btneliminarusuario.Name = "btneliminarusuario";
            this.btneliminarusuario.Size = new System.Drawing.Size(97, 41);
            this.btneliminarusuario.TabIndex = 78;
            this.btneliminarusuario.Text = "ELIMINAR";
            this.btneliminarusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarusuario.UseVisualStyleBackColor = true;
            this.btneliminarusuario.Click += new System.EventHandler(this.btneliminarusuario_Click);
            // 
            // btneditarusuario
            // 
            this.btneditarusuario.Image = ((System.Drawing.Image)(resources.GetObject("btneditarusuario.Image")));
            this.btneditarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditarusuario.Location = new System.Drawing.Point(51, 391);
            this.btneditarusuario.Name = "btneditarusuario";
            this.btneditarusuario.Size = new System.Drawing.Size(97, 42);
            this.btneditarusuario.TabIndex = 77;
            this.btneditarusuario.Text = "EDITAR";
            this.btneditarusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditarusuario.UseVisualStyleBackColor = true;
            this.btneditarusuario.Click += new System.EventHandler(this.btneditarusuario_Click);
            // 
            // btnguardarusuario
            // 
            this.btnguardarusuario.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarusuario.Image")));
            this.btnguardarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardarusuario.Location = new System.Drawing.Point(51, 333);
            this.btnguardarusuario.Name = "btnguardarusuario";
            this.btnguardarusuario.Size = new System.Drawing.Size(97, 39);
            this.btnguardarusuario.TabIndex = 76;
            this.btnguardarusuario.Text = "GUARDAR";
            this.btnguardarusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarusuario.UseVisualStyleBackColor = true;
            this.btnguardarusuario.Click += new System.EventHandler(this.btnguardarusuario_Click);
            // 
            // btnnuevousuario
            // 
            this.btnnuevousuario.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevousuario.Image")));
            this.btnnuevousuario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnnuevousuario.Location = new System.Drawing.Point(51, 273);
            this.btnnuevousuario.Name = "btnnuevousuario";
            this.btnnuevousuario.Size = new System.Drawing.Size(97, 41);
            this.btnnuevousuario.TabIndex = 75;
            this.btnnuevousuario.Text = "NUEVO";
            this.btnnuevousuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevousuario.UseVisualStyleBackColor = true;
            this.btnnuevousuario.Click += new System.EventHandler(this.btnnuevousuario_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 568);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dtgvUsuarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtapPaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btneliminarusuario);
            this.Controls.Add(this.btneditarusuario);
            this.Controls.Add(this.btnguardarusuario);
            this.Controls.Add(this.btnnuevousuario);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtapMaterno);
            this.Controls.Add(this.txtnombreusuario);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USUARIOS);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtapPaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btneliminarusuario;
        private System.Windows.Forms.Button btneditarusuario;
        private System.Windows.Forms.Button btnguardarusuario;
        private System.Windows.Forms.Button btnnuevousuario;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtapMaterno;
        private System.Windows.Forms.TextBox txtnombreusuario;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USUARIOS;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Button btnReporte;
    }
}