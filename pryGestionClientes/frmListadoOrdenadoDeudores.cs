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
            switch (cboFiltrar.SelectedIndex)
            {
                case 0:  
                    if (cboOrdenar.SelectedIndex == 0)
                    {
                        objArchivoClientes.OrdenarPorCodigoAscendente(dgvListadoClientes);
                    }
                    else
                    {
                        objArchivoClientes.OrdenarPorCodigoDescendente(dgvListadoClientes);
                    }
                    break;
                case 1:
                    
                    break;
                case 2:
                    
                    break;
            }
        }
    }
}
