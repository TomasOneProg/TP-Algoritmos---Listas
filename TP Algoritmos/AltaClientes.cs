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
    public partial class AltaClientes : Form
    {
        public AltaClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase04.Cliente.Remove(listBox1.SelectedValue.ToString());
            Actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clase04.Cliente.Add(Convert.ToString(textBox1.Text));
            Clase04.Cliente.Sort();
            Actualizar();
        }

        public void Actualizar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Clase04.Cliente;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Main = new Form1();
            Main.Show();
        }
    }
}
