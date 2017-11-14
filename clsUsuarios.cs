using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class clsUsuarios:clsDatosgenerales
    {
        string strUser = "";
        public DataTable MuestraUsuarios() {
            strUser = "CALL paMuestraUser";
            DataTable dttblusuario = new DataTable();
            MySqlDataAdapter adap = new MySqlDataAdapter(strUser, ClsConexion.conectar);
            adap.Fill(dttblusuario);
            return dttblusuario;
        }

        public static int Agregar(clsDatosgenerales user)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tblusuarios (vch_Nombre, vch_apPat, vch_apMat, vch_Usuario, vch_Email, vch_Password) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}')",
                user.Nombre, user.appaterno, user.apmaterno, user.usuarioUser, user.Email, user.passwordUser), ClsConexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int Actualizar(clsDatosgenerales user)
        {
            int retorno = 0;
            MySqlConnection conexion = clsDatosgenerales.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update tblusuarios set vch_Nombre='{0}', vch_apPat='{1}', vch_apMat='{2}', vch_Usuario='{3}', vch_Email='{4}', vch_Password='{5}' where id_administrador={6}",
                user.Nombre, user.appaterno, user.apmaterno, user.usuarioUser, user.Email, user.passwordUser, user.Id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = ClsConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From tblusuarios where id_administrador={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
