using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            tmrSplash.Interval = 2010;
            tmrSplash.Enabled = true;
            tmrSplash.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmRptProductos().Show();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            this.Hide();
            new clsInicio();
            tmrSplash.Stop();
        }
    }
}
