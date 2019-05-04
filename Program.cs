using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PruebaArbolBPlus
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArbolBP<int> arbolito = new ArbolBP<int>();
            NodoBP<int> nodito = new NodoBP<int>();
            
            string[] lineas = File.ReadAllLines("C: /Users/Marcos Andrés CM/Downloads/CSVPrueba.csv");
            for (int i = 0; i < lineas.Length; i++)
            {
                arbolito.InsertarNodo(Convert.ToInt32(lineas[i]));
            }
            
        }
    }
}
