using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmos
{
    internal class ClaseParaProducto
    {
        public static List<Totales3> ventasxproducto = new List<Totales3>();


        public static void Calcular(double MF, double Porc)
        {
            ventasxproducto.Clear();
            int l = Clase06.Listados.Count;
            for (int i = 0; i < l; i++)
            {
                string Ven = Clase06.Listados[i].NombreProducto;
                double Val = Clase06.Listados[i].Total_A_Pagar;
                acumular(Ven, Val);
            }
        }

        private static void acumular(string ven, double val)
        {
            bool encontrado = false;
            int l = ventasxproducto.Count;
            for (int i = 0; i < l; i++)
            {
                if (ventasxproducto[i].NombreProducto.Contains(ven))
                {
                    encontrado = true;
                    ventasxproducto[i].Total = ventasxproducto[i].Total + val;
                }
            }
            if (encontrado == false)
            {
                ventasxproducto.Add(new Totales3() { NombreProducto = ven, Total = val });
            }
        }
    }

    public class Totales3
    {
        public string NombreProducto { get; set; }
        public double Total { get; set; }

    }
}
