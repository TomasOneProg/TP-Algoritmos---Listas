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
    public partial class FormularioInformes : Form
    {
        private double A;
        private double B;
        private double C;
        private double D;
        private double E;
        private double F;

        public static List<Totales> ventasxVendeor = new List<Totales>();

        public FormularioInformes(double AA, double BB, double CC, double DD, double EE, double FF)
        {

            A = AA;
            B = BB;
            C = CC;
            D = DD;
            E = EE;
            F = FF;


            InitializeComponent();
        }

        public FormularioInformes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Facturación Fac = new Facturación();
            Fac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClaseParaVendedores.Calcular(A, B);
            dataGridView1.DataSource = ClaseParaVendedores.ventasxVendeor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseParaClientes.Calcular(C, D);
            dataGridView1.DataSource = ClaseParaClientes.ventasxcliente;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClaseParaProducto.Calcular(E, F);
            dataGridView1.DataSource = ClaseParaProducto.ventasxproducto;
        }

        private void FormularioInformes_Load(object sender, EventArgs e)
        {

        }
    }
}
