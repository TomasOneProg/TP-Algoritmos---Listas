using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmos
{
    internal class ClaseParaVendedores
    {
        public static List<Totales> ventasxVendeor = new List<Totales>();


        public static void Calcular(double MF, double Porc)
        {
            ventasxVendeor.Clear();
            int l = Clase06.Listados.Count;
            for (int i = 0; i < l; i++)
            {
                string Ven = Clase06.Listados[i].Vendedor;
                double Val = Clase06.Listados[i].Total_A_Pagar;
                acumular(Ven, Val);
            }
        }

        private static void acumular(string ven, double val)
        {
            bool encontrado = false;
            int l = ventasxVendeor.Count;
            for (int i = 0; i < l; i++)
            {
                if (ventasxVendeor[i].Vendedor.Contains(ven))
                {
                    encontrado = true;
                    ventasxVendeor[i].Total = ventasxVendeor[i].Total + val;
                }
            }
            if (encontrado == false)
            {
                ventasxVendeor.Add(new Totales() { Vendedor = ven, Total = val });
            }
        }
    }

    public class Totales
    {
        public string Vendedor { get; set; }
        public double Total { get; set; }

    }
}
