using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos2
{
    public class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras ferrari = new AutoCarreras();
            ferrari.modelo = "Ferrari f150";
            ferrari.peso = 1.3f;
            ferrari.velocidad = 230;

            AutoCarreras mcLaren = new AutoCarreras();
            mcLaren.modelo = "McLaren A455";
            mcLaren.peso = 0.98f;
            mcLaren.velocidad = 280;

            PistaCarreras hnsRosdriguez = new PistaCarreras();
            hnsRosdriguez.nombre = "Autodromo Hermanos Rodriguez";
            hnsRosdriguez.longitud = 5.6f;

            hnsRosdriguez.Competir(ferrari, mcLaren);

            ferrari.PonerGas(20);
            ferrari.Acelerar(30);
            ferrari.Arrancar();
            mcLaren.Arrancar();
            mcLaren.Frenar();

            Console.ReadLine();
        }
    }
}

