using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos2
{
    public class AutoCarreras
    {
        public string modelo;
        public float peso;
        public int velocidad;
        public float gasolina;


        //Parametros dentro del parentesis
        //Declaracion de metodo
        //Visibilidad/Valor retorno/Nombre/Parametros(opcionales)
        public void PonerGas(float cantidad)
            //Cuerpo del metodo
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine(modelo + " tiene " + gasolina + "1 de gas");
        }


        //nombres de los metodos acciones
        public void Arrancar()
        {
            if (gasolina > 0)
            {
                gasolina = gasolina - 0.01f;
                Console.WriteLine("Arrancando " + modelo + 
                    " le quedan " + gasolina + " 1 de gas.");

            }
            else
            {
                Console.WriteLine(
                    "No se puede arrancar " + modelo + " sin gasolina.");
            }
            
        }

        public void Acelerar(int aceleracion)
        {
            //metodo acelerar disminuir la gasolina y si la gasolina llega a 0 mandar mensaje
            gasolina = gasolina - velocidad / 10f;
            velocidad = velocidad + aceleracion;
            
            if (gasolina < 0)
            {
                Console.WriteLine(modelo + " se a quedado sin gasolina ");
            }

            else
            {
                Console.WriteLine(modelo + " acelerò hasta " + velocidad + "km por hora," + modelo + "le queda" + gasolina + "de gasolina");
            }

        }

        public void Frenar()
        {
            if (velocidad > 0)
            {
                velocidad = 0;
                Console.WriteLine(modelo + " a frenado.");
            }
            else
            {
                Console.WriteLine(modelo + " ya esta frenado.");
            }

        }
    }
}


