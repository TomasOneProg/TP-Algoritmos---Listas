using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Algoritmos
{
    public partial class AltaProductos : Form
    {
        public AltaProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase03.BaseProductos.Add(new Clase02()
            {
                NombreProducto = Convert.ToString(textBox1.Text),

                Valor = Convert.ToInt32(textBox2.Text),

            });
            Actualizacion();
        }

        private void Actualizacion()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Clase03.BaseProductos;
        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Clase03.BaseProductos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Main = new Form1();
            Main.Show();
        }
    }
}
