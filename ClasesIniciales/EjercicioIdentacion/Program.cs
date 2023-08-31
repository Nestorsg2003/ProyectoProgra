using System; //Identacion 0
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIdentacion //Identacion 0

	{ 	//Inicio de bloque de namespace Ejercicio, Identacion: 0
		class Program //Identacion: 1
		{ //Inicio de bloque de Clase Program, Identacion: 1
			static void Main(string[] args)//Identacion: 2
			{ //Inicio de bloque de Main, Identacion: 2
				ClaseA objetoA = new ClaseA();//Identacion: 3
				ClaseB objetoB = new ClaseB();//Identacion: 3

				objetoA.Metodo1(); //Identacion: 3
				objetoA.Metodo2(); //Identacion: 3

				objetoB.Metodo1(); //Identacion: 3
				objetoB.Metodo2(); //Identacion: 3
			} //Fin de bloque de Main Identacion: 2
		} //Fin de bloque de Clase Program, Identacion: 1
		class ClaseA //Identacion: 1
		{ //Inicio de bloque de ClaseA, Identacion 1
			public void Metodo1() //Identacion 2
			{ //Inicio de bloque de Metodo1, Identacion: 2
			for (int i = 0; i < 3; i++) //Identacion 2
				{ //Inicio de bloque de ciclo for0, Identacion: 3
					Console.WriteLine("Método 1 de ClaseA - Iteración: " + i); //Identacion: 3
				
					for (int j = 0; j < 2; j++) //Identacion 4
					{ //Inicio de bloque de ciclo for1, Identacion 4
						Console.WriteLine("Ciclo anidado - Iteración: " + j); //Identacion: 4
					} //Fin de bloque de ciclo for1, Identacion: 4
				} //Fin de bloque de ciclo for0, Identacion: 3
			} //Fin de bloque de Metodo1, Identacion: 2

			public void Metodo2() //Identacion: 2
			{ //Inicio de bloque de Metodo2, Identacion: 2
				if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday) // Identacion: 3
				{  //Inicio de bloque de ciclo if, Identacion: 3
					Console.WriteLine("Es fin de semana en Método 2 de ClaseA"); // Identacion: 4
				} // Fin de bloque de ciclo if, Identacion: 3
				else //Identacion 3
				{ // Inicio de bloque de ciclo else, Identacion: 3
					Console.WriteLine("No es fin de semana en Método 2 de ClaseA"); //Identacion 4
				} //Fin de bloque de ciclo else, Identacion: 3
			} //Fin de bloque de Metodo2, Identacion: 2
		} //Fin de bloque de ClaseA, Identacion: 1

		class ClaseB //Identacion: 1
		{ //Inicio de bloque de ClaseB, Identacion: 1
			public void Metodo1() //Identacion: 2
			{ //Inicio de bloque de Metodo1, Identacion: 2
				for (int i = 5; i > 0; i--) //Identacion: 3
				{ //Inicio de bloque de ciclo for0, Identacion: 3
					Console.WriteLine("Método 1 de ClaseB - Iteración: " + i); //Identacion 4

					for (int j = 0; j < i; j++) //Identacion 4
					{ //Inicio de bloque de ciclo for1, Identacion 4
						Console.WriteLine("Ciclo anidado - Iteración: " + j); //Identacion: 5
					} //FIn de bloque de ciclo for1, Identacion 4
				} //Fin de bloque de ciclo for0, Identacion 3
			} //Fin de bloque de Metodo1, Identacion: 2

			public void Metodo2() //Identacion: 2
			{ //Inicio de bloque de Metodo2, Identacion: 2
				int numero = 10; //Identacion: 3

				if (numero % 2 == 0) //Identacion: 3
				{ //Inicio de bloque de ciclo if, Identacion: 3
					Console.WriteLine("El número es par en Método 2 de ClaseB"); //Identacion: 4
				} //Fin de bloque de ciclo if, Identacion: 3
				else //Identacion: 3 
				{ //Inicio de bloque de ciclo else, Identacion: 3
					Console.WriteLine("El número es impar en Método 2 de ClaseB"); //Identacion: 4
				} //Fin de bloque de ciclo else, Identacion: 3
			} //Fin de bloque de Metodo2, Identacion: 2
		}//Fin de bloque de ClaseB, Identacion: 1
	}//Fin de bloque de namespace EjercicioIdentacion, Identacion: 0