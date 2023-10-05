using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect1 = new Rectangulo();
            rect1.describir();
            float area1 = rect1.calcArea();
            Console.WriteLine("Area = " + area1);

            Rectangulo rect2 = new Rectangulo();
            rect2.setAlto(12);
            rect2.describir();
            float area2 = rect2.calcArea();
            Console.WriteLine("Area = " + area2);

            //construyo rectangulo definiendo valores desde el constructor
            Rectangulo rect3 = new Rectangulo(3, 2);
            rect3.describir();
            float area3 = rect3.calcArea();
            Console.WriteLine("Area = " + area3);


            Triangulo triangulo1 = new Triangulo();
            triangulo1.describir();
            float perTri1 = triangulo1.calcPerimetro();
            Console.WriteLine("Perimetro = " + perTri1);

            Triangulo triangulo2 = new Triangulo(8, 7, 10);
            triangulo2.describir();
            float perTri2 = triangulo2.calcPerimetro();
            Console.WriteLine("Perimetro = " + perTri2);

            Circulo circ1 = new Circulo(10);
            circ1.describir();
            double perCirc1 = circ1.calcPerimetro();
            Console.WriteLine("Perimetro = " + perCirc1);

            Circulo circ2 = new Circulo();
            circ1.describir();
            double perCirc2 = circ2.calcPerimetro();
            Console.WriteLine("Perimetro = " + perCirc2);

            Zapato zapato1 = new Zapato();
            zapato1.describir();

            Zapato zapato2 = new Zapato("negro", 24.5f);
            zapato2.describir();


            Producto precio1 = new Producto();
            precio1.describir();
            float precioIva1 = precio1.calcPrecio();
            Console.WriteLine("El precio con IVA es " + precioIva1);

            Producto precio2 = new Producto(40);
            precio2.describir();
            float precioIva2 = precio2.calcPrecio();
            Console.WriteLine("El precio con IVA es " + precioIva2);

            Persona persona1 = new Persona();
            int edad1 = persona1.calcEdad();
            Console.WriteLine("La persona tiene " + edad1 + " años");

            Persona persona2 = new Persona(2003, 2029);
            int edad2 = persona2.calcEdad();
            Console.WriteLine("La persona tiene " + edad2 + " años");

            Email mail1 = new Email();
            mail1.leer();

            Email mail2 = new Email("sin sujeto", "sin contenido", "destinatario anonimo");
            mail2.leer();


            Console.ReadLine();

        }
    }
}