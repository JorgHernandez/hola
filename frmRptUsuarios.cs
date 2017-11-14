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
    public partial class frmRptUsuarios : Form
    {
        public frmRptUsuarios()
        {
            InitializeComponent();
        }

        private void frmRptUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsUsuarios.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.dtsUsuarios.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
