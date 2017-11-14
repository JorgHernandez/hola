using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class clsProveedores:clsDatosgenerales
    {
        string strconsulta = "";

        public DataTable MuestraProveedor()
        {
            strconsulta = "CALL paMuestraProveedor";
            DataTable dttbProveedor = new DataTable();
            MySqlDataAdapter adap = new MySqlDataAdapter(strconsulta, ClsConexion.conectar);
            adap.Fill(dttbProveedor);
            return dttbProveedor;
        }
        public static int Agregar(clsDatosgenerales prove)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tblproveedor (vch_nombre, vch_apPat, vch_apMat, vch_telefono, vch_Direccion) values ('{0}','{1}','{2}', '{3}', '{4}')",
                prove.Nombre, prove.apmaterno, prove.appaterno, prove.telefonoProv, prove.direccionPro), ClsConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static int Actualizar(clsDatosgenerales prove)
        {
            int retorno = 0;
            MySqlConnection conexion = clsDatosgenerales.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update tblproveedor set vch_nombre='{0}', vch_apPat='{1}', vch_apMat='{2}', vch_telefono='{3}', vch_Direccion='{4}' where Id_proveedor={5}",
                prove.Nombre, prove.apmaterno, prove.appaterno, prove.telefonoProv, prove.direccionPro, prove.Id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = ClsConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From tblproveedor where Id_proveedor={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
        
    }
}
