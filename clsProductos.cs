using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class clsProductos:clsDatosgenerales
    {
        string strconsulta = "";

        public DataTable MuestraProductos() {
            strconsulta = "CALL paMuestraProductos";
            DataTable dttbProductos = new DataTable();
            MySqlDataAdapter adap = new MySqlDataAdapter(strconsulta, ClsConexion.conectar);
            adap.Fill(dttbProductos);
            return dttbProductos;
        }
        public static int Agregar(clsDatosgenerales product)
        {

            int retorno = 0;

            //product.Imagen = nuevo.ToString();
            //este es un mensaje
            //tengo varios problemas
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tblproductos (vch_nombre, vch_categoria, int_precio, vch_imagen, vch_descripcion) values ('{0}','{1}','{2}', '{3}', '{4}')",
                product.Nombre, product.Categoria, product.Precio, product.Imagen, product.Descripcion), ClsConexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int Actualizar(clsDatosgenerales product)
        {
            int retorno = 0;
            MySqlConnection conexion = clsDatosgenerales.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update tblproductos set vch_nombre='{0}', vch_categoria='{1}', int_precio='{2}', vch_imagen='{3}', vch_descripcion='{4}' where id_productos={5}",
                product.Nombre, product.Categoria, product.Precio, product.Imagen, product.Descripcion, product.Id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }


        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = ClsConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From tblproductos where id_productos={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
        public static List<clsDatosgenerales> categ()
        {
            List<clsDatosgenerales> lista = new List<clsDatosgenerales>();
            MySqlConnection conexion = ClsConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("select vch_categoria from tblcategoria", conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                clsDatosgenerales categ = new clsDatosgenerales();
                categ.Categoria = reader.GetString(0);
                lista.Add(categ);
            }
            return lista;
        }
        
    }
}
