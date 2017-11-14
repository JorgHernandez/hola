using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    class clsInicio:System.Windows.Forms.ApplicationContext
    {
        public clsInicio()
        {
            bool conecta;
            string sFileName = Path.Combine(Application.StartupPath, @"cnn\sysinit.ini");
            if (File.Exists(sFileName))
            {
                FileStream fs = new FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                string sContent = sr.ReadToEnd();
                ClsConexion.Cadenadesencriptada = clsDatos.DesEncriptar(sContent);
                if (ClsConexion.Cadenadesencriptada==string.Empty)
                {
                    new frmConfiguracion().Show();
                }
                else
                {
                    conecta = ClsConexion.AbrirConexion();
                    if (conecta==true)
                    {
                        new frmLogin().Show();
                    }
                    else
                    {
                        new frmConfiguracion().Show();
                    }
                }
                fs.Close();
                sr.Close();
            }
            else
            {
                new frmConfiguracion().Show();
            }
        }
    }
}
