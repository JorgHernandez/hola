using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class clsDatosgenerales:ClsConexion
    {


        public int Id { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        
        public string Categoria { get; set; }
        public int Precio { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public string appaterno { get; set; }
        public string apmaterno { get; set; }
        public string telefonoProv { get; set; }
        public string direccionPro { get; set; }
        public string usuarioUser { get; set; }
        public string passwordUser { get; set; }
        public virtual void ALTAS()
        {
        }

        public clsDatosgenerales() { }

        public clsDatosgenerales(int id, string nombre, string apdoPat, string apdoMat, string categoria, int precio, string imagen, string direccion, string telefono, string UsuarioUs, string email, string passUs)
        {

            this.Id = id;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Precio = Precio;
            this.Imagen = @imagen;
            this.Descripcion = Descripcion;

            this.apmaterno = apdoMat;
            this.appaterno = apdoPat;
            this.telefonoProv = telefono;
            this.direccionPro = direccion;

            this.usuarioUser = UsuarioUs;
            this.Email = email;
               
            this.passwordUser = passwordUser;

        }
        public string usr { get; set; }

        public clsDatosgenerales(string ursd)
        {
            this.usr = ursd;
        }

    }
}
