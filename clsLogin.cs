using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Prueba
{
    class clsLogin
    {
        public string user { get; set; }
        public string pass { get; set; }
        public bool ingresar()
        {
            string cadena = "select * from tblusuarios where vch_Usuario = '" +this.user + "'and vch_Password='" + this.pass + "' ";
            ClsConexion.AbrirConexion();
            MySqlDataReader leer;
            ClsConexion.comando = new MySqlCommand(cadena, ClsConexion.conectar);
            leer = ClsConexion.comando.ExecuteReader();
            if (leer.Read())
            {
                ClsConexion.CerrarConexion();
                return true;
            }
            else
            {
                ClsConexion.CerrarConexion();
                return false;
            }
            
        }
    }
 
}
