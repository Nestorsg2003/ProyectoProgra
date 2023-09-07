using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de strings con declaracion explicita
            string[] diasSemana = {
                "Domingo", "Lunes", "Martes",
                "Mièrcoles", "Jueves",
                "Viernes", "Sabàdo" };

            int cantDias = diasSemana.Length;

            
            Console.WriteLine(
                "Hay " + cantDias + " dias en el arreglo");

            Console.WriteLine("");

            //Asignar un valor en el arreglo
            diasSemana[1] = "Monday";

            //Accedo a un elemento y lo guardo en variable
            string diaUno = diasSemana[1];
            string diaTres = diasSemana[3];
            
            Console.WriteLine(diaUno);
            Console.WriteLine(diaTres);

            //Accedo a un elemento y lo uso directamente
            Console.WriteLine(diasSemana[0]);
            Console.WriteLine(diasSemana[4]);

            Console.WriteLine("");

            //hardcode :( for (int i = 0; 1 < 7; i++) ;

            for (int i = 0; i < diasSemana.Length; i++) //Parametrizado :D
            {
                Console.WriteLine(i + ".-" + diasSemana[i]);
            }

            Console.ReadLine();
        }
    }
}
