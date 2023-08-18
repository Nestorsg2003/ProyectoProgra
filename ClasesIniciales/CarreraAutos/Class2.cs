using System;
using System.Collections.Generic;
using System.Text;

namespace PistaCarreras
{
    public class PistaCarreras
    {
        public string nombre;
        public float longitud;

        public void Competir(CarreraAutos auto1, Autocarreras auto2);
    }

        

        //void metodo y agregar parentesis
        
        {
            Console.WriteLine("Iniciando carrera entre " auto1.modelo + "y" + auto2.modelo);

            if(auto1.velocidad > auto2.velocidad)
            {
                Console.Writeline("Ganò ") + auto1.modelo);
            }
            else if(auto2.velocidad > auto1.velocidad)
            {
                Console.Writeline("Ganò ") + auto2.modelo);
            }
            else
{
    Console.WriteLine("Hubo empate");
}


        }

    }
}
