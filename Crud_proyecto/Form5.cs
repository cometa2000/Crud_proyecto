using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_proyecto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-CAC615D;Initial Catalog=Licoreria;Integrated Security=True";
        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT Nombre_del_producto AS Nombre,Descripcion,Precio,Tipo_de_licor AS [Tipo de licor],Contenido FROM T_licoreria";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            rdr.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
