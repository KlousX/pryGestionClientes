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

        private void OrdenarVector()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[i].codigo > clientes[i + 1].codigo)
                    {
                        aux = clientes[i];
                        clientes[i] = clientes[i + 1];
                        clientes[i + 1] = aux;
                    }
                }
            }
        }

        public void ReescribirArchivo()
        {
            StreamWriter AD = new StreamWriter(nombreArchivo, false);

            for (int i = 0; i < indice; i++)
            {
                AD.Write(clientes[i].codigo);
                AD.Write(";");
                AD.Write(clientes[i].usuario);
                AD.Write(";");
                AD.Write(clientes[i].deuda);
                AD.Write(";");
                AD.WriteLine(clientes[i].limite);
            }

            AD.Close();
            AD.Dispose();
        }

        public void OrdenarArchivo()
        {
            PasarDatos();
            OrdenarVector();
            ReescribirArchivo();
        }

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

        private void PasarDatos()
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
            decimal result;
            decimal resultado = 0;
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

            if(cantidadClientes != 0)
            {
                int resultado = result / cantidadClientes;
            }
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

        public void GenerarReporte()
        {
            string DatosLeidos = "";
            string[] VecDatos = new string[4];

            Int32 cantidad = 0;
            Decimal total = 0;

            // Asegurate de tener el using System.Text; arriba del todo para el Encoding.UTF8(perimite los acentos)
            StreamWriter Reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);

            Reporte.WriteLine("");
            Reporte.WriteLine("Listado de Clientes");
            Reporte.WriteLine("");
            // Corregí el orden acá para que coincida con lo que se imprime abajo
            Reporte.WriteLine("Código;Nombre;Límite;Deuda");

            StreamReader AD = new StreamReader(nombreArchivo);

            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                Reporte.Write(VecDatos[0]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[2]);
                Reporte.Write(";");
                Reporte.WriteLine(VecDatos[3]);

                cantidad++;
                total = total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            Reporte.WriteLine("");
            Reporte.Write("Total de Deuda:;;");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de Clientes:;;");
            Reporte.WriteLine(cantidad);
            Reporte.Write("Promedio de Deuda:;;");

            Reporte.Close();
            Reporte.Dispose();
        }

        


        public void OrdenarPorCodigoAscendente(DataGridView Grilla)
        {
            PasarDatos();

            RegCliente aux;
            
            for (int i = 0; i < indice - 1;i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[j].codigo > clientes[j + 1].codigo)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }

            Grilla.Rows.Clear();
            for (int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }

        public void OrdenarPorCodigoDescendente(DataGridView Grilla)
        {
            PasarDatos();

            RegCliente aux;

            for(int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[j].codigo < clientes[j + 1].codigo)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }

            Grilla.Rows.Clear();
            for(int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }

        public void OrdenarPorNombreAscendente(DataGridView Grilla)
        {
            
            PasarDatos();
            RegCliente aux;
            
            for (int i = 0; i < indice - 1; i++)
            {
                for(int j = 0; j < indice - 1; j++)
                {
                    if (string.Compare(clientes[j].usuario, clientes[j + 1].usuario) > 0)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }

            Grilla.Rows.Clear();
            for (int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }

        public void OrdenarPorNombreDescendente(DataGridView Grilla)
        {
            PasarDatos();
            RegCliente aux;

            for(int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (string.Compare(clientes[j].usuario, clientes[j + 1].usuario) < 0)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }

            Grilla.Rows.Clear();

            for (int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }


        public void OrdenarPorDeudaAscendente(DataGridView Grilla)
        {
            PasarDatos();

            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[j].deuda > clientes[j + 1].deuda)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }

            Grilla.Rows.Clear();
            for (int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }

        public void OrdenarPorDeudaDescendente(DataGridView Grilla)
        {
            PasarDatos();

            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[j].deuda < clientes[j + 1].deuda)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }

            Grilla.Rows.Clear();
            for (int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }

        public void OrdenarPorLimiteAscendente(DataGridView Grilla)
        {
            PasarDatos();
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[j].limite > clientes[j + 1].limite)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }

            }

            Grilla.Rows.Clear();

            for (int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }

        public void OrdenarPorLimiteDescendente(DataGridView Grilla)
        {
            PasarDatos();
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[j].limite < clientes[j + 1].limite)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }

            }

            Grilla.Rows.Clear();

            for (int i = 0; i < indice; i++)
            {
                Grilla.Rows.Add(clientes[i].codigo, clientes[i].usuario, clientes[i].deuda, clientes[i].limite);
            }
        }
    }
}
