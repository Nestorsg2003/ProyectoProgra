using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Circulo
    {
        private float radio = 6;

        public Circulo()
        { }

        public Circulo(float valorRadio)
        {
            radio = valorRadio;
        }
        public double calcPerimetro()
        {
            double perimetro = Math.PI * 2 * radio;
            return perimetro;
        }

        public void describir()
        {
            Console.WriteLine("Circulo de radio " + radio);
        }
    }
}
