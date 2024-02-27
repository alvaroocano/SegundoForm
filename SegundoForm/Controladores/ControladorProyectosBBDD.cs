using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm.Controladores
{
    internal class ControladorProyectosBBDD
    {
        public string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\BaseDatos.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            return connectionString;
        }

        public void insertarProyecto(TextBox desc, DateTimePicker fechaI, DateTimePicker fechaF, ComboBox est, TextBox presupI, TextBox presupF, ComboBox camb, TextBox client, CheckBox terminado)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Proyectos (descripcion, fechaInicio, fechaFin, estado, presupuestoInicial, presupuestoActual, cambios, codCliente, terminado) VALUES (@Descripcion, @FechaInicio, @FechaFin, @Estado, @PresupuestoInicial, @PresupuestoActual, @Cambios, @CodigoCliente, @Terminado)";
            // Valores para los parámetros
            string descripcion = desc.Text;
            string fechaInicio = Convert.ToString(fechaI.Value);
            string fechaFin = Convert.ToString(fechaF.Value);
            string estado = Convert.ToString(est.SelectedItem);
            double presupuestoInicial = Convert.ToDouble(presupI.Text);
            double presupuestoFinal = Convert.ToDouble(presupF.Text);
            string cambios = Convert.ToString(camb.SelectedItem);
            string codigoCliente = client.Text;
            bool term = terminado.Checked;

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    // No se añade a la inserción el campo código proyecto porque es autonumérico, aunque se puede configurar para poder
                    // insertarlo a la fuerza.
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@PresupuestoInicial", presupuestoInicial);
                    command.Parameters.AddWithValue("@PresupuestoActual", presupuestoFinal);
                    command.Parameters.AddWithValue("@Cambios", cambios);
                    command.Parameters.AddWithValue("@CodigoCliente", codigoCliente);
                    command.Parameters.AddWithValue("@Terminado", term);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }

        }

        public void CargarDatosEnDataGridView(DataGridView dataGridView, string proyectoSeleccionado)
        {
            string connectionString = construirCadenaConexión();
            string query;

            if (proyectoSeleccionado == "Todos")
            {
                query = "SELECT descripcion FROM Proyectos";
            }
            else
            {
                query = $"SELECT descripcion FROM Proyectos WHERE descripcion = '{proyectoSeleccionado}'";
            }

            try
            {
                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Establecer la conexión y ejecutar la consulta
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un SqlDataAdapter para obtener los datos de la consulta
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Llenar el DataTable con los datos obtenidos
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
            }
        }



        public void eliminarProyectosSeleccionados(DataGridView dataGridView)
        {
            // Lista para almacenar los IDs de los proyectos seleccionados
            List<int> idsProyectosAEliminar = new List<int>();

            // Iterar sobre las filas del DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Verificar si la fila está seleccionada y el checkbox de "Eliminar" está marcado
                DataGridViewCheckBoxCell checkbox = row.Cells["Eliminar"] as DataGridViewCheckBoxCell;
                if (checkbox != null && Convert.ToBoolean(checkbox.Value))
                {
                    // Obtener el ID del proyecto de la fila actual
                    int idProyecto = Convert.ToInt32(row.Cells["codigoDataGridViewTextBoxColumn"].Value);
                    // Agregar el ID a la lista de IDs de proyectos a eliminar
                    idsProyectosAEliminar.Add(idProyecto);
                }
            }

            // Verificar si hay proyectos seleccionados para eliminar
            if (idsProyectosAEliminar.Count > 0)
            {
                // Cadena de conexión a la base de datos
                string connectionString = construirCadenaConexión();

                // Query para eliminar los proyectos seleccionados
                string query = "DELETE FROM Proyectos WHERE codigo IN (" + string.Join(",", idsProyectosAEliminar) + ")";

                // Crear la conexión y ejecutar la consulta de eliminación
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int registrosEliminados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se eliminaron correctamente {registrosEliminados} proyectos.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado proyectos para eliminar.");
            }
        }

        public void CargarUsuariosEnComboBox(ComboBox comboBox)
        {
            string connectionString = construirCadenaConexión();
            string query = "SELECT descripcion FROM Proyectos";

            // Limpiar ComboBox
            comboBox.Items.Clear();
            comboBox.Items.Add("Todos"); // Agregar opción "Todos"

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader["descripcion"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar usuarios: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

    }
}
