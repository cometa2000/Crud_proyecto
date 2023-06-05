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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-CAC615D;Initial Catalog=Licoreria;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = text_nombre.Text;
            string descripcion = text_descripcion.Text;
            double precio = Convert.ToDouble(text_precio.Text);
            string tipo = text_tipo.Text;
            string contenido = textcontenido.Text;


            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(Convert.ToString(precio)) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(contenido))
            {
                MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para insertar un nuevo registro en la tabla
                    string query = "INSERT INTO T_licoreria (Nombre_del_producto, Descripcion, Precio, Tipo_de_licor, Contenido) VALUES (@nombre, @descripcion, @precio, @tipo, @contenido)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@contenido", contenido);


                    command.ExecuteNonQuery();

                    MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos después de agregar el usuario
                    text_nombre.Text = "";
                    text_descripcion.Text = "";
                    text_precio.Text = "";
                    text_tipo.Text = "";
                    textcontenido.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM View_licoreria";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            rdr.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
