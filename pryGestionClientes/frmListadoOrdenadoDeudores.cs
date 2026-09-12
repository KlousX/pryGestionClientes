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
    public partial class frmListadoOrdenadoDeudores : Form
    {
        public frmListadoOrdenadoDeudores()
        {
            InitializeComponent();
        }

        clsArchivoClientes objArchivoClientes = new clsArchivoClientes();

        private void frmListadoOrdenadoDeudores_Load(object sender, EventArgs e)
        {
            cboFiltrar.SelectedIndex = 0;
            cboOrdenar.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            objArchivoClientes.LeerArchivo();

            switch (cboFiltrar.SelectedIndex)
            {
                case 0:
                    if (cboOrdenar.SelectedIndex == 0)
                    {
                        objArchivoClientes.OrdenarCodigoAscendente();
                    }
                    else
                    {
                        objArchivoClientes.OrdenarCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cboOrdenar.SelectedIndex == 0)
                    {
                        objArchivoClientes.OrdenarNombreAscendente();
                    }
                    else
                    {
                        objArchivoClientes.OrdenarNombreDescendente();
                    }
                    break;
                case 2:
                    if (cboOrdenar.SelectedIndex == 0)
                    {
                        objArchivoClientes.OrdenarLimiteAscendente();
                    }
                    else
                    {
                        objArchivoClientes.OrdenarLimiteDescendente();
                    }
                    break;
                case 3:
                    if (cboOrdenar.SelectedIndex == 0)
                    {
                        objArchivoClientes.OrdenarDeudaAscendente();
                    }
                    else
                    {
                        objArchivoClientes.OrdenarDeudaDescendente();
                    }
                    break;
            }

            dgvListadoClientes.Rows.Clear();

            for (int i = 0; i < objArchivoClientes.indice; i++)
            {
                if (objArchivoClientes.clientes[i].deuda > 0)
                {
                    dgvListadoClientes.Rows.Add(
                        objArchivoClientes.clientes[i].codigo, 
                        objArchivoClientes.clientes[i].usuario, 
                        objArchivoClientes.clientes[i].limite, 
                        objArchivoClientes.clientes[i].deuda
                        );
                }
            }
        }
    }
}
