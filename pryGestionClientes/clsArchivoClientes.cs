using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientes
{
    internal class clsArchivoClientes
    {
        public struct RegCliente
        {
            public int codigo;
            public string usuario;
            public decimal deuda;
            public decimal limite;
        }

        public string nombreArchivo = "Clientes.csv";

        public  RegCliente[] clientes = new RegCliente[100];
        public int indice = 0;

        public void Grabar(String cod, String nom, String deu, String lim)
        {
            StreamWriter agregarDatos = new StreamWriter(nombreArchivo, true);

            agregarDatos.Write(cod);
            agregarDatos.Write(";");
            agregarDatos.Write(nom);
            agregarDatos.Write(";");
            agregarDatos.Write(deu);
            agregarDatos.Write(";");
            agregarDatos.WriteLine(lim);

            agregarDatos.Close();
            agregarDatos.Dispose();
        }

        public void LeerArchivo()
        {
            indice = 0;

            StreamReader leerDatos = new StreamReader(nombreArchivo);
            string datosLeidos = leerDatos.ReadLine();

            while (datosLeidos != null)
            {
                string[] vectorDatos = datosLeidos.Split(';');
                
                clientes[indice].codigo = Convert.ToInt32(vectorDatos[0]);
                clientes[indice].usuario = vectorDatos[1];
                clientes[indice].deuda = Convert.ToDecimal(vectorDatos[2]);
                clientes[indice].limite = Convert.ToDecimal(vectorDatos[3]);
                indice++;
                datosLeidos = leerDatos.ReadLine();
            }

            leerDatos.Close();
            leerDatos.Dispose();
        }
        
        public void Listar(DataGridView dgv)
        {
            //Preguntar al profe porque declaramos datosLeidos "" y despues le asignamos el valor de leerDatos.ReadLine() y no directamente en la declaracion
            string datosLeidos = "";
            string[] vectorDatos = new string[4];

            StreamReader leerDatos = new StreamReader(nombreArchivo);
            datosLeidos = leerDatos.ReadLine();

            dgv.Rows.Clear();

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');

                dgv.Rows.Add(vectorDatos[0], vectorDatos[1], vectorDatos[2], vectorDatos[3]);

                datosLeidos = leerDatos.ReadLine();
            }

            leerDatos.Close();
            leerDatos.Dispose();
        }

        public int CantidadClientes()
        {
            int result = -1;
            string datosLeidos = "";
            StreamReader leerDatos = new StreamReader(nombreArchivo);

            while (datosLeidos != null)
            {
                datosLeidos = leerDatos.ReadLine();
                result++;
            }

            leerDatos.Close();
            leerDatos.Dispose();

            return result;
        }

        public Decimal TotalDeuda()
        {
            Decimal result = 0;
            string datosLeidos = "";

            StreamReader leerDatos = new StreamReader(nombreArchivo);

            string[] vectorDatos = new string[4];
            datosLeidos = leerDatos.ReadLine();

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');
                result = result + Convert.ToDecimal(vectorDatos[2]);
                datosLeidos = leerDatos.ReadLine();
            }

            leerDatos.Close();
            leerDatos.Dispose();

            return result;
        }

        public decimal PromedioDeuda()
        {
            decimal result = 0;
            string datosLeidos = "";
            Int32 cantidadClientes = 0;

            StreamReader leerDatos = new StreamReader(nombreArchivo);

            string[] vectorDatos = new string[4];
            datosLeidos = leerDatos.ReadLine();

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');

                result = result + Convert.ToDecimal(vectorDatos[2]);
                datosLeidos = leerDatos.ReadLine();
                cantidadClientes++;
            }

             

            leerDatos.Close();
            leerDatos.Dispose();

            return result / cantidadClientes;
        }

        public void ListarDeudores(DataGridView dgvListadoClientes)
        {
            string datosLeidos = "";

            StreamReader leerDatos = new StreamReader(nombreArchivo);

            string[] vectorDatos = new string[4];
            datosLeidos = leerDatos.ReadLine();

            dgvListadoClientes.Rows.Clear();

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');

                if (Convert.ToDecimal(vectorDatos[2]) > 0)
                {
                    dgvListadoClientes.Rows.Add(
                        vectorDatos[0], 
                        vectorDatos[1], 
                        vectorDatos[2], 
                        vectorDatos[3]
                        );
                }
                datosLeidos = leerDatos.ReadLine();
            }

            leerDatos.Close();
            leerDatos.Dispose();

        }

        public decimal CantidadDeudores()
        {
            string datosLeidos = "";
            Int32 cantidadClientes = 0;

            StreamReader leerDatos = new StreamReader(nombreArchivo);

            string[] vectorDatos = new string[4];
            datosLeidos = leerDatos.ReadLine();

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');
                if(Convert.ToDecimal(vectorDatos[2]) > 0)
                {
                    cantidadClientes++;
                }

                datosLeidos = leerDatos.ReadLine();
            }

            leerDatos.Close();
            leerDatos.Dispose();

            return cantidadClientes;
        }

        public decimal PromedioDeudores()
        {
            string datosLeidos = "";
            Int32 cantidadClientes = 0;
            Decimal total = 0;

            StreamReader leerDatos = new StreamReader(nombreArchivo);

            string[] vectorDatos = new string[4];
            datosLeidos = leerDatos.ReadLine();

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');
                if (Convert.ToDecimal(vectorDatos[2]) > 0)
                {
                    cantidadClientes++;

                    total += Convert.ToDecimal(vectorDatos[2]);
                }

                datosLeidos = leerDatos.ReadLine();
            }

            leerDatos.Close();
            leerDatos.Dispose();

            return total / cantidadClientes;
        }

        public void OrdenarCodigoAscendente()
        {

            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].codigo > clientes[k + 1].codigo)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }
                }
            }
        }

        public void OrdenarCodigoDescendente()
        {

            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].codigo < clientes[k + 1].codigo)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }
                }
            }
        }

        public void OrdenarNombreAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].usuario.CompareTo(clientes[k + 1].usuario) > 0)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarNombreDescendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].usuario.CompareTo(clientes[k + 1].usuario) < 0)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarDeudaAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].deuda > clientes[k + 1].deuda)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarDeudaDescendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].deuda < clientes[k + 1].deuda)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }

        public void OrdenarLimiteAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].limite > clientes[k + 1].limite)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }


        public void OrdenarLimiteDescendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (Int32 k = 0; k < indice - 1; k++)
                {
                    if (clientes[k].limite < clientes[k + 1].limite)
                    {
                        aux = clientes[k];
                        clientes[k] = clientes[k + 1];
                        clientes[k + 1] = aux;
                    }

                }
            }
        }
    }
}
