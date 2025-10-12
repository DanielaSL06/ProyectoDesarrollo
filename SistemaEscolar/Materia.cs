using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class Materia : Form
    {
        // Conexión a la base de datos "Catalogos".
        public string ConexionCatalogos = "Server=DAVID\\SQLEXPRESS;"
                            + " Database=Catalogos;"
                            + " Integrated Security=True; "
                            + " TrustServerCertificate=True";

        // Variable para almacenar el ID de la materia seleccionada en el DataGridView.
        private int idMateriaSeleccionada = 0;

        public Materia()
        {
            InitializeComponent();
        }
        private void Materia_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void CargarMaterias()
        {
            try
            {
                // Usamos 'using' para que la conexión se cierre sola
                using (SqlConnection conexion = new SqlConnection(ConexionCatalogos))
                {
                    // 1. Abrimos la conexión a la base de datos
                    conexion.Open();

                    // 2. Consulta SQL
                    string consulta = "SELECT [id_materia] " + 
                        " ,[nombre_materia], [creditos]" + " FROM [Catalogos].[dbo].[Materia]";

                    // 3. El SqlDataAdapter ejecuta la consulta y guarda los resultados
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                    // 4. Creamos una tabla en memoria para almacenar los datos.
                    DataTable tablaMaterias = new DataTable();

                    // 5. Llenamos nuestra tabla en memoria con los resultados de la consulta.
                    adaptador.Fill(tablaMaterias);
                    
                    //mensaje para saber cuantas lineas se cargaron
                    //MessageBox.Show($"Se cargaron {tablaMaterias.Rows.Count} filas desde la base de datos.");
                    
                    // 6. Le decimos al DataGridView que muestre los datos de nuestra tabla.
                    dgvMaterias.DataSource = tablaMaterias;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las materias: " + ex.Message);
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionCatalogos))
                {
                    conexion.Open();

                    // Usamos @parametros para evitar ataques de inyección SQL.
                    string consulta = "INSERT INTO Materia (nombre_materia, creditos, fecha_hora_creacion) VALUES (@nombre, @creditos, GETDATE())";

                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    // Le damos valor a los parámetros con el texto de los TextBox.
                    comando.Parameters.AddWithValue("@nombre", txtNombreMateria.Text);
                    comando.Parameters.AddWithValue("@creditos", int.Parse(txtCreditos.Text));

                    // ExecuteNonQuery se usa para comandos que no devuelven filas (INSERT, UPDATE, DELETE).
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Materia agregada correctamente.");
                }

                // Después de agregar, volvemos a cargar la tabla para ver el nuevo registro.
                CargarMaterias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la materia: " + ex.Message);
            }
        }
        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya hecho clic en una fila válida.
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                // Obtiene la fila donde se hizo el clic.
                DataGridViewRow fila = dgvMaterias.SelectedRows[0];

                // Copia los valores de las celdas a los TextBox correspondientes.
                txtNombreMateria.Text = fila.Cells["nombre_materia"].Value.ToString();
                txtCreditos.Text = fila.Cells["creditos"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1. Verifica si hay una fila seleccionada.
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                // --- INICIA LA VALIDACIÓN ---
                int creditos;
                // 2. Intenta convertir el texto de los créditos a un número.
                if (int.TryParse(txtCreditos.Text, out creditos))
                {
                    // 3. Si la conversión es exitosa, procede con la actualización.
                    try
                    {
                        int idParaEditar = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["id_materia"].Value);

                        using (SqlConnection conexion = new SqlConnection(ConexionCatalogos))
                        {
                            conexion.Open();
                            string consulta = "UPDATE Materia SET nombre_materia = @nombre, creditos = @creditos WHERE id_materia = @id";

                            SqlCommand comando = new SqlCommand(consulta, conexion);
                            comando.Parameters.AddWithValue("@nombre", txtNombreMateria.Text);
                            // Usa la variable 'creditos' que ya fue validada.
                            comando.Parameters.AddWithValue("@creditos", creditos);
                            comando.Parameters.AddWithValue("@id", idParaEditar);

                            comando.ExecuteNonQuery();
                            MessageBox.Show("Materia actualizada correctamente.");
                        }

                        CargarMaterias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message);
                    }
                }
                else
                {
                    // 4. Si la conversión falla, informa al usuario de manera clara.
                    MessageBox.Show("El valor en el campo 'Créditos' debe ser un número válido y no puede estar vacío.");
                }
                // --- TERMINA LA VALIDACIÓN ---
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa para editar.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                try
                {
                    // 2. Obtiene el ID directamente de la fila seleccionada usando el nombre de columna CORRECTO.
                    int idEliminar = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["id_materia"].Value);

                    // Pedimos confirmación al usuario antes de borrar.
                    var resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {

                        using (SqlConnection conexion = new SqlConnection(ConexionCatalogos))
                        {
                            conexion.Open();
                            string consulta = "DELETE FROM Materia WHERE id_materia = @id";

                            SqlCommand comando = new SqlCommand(consulta, conexion);
                            comando.Parameters.AddWithValue("@id", idEliminar);

                            comando.ExecuteNonQuery();
                            MessageBox.Show("Materia eliminada correctamente.");
                        }

                        CargarMaterias();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la materia: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa para eliminar.");
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

