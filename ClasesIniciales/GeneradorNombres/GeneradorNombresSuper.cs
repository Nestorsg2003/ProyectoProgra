using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNombres
{
    public class GeneradorNombres
    {
        public string[] titulo = { "Increible", "Brillante", "Asombroso", "Increible", "Inteligente" };
        public string[] raza = { "Alienigena", "Mutante", "Indigena", "Hombre Lobo", "Super" };
        public string[] origen = { "Araña", "Gigante", "Diminuto", "Fuerte", "Lanza Rayos" };

        public void generar(int mes, int dia, int color)
        {
            if (mes > 12)
            {
                Console.WriteLine("Los meses van del 1 al 12");
                return;
            }
            Console.WriteLine("Tu nombre de superheroe es: " + titulo[mes - 1] + " " + raza[dia - 1] + " " + origen[color]);
        }
    }
}
