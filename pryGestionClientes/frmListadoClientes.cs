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
            lblMuestraPromedio.Text = objArchivoClientes.PromedioDeuda().ToString();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            objArchivoClientes.GenerarReporte();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            objArchivoClientes.OrdenarArchivo();
            MessageBox.Show("Archivo reescrito y ordenado por código de cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            objArchivoClientes.Listar(dgvListadoClientes);
        }
    }
}
