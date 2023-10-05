using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Rectangulo
    {
        private float ancho = 5;
        private float alto = 10;


        public Rectangulo()
        {

        }

        //constructor que si recibe parametros
        public Rectangulo(float valorAncho, float valorAlto)
        {//se establece el estado inicila del objeto
            ancho = valorAncho;
            alto = valorAlto;
        }

        public void describir()
        {
            Console.WriteLine("Rectangulo" + ancho + " x " + alto);
        }

        public float calcArea()
        {
            float area = alto * ancho;
            return area;
        }

        public void setAlto(float valor)
        {
            alto = valor;
        }
    }
}
