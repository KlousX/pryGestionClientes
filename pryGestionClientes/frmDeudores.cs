using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientes
{
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }

        clsArchivoClientes objArchivoClientes = new clsArchivoClientes();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objArchivoClientes.ListarDeudores(dgvListadoClientes);
            lblMuestraTotal.Text = objArchivoClientes.TotalDeuda().ToString();
            lblMuestraQ.Text = objArchivoClientes.CantidadDeudores().ToString();
            lblMuestraPromedio.Text = objArchivoClientes.PromedioDeuda().ToString();
        }
    }
}
