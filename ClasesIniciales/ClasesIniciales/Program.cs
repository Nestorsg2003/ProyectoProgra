using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesIniciales
    //{inicio bloque }final bloque
{
    class Program
    {
        //Este es el mètodo main.
        //Sirve como punto de entrada
        //para el programa (Inicia
        //desde aqui)
        static void Main(string[] args)
        {
            //int edad = 20();
            //tipo-identificador-valor de inicializacion/inicio
            //instancia de mochila
            //new =crear instancia
            Mochila mochilaAna = new Mochila();
            //Asignar valores
            mochilaAna.Disenio = "Piolìn";
            mochilaAna.Material = "Vinyl";
            mochilaAna.Tamanio = "Mediana";
            mochilaAna.NumDeBolsas = 3;
            mochilaAna.NumDeLlaveros = 0;
            //numero flotante con f
            mochilaAna.Precio = 500.00f;
            mochilaAna.color = new Color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.color.Azul = 33;

            Mochila mochilaBeto = new Mochila();
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.Material = "Piel";
            mochilaBeto.Tamanio = "Grande";
            mochilaBeto.NumDeBolsas = 3;
            mochilaBeto.NumDeLlaveros = 3;
            mochilaBeto.color = new Color();
            mochilaBeto.Precio = 700.00f;
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Verde = 128;
            mochilaBeto.color.Azul = 210;

            Mochila mochilaPedro = new Mochila();
            mochilaPedro.Disenio = "Cruz Azul";
            mochilaPedro.Material = "Tela";
            mochilaPedro.Tamanio = "Grande";
            mochilaPedro.NumDeBolsas = 6;
            mochilaPedro.NumDeLlaveros = 2;
            mochilaPedro.color = new Color();
            mochilaPedro.Precio = 250.00f;
            mochilaPedro.color.Rojo = 200;
            mochilaPedro.color.Verde = 50;
            mochilaPedro.color.Azul = 10;

            Celular celularNestor = new Celular();
            celularNestor.NetTec = "GSM/HSPA/LTE";
            celularNestor.LaunchAn = 2021;
            celularNestor.LaunchStatus = "Available";
            celularNestor.BodyHigh = 159.9f;
            celularNestor.BodyWidth = 75.1f;
            celularNestor.BodyLong = 8.4f;
            celularNestor.BodyBuild = "Glass front, platic frame, plastic back";
            celularNestor.BodySIM = "Single SIM";
            celularNestor.DisplayType = "Super AMOLED, 90HZ, 800nits";
            celularNestor.DisplaySize = 6.5f;
            celularNestor.DisplayResHigh = 1080;
            celularNestor.DisplayResWidth = 1920;
            celularNestor.DisplayProt = "Corning Gorilla Glass 5";
        }
    }
}
