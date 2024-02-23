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
    public partial class Facturación : Form
    {
        bool IVA = false;
        public Facturación()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();

            AltaVendedores AV = new AltaVendedores();
            AV.Show();
        }

        private void Facturación_Load(object sender, EventArgs e)
        {
            txtganancia.Text = Convert.ToString(30);
            txtIVA.Text = Convert.ToString(21);
            lblCosto.Hide();
            AltaVendedores formulario01 = new AltaVendedores();
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Clase01.Vendedor.ToArray());
            comboBox3.SelectedIndex = 0;
            comboBox2.DataSource = Clase03.BaseProductos;
            comboBox2.DisplayMember = "NombreProducto";
            AltaClientes formulario03 = new AltaClientes();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Clase04.Cliente.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ValorGanancia = Convert.ToInt32(txtganancia.Text);
            double valor = 0;
            double CostoTotal = 0;
            double PreGanancia = 0;
            double Ganancia = 0;
            double VentaTotal = 0;
            double TotalPagar = 0;
            
            int IVAValor = Convert.ToInt32(txtIVA.Text);
            int Cantidad = Convert.ToInt32(numericUpDown1.Text);
            double PreIVAValorResultante = 0;
            double IVAValorResultante = 0;
            for (int i = 0; i < Clase03.BaseProductos.Count; i++) {
                if(Clase03.BaseProductos[i].NombreProducto == comboBox2.Text)
                {
                    valor = Clase03.BaseProductos[i].Valor;
                    break;
                }
            }

            CostoTotal = valor * Cantidad;
            PreGanancia = CostoTotal * ValorGanancia;
            Ganancia = PreGanancia / 100;
            VentaTotal = CostoTotal + Ganancia;

            if (IVA == true)
            {
                PreIVAValorResultante = VentaTotal * IVAValor;
                IVAValorResultante = PreIVAValorResultante / 100;

            }
            else if (IVA == false)
            {

            }

            TotalPagar = IVAValorResultante + VentaTotal;

            Clase06.Listados.Add(new Clase05()
            {
                Vendedor = comboBox3.Text,
                Cantidad = Convert.ToInt32(numericUpDown1.Text),
                NombreProducto = comboBox2.Text,
                Cliente = comboBox1.Text,
                CostoUnitario = valor,
                CostoTotal = CostoTotal,
                VentaTotal = VentaTotal,
                ValorIVA = IVAValorResultante, 
                Total_A_Pagar = TotalPagar,
                Fecha = Convert.ToString(dateTimePicker1.Value.ToLongDateString()),
            });

            Actualizacion();


            label12.Text = Convert.ToString(VentaTotal);
            label13.Text = Convert.ToString(IVAValorResultante);
            label14.Text = Convert.ToString(TotalPagar);

        }

        private void Actualizacion()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Clase06.Listados;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                IVA = true;
            }
        }

        private void txtganancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            AltaClientes AC = new AltaClientes();
            AC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();

            AltaProductos AP = new AltaProductos();
            AP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            FormularioInformes FII = new FormularioInformes();
            FII.Show();


        }
    }
}
