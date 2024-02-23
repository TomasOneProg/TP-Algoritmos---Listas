using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmos
{
    internal class ClaseParaClientes
    {
        public static List<Totales2> ventasxcliente = new List<Totales2>();


        public static void Calcular(double MF, double Porc)
        {
            ventasxcliente.Clear();
            int l = Clase06.Listados.Count;
            for (int i = 0; i < l; i++)
            {
                string Ven = Clase06.Listados[i].Cliente;
                double Val = Clase06.Listados[i].Total_A_Pagar;
                acumular(Ven, Val);
            }
        }

        private static void acumular(string ven, double val)
        {
            bool encontrado = false;
            int l = ventasxcliente.Count;
            for (int i = 0; i < l; i++)
            {
                if (ventasxcliente[i].Cliente.Contains(ven))
                {
                    encontrado = true;
                    ventasxcliente[i].Total = ventasxcliente[i].Total + val;
                }
            }
            if (encontrado == false)
            {
                ventasxcliente.Add(new Totales2() { Cliente = ven, Total = val });
            }
        }
    }

    public class Totales2
    {
        public string Cliente { get; set; }
        public double Total { get; set; }

    }
}
