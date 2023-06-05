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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Crud_proyecto
{
    public partial class Form3 : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataset;
        public Form3()
        {
            InitializeComponent();

            string connectionString = "Data Source=DESKTOP-CAC615D;Initial Catalog=Licoreria;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                connection.Open();

                // Consulta para obtener los productos existentes
                string query = "SELECT Nombre_del_producto,Descripcion,Precio,Tipo_de_licor,Contenido FROM T_licoreria";
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                adapter.Fill(dataset, "T_licoreria");

                // Mostrar los datos en el DataGridView
                dataGridView1.DataSource = dataset.Tables["T_licoreria"];
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    text_nombre.Text = row.Cells["Nombre_del_producto"].Value.ToString();
                    text_Descripcion.Text = row.Cells["Descripcion"].Value.ToString();
                    text_precio.Text = row.Cells["Precio"].Value.ToString();
                    text_tipo.Text = row.Cells["Tipo_de_licor"].Value.ToString();
                    text_contenido.Text = row.Cells["Contenido"].Value.ToString();
                }
            }
            catch
            {

            }
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Obtener los valores de los TextBox
                string nombre = text_nombre.Text;
                string descripcion = text_Descripcion.Text;
                double precio = Convert.ToDouble(text_precio.Text);
                string tipo = text_tipo.Text;
                string contenido = text_contenido.Text;

                // Consulta para actualizar el producto en la base de datos
                string query = "UPDATE T_licoreria SET Nombre_del_producto = @nombre, Descripcion = @descripcion, Precio = @precio, Tipo_de_licor = @tipo, Contenido = @contenido WHERE  Descripcion = @descripcion";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@tipo", tipo);
                command.Parameters.AddWithValue("@contenido", contenido);
                command.ExecuteNonQuery();

                // Actualizar el DataGridView
                LoadData();

                // Limpiar los TextBox
                text_nombre.Text = string.Empty;
                text_Descripcion.Text = string.Empty;
                text_precio.Text = string.Empty;
                text_tipo.Text = string.Empty;
                text_contenido.Text = string.Empty;

                MessageBox.Show("Producto actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
