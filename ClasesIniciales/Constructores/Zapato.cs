using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Zapato
    {
        private string color = "rojo";
        private float talla = 26f;


        public Zapato()
        { }

        public Zapato(string valorColor, float valorTalla)
        {
            color = valorColor;
            talla = valorTalla;

        }
        public void describir()
        {
            Console.WriteLine("Zapato color " + color + " y talla " + talla);
        }
    }
}
