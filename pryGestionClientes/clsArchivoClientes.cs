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
        public string nombreArchivo = "Clientes.csv";

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
        
        public void Listar(DataGridView dgv)
        {
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

            return result;
        }

        public decimal TotalDeuda()
        {
            decimal result = 0;
            string datosLeidos = "";

            StreamReader leerDatos = new StreamReader(nombreArchivo);

            string[] vectorDatos = new string[4];

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');
                result += Convert.ToDecimal(vectorDatos[2]);
                datosLeidos = leerDatos.ReadLine();
            }

            return result;
        }

        public decimal PromedioDeuda()
        {
            decimal result = 0;
            string datosLeidos = "";

            StreamReader leerDatos = new StreamReader(nombreArchivo);

            string[] vectorDatos = new string[4];

            while (datosLeidos != null)
            {
                vectorDatos = datosLeidos.Split(';');
                result = result / 4;
                datosLeidos = leerDatos.ReadLine();
            }

            return result;
        }
    }
}
