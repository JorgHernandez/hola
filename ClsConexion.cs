using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    class ClsConexion
    {
        public static MySqlConnection conectar;
        public static MySqlCommand comando;

        public static string bd { get; set; }
        public static string servidor { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public static string Cadenadesencriptada { get; set; }

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server = localhost; user id = root; database = bd_uclas; password = root");

            conectar.Open();
            return conectar;
        }
        static public bool AbrirConexion()
        {
            try
            {

                conectar = new MySqlConnection(Cadenadesencriptada);
                conectar.Open();
                // System.Windows.Forms.MessageBox.Show("Conexion Establecida!!!");
                return true;
            }
            catch
            {
                MessageBox.Show("No se pudo conectar!!!");
                return false;
            }
        }

        public static bool CerrarConexion()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static void creararchivo()
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, @"cnn");
                string fileName = Path.Combine(Application.StartupPath, @"cnn\sysinit.ini");
                DirectoryInfo di = new DirectoryInfo(path);
                if (!di.Exists)
                {
                    di.Create();
                    FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    string cadena = "Server=" + servidor + ";Database=" + bd + "; User Id=" + user + ";Password=" + password;
                    string cadenaencriptada = clsDatos.Encriptar(cadena);
                    writer.WriteLine(cadenaencriptada);
                    writer.Close();
                }
                else
                {
                    File.Delete(fileName);
                    Directory.Delete(path);
                    Directory.CreateDirectory(path);

                    FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream);
                    string cadena = "Server=" + servidor + ";Database=" + bd + "; User Id=" + user + ";Password=" + password;
                    string cadenaencriptada = clsDatos.Encriptar(cadena);
                    writer.WriteLine(cadenaencriptada);
                    writer.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio el siguente error: " + ex.Message);
            }

            ///AGREGAR VALIDACION EN CASO DE QUE EXISTA LA CARPETA
        }
    }
}
