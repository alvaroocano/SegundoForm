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
        private string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\BaseDatos.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }

        public void insertarProyecto(TextBox desc, DateTimePicker fechaI, DateTimePicker fechaF, ComboBox est, TextBox presupI, TextBox presupF, ComboBox camb, TextBox client)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Proyectos (descripcion, fechaInicio, fechaFin, estado, presupuestoInicial, presupuestoActual, cambios, codCliente) VALUES (@Descripcion, @FechaInicio, @FechaFin, @Estado, @PresupuestoInicial, @PresupuestoActual, @Cambios, @CodigoCliente)";
            // Valores para los parámetros
            string descripcion = desc.Text;
            string fechaInicio = Convert.ToString(fechaI.Value);
            string fechaFin = Convert.ToString(fechaF.Value);
            string estado = Convert.ToString(est.ValueMember);
            double presupuestoInicial = Convert.ToDouble(presupI.Text);
            double presupuestoFinal = Convert.ToDouble(presupF.Text);
            string cambios = Convert.ToString(camb.ValueMember);
            string codigoCliente = client.Text;

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
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: { registrosAfectados}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }

        }

        public DataTable obtenerProyectos()
        {
            DataTable dtProyectos = new DataTable();

            // Cadena de conexión a la base de datos
            string connectionString = construirCadenaConexión();
            // Query para seleccionar todos los registros de la tabla Proyectos
            string query = "SELECT * FROM Proyectos";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un adaptador de datos y ejecutar la consulta
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dtProyectos);
                }
            }

            return dtProyectos;
        }

    }
}
