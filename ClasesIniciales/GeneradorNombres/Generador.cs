using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorNombres
{
    public class Generador
    {
        public string[] titulos = { "Increible", "Brillante", "Asombroso", "Increible", "Inteligente" };
        public string[] raza = { "Alienigena", "Mutante", "Indigena", "Hombre Lobo", "Super" };
        public string[] origen = { "Araña", "Gigante", "Diminuto", "Fuerte", "Lanza Rayos" };

        public void generar(int dia, int mes);
    }
}
