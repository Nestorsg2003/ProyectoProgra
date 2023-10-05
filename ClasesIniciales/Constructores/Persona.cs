using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Persona
    {
        private int birthYear = 2000;
        private int currentYear = 2023;


        public Persona()
        { }

        public Persona(int valorYear, int valorCurrent)
        {
            birthYear = valorYear;
            currentYear = valorCurrent;

        }

        public int calcEdad()
        {
            int edad = currentYear - birthYear;
            return edad;
        }
    }
}
