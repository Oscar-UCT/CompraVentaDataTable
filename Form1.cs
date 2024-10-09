using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CompraVenta
{
    public partial class VentasForm : Form
    {
        static int filaIndice = -1; // -1 significa que no hay filas
        static DataTable tablaPedidos = new DataTable("Pedidos");
        static Dictionary<string, double> preciosProductos = new Dictionary<string, double>()
        {
            {"Samsung A10", 180_000},
            {"Xiaomi Mi10T", 170_000},
            {"iPhone 16 Pro", 1_100_000},
            {"OnePlus 6 Pro", 170_000},
        };
        static double gananciasTotales = 0;

        public VentasForm()
        {
            InitializeComponent();
            CargarColumnas();
            tablaForm.DataSource = tablaPedidos;
        }

        static void CargarColumnas()
        {
            DataColumn columna = new DataColumn("ID", typeof(int));
            columna.Unique = true;
            columna.AutoIncrement = true;
            tablaPedidos.Columns.Add(columna);

            columna = new DataColumn("Nombre", typeof(string));
            tablaPedidos.Columns.Add(columna);

            columna = new DataColumn("RUT",typeof(string));
            tablaPedidos.Columns.Add(columna);

            columna = new DataColumn("Dirección", typeof(string));
            tablaPedidos.Columns.Add(columna);

            columna = new DataColumn("Producto", typeof(string));
            tablaPedidos.Columns.Add(columna);

            columna = new DataColumn("Medio de Pago", typeof(string));
            tablaPedidos.Columns.Add(columna);
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (FilaDuplicada())
            {
                MessageBox.Show("Fila Duplicada");
                return;
            }

            if (CamposValidos())
            {
                tablaPedidos.Rows.Add(
                    null,
                    nombreInput.Text,
                    rutInput.Text,
                    direccionInput.Text,
                    productoSelect.Text,
                    debitoSelect.Checked ? "Débito" : (creditoSelect.Checked ? "Crédito" : null)
                    );


                tablaForm.ClearSelection();
                filaIndice++;
                tablaForm.Rows[filaIndice].Selected = true;

                gananciasTotales += preciosProductos[productoSelect.Text];
                ventasOutput.Text = $"{gananciasTotales:C}";
            }
            else MessageBox.Show("Rellene todos los campos.");
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (filaIndice > -1)
            {
                DataRow filaSeleccionada = tablaPedidos.Rows[filaIndice];
                if (CamposValidos())
                {
                    gananciasTotales += preciosProductos[productoSelect.Text] - preciosProductos[filaSeleccionada["Producto"].ToString()];
                    ventasOutput.Text = $"{gananciasTotales:C}";


                    filaSeleccionada["Nombre"] = nombreInput.Text;
                    filaSeleccionada["RUT"] = rutInput.Text;
                    filaSeleccionada["Dirección"] = direccionInput.Text;
                    filaSeleccionada["Producto"] = productoSelect.Text;
                    filaSeleccionada["Medio de Pago"] = (debitoSelect.Checked ? "Débito" : "Crédito");

                }
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (filaIndice > -1)
            {
                DataRow filaSeleccionada = tablaPedidos.Rows[filaIndice];

                gananciasTotales -= preciosProductos[filaSeleccionada["Producto"].ToString()];
                ventasOutput.Text = $"{gananciasTotales:C}";
                tablaPedidos.Rows.RemoveAt(filaIndice);


                tablaForm.ClearSelection();
                filaIndice--;
                if (filaIndice > - 1)
                {
                    tablaForm.Rows[filaIndice].Selected = true;
                }
                else
                {
                    tablaForm.ClearSelection();
                }

            }
        }

        bool CamposValidos()
        {
            if (nombreInput.TextLength >= 2 &&
                direccionInput.TextLength >= 2 &&
                rutInput.TextLength == 9 &&
                productoSelect.SelectedItem != null &&
                (debitoSelect.Checked || creditoSelect.Checked)
                ) return true;
            else
                return false;
        }

        bool FilaDuplicada()
        {
            foreach (DataRow fila in tablaPedidos.Rows)
            {
                if (fila["Nombre"].ToString() == nombreInput.Text &&
                    fila["RUT"].ToString() == rutInput.Text &&
                    fila["Dirección"].ToString() == direccionInput.Text &&
                    fila["Producto"].ToString() == productoSelect.Text &&
                    fila["Medio de Pago"].ToString() == (debitoSelect.Checked ? "Débito" : "Crédito"))
                {
                    return true;
                }
            }
            return false;
        }

        private void tablaForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaIndice = e.RowIndex;
        }
    }
}
