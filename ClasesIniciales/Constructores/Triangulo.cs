using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Triangulo
    {
        private float a = 6;
        private float b = 6;
        private float c = 4;

        public float calcPerimetro()
        {
            float perimetro = a + b + c;
            return perimetro;
        }

        public Triangulo()
        { }
        public Triangulo(float valorA, float valorB, float valorC)
        {
            a = valorA;
            b = valorB;
            c = valorC;
        }
        public void describir()
        {
            Console.WriteLine("Triangulo " + a + " + " + b + " + " + c);
        }
    }
}
