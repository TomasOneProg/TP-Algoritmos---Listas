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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            AltaVendedores AV = new AltaVendedores();
            AV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();

            AltaProductos AP = new AltaProductos();
            AP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            AltaClientes AC = new AltaClientes();
            AC.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturación Fac = new Facturación();
            Fac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularioInformes FI = new FormularioInformes();
            FI.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
