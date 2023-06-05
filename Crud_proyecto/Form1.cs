using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frn = new Form2();
            frn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frn = new Form3();
            frn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frn = new Form4();
            frn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frn = new Form5();
            frn.Show();
        }
    }
}
