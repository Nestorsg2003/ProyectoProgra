using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Artista TwentyOnePilots = new Artista();
            TwentyOnePilots.nombredelartista = "Twenty One Pilots";
            TwentyOnePilots.miembros = "Josh Dun" +
                "Chris Salih";
            TwentyOnePilots.generosdelartista = "Indie pop, hip hop " +
                "electropo, pop rap, rock, rap rock";
            TwentyOnePilots.albums = "Twenty One Pilots, Regional at Best, Vessel, Blurryface, Trench, Scaled and Icy ";
            TwentyOnePilots.periododeactividad = 2009 - 2023;

            Album Vessel = new Album();
            Vessel.nombredelalbum = "Vessel";
            Vessel.anodepulicacion = 2013;
            Vessel.generosdelalbum = "Indie pop, electropop, pop rap";
            Vessel.duraciondelalbum = 47.44f;
            Vessel.diseñodelacaratuladelalbum = "Dos viejitos parados";

            Cancion HouseGold = new Cancion();
            HouseGold.nombre = "House of Gold";
            HouseGold.duracion = 2.13f;
            HouseGold.generos = "Alernative folk";
            HouseGold.numerodepista = 4;
            HouseGold.compositores = "Tyler Joseph";


            Artista BrunoMars = new Artista();
            BrunoMars.nombredelartista = "Bruno Mars";
            BrunoMars.miembros = "Bruno Mars";
            BrunoMars.generosdelartista = "pop, soul, reggae, hip hop, rock";
            BrunoMars.albums = "Doo-Wops, Unorthodox, 24 Magic";
            BrunoMars.periododeactividad = 1992 - 2023;

            Album Magic = new Album();
            Magic.nombredelalbum = "24KMagic";
            Magic.anodepulicacion = 2003;
            Magic.generosdelalbum = "Pop, funK, R&B, soul";
            Magic.duraciondelalbum = 48.10f;
            Magic.diseñodelacaratuladelalbum = "Chico sentado en silla";

            Cancion KMagic = new Cancion();
            KMagic.nombre = "24K Magic";
            KMagic.duracion = 3.45f;
            KMagic.generos = "funk";
            KMagic.numerodepista = 6;
            KMagic.compositores = "Bruno Mars";


            Artista LuisMiguel = new Artista();
            LuisMiguel.nombredelartista = "Luis Miguel";
            LuisMiguel.miembros = "Luis Miguel";
            LuisMiguel.generosdelartista = "pop, bolero, mariachi";
            LuisMiguel.albums = "Un Sol, Amarte es un place, No culpes a la noche";
            LuisMiguel.periododeactividad = 1980 - 2023;

            Album EMI = new Album();
            EMI.nombredelalbum = "No culpes a la noche";
            EMI.anodepulicacion = 2009;
            EMI.generosdelalbum = "pop latino";
            EMI.duraciondelalbum = 53.07f;
            EMI.diseñodelacaratuladelalbum = "Car en azules";

            Cancion Amas = new Cancion();
            Amas.nombre = "Sera que no me amas";
            Amas.duracion = 4.42f;
            Amas.generos = "pop";
            Amas.numerodepista = 5;
            Amas.compositores = "Hex Hector";
        }
    }
}
