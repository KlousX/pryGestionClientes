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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsArchivoClientes objArchivoClientes = new clsArchivoClientes();

        private void btnListar_Click(object sender, EventArgs e)
        {
            objArchivoClientes.Listar(dgvListadoClientes);
            lblMuestraQ.Text = objArchivoClientes.CantidadClientes().ToString();
            lblMuestraTotal.Text = objArchivoClientes.TotalDeuda().ToString();
        }
    }
}
