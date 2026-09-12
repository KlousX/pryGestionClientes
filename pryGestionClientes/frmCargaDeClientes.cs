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
    public partial class frmCargaDeClientes : Form
    {
        public frmCargaDeClientes()
        {
            InitializeComponent();
        }

        clsArchivoClientes objArchivoClientes = new clsArchivoClientes();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            objArchivoClientes.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Se ha cargado correctamente el cliente", "Carga de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            txtCodigo.Focus();

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDeuda.Clear();
            txtLimite.Clear();
        }
    }
}
