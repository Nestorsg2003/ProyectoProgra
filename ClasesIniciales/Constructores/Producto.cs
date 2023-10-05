using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Producto
    {
        private float precio = 103f;
        private float iva = 1.16f;
        public Producto()
        { }

        public Producto(float valorPrecio)
        {
            precio = valorPrecio;

        }

        public float calcPrecio()
        {
            float precioIva = precio * iva;
            return precioIva;
        }
        public void describir()
        {
            Console.WriteLine("El precio sin iva es " + precio);
        }



    }
}
