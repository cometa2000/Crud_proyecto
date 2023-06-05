using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crud_proyecto
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=DESKTOP-CAC615D;Initial Catalog=Licoreria;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT * FROM T_licoreria", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el ID del producto a eliminar desde el TextBox
            int productId;
            if (!int.TryParse(txtProductId.Text, out productId))
            {
                MessageBox.Show("Ingrese un ID de producto válido.");
                return;
            }

            // Eliminar el producto de la base de datos
            string deleteQuery = "DELETE FROM T_licoreria WHERE id_producto = @ID";
            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ID", productId);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado correctamente.");

                    // Actualizar el DataGridView después de eliminar el producto
                    dataTable.Clear();
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }
    }
}
