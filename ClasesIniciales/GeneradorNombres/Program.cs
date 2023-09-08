using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNombres
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GeneradorNombres generador = new GeneradorNombres();

            generador.generar(15);
            Console.Read();
        }
    }
}
