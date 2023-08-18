using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
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
        }
    }
}
