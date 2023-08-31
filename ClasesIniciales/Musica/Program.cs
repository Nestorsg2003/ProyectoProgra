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
            TwentyOnePilots.nombreartista = "Twenty One Pilots";
            TwentyOnePilots.miembros = "Josh Dun" +
                "Chris Salih";
            TwentyOnePilots.generosartista = "Indie pop, hip hop " +
                "electropo, pop rap, rock, rap rock";
            TwentyOnePilots.albums = "Twenty One Pilots, Regional at Best, Vessel, Blurryface, Trench, Scaled and Icy ";
            TwentyOnePilots.periodoactividad = 2009 - 2023;

            Album Vessel = new Album();
            Vessel.nombrealbum = "Vessel";
            Vessel.pulicacion = 2013;
            Vessel.generosalbum = "Indie pop, electropop, pop rap";
            Vessel.duracionalbum = 47.44f;
            Vessel.diseñoalbum = "Dos viejitos parados";

            Cancion HouseGold = new Cancion();
            HouseGold.nombre = "House of Gold";
            HouseGold.duracion = 2.13f;
            HouseGold.generos = "Alernative folk";
            HouseGold.numerodepista = 4;
            HouseGold.compositores = "Tyler Joseph";


            Artista BrunoMars = new Artista();
            BrunoMars.nombreartista = "Bruno Mars";
            BrunoMars.miembros = "Bruno Mars";
            BrunoMars.generosartista = "pop, soul, reggae, hip hop, rock";
            BrunoMars.albums = "Doo-Wops, Unorthodox, 24 Magic";
            BrunoMars.periodoactividad = 1992 - 2023;

            Album Magic = new Album();
            Magic.nombrealbum = "24KMagic";
            Magic.pulicacion = 2003;
            Magic.generosalbum = "Pop, funK, R&B, soul";
            Magic.duracionalbum = 48.10f;
            Magic.diseñoalbum = "Chico sentado en silla";

            Cancion KMagic = new Cancion();
            KMagic.nombre = "24K Magic";
            KMagic.duracion = 3.45f;
            KMagic.generos = "funk";
            KMagic.numerodepista = 6;
            KMagic.compositores = "Bruno Mars";


            Artista LuisMiguel = new Artista();
            LuisMiguel.nombreartista = "Luis Miguel";
            LuisMiguel.miembros = "Luis Miguel";
            LuisMiguel.generosartista = "pop, bolero, mariachi";
            LuisMiguel.albums = "Un Sol, Amarte es un place, No culpes a la noche";
            LuisMiguel.periodoactividad = 1980 - 2023;

            Album EMI = new Album();
            EMI.nombrealbum = "No culpes a la noche";
            EMI.pulicacion = 2009;
            EMI.generosalbum = "pop latino";
            EMI.duracionalbum = 53.07f;
            EMI.diseñoalbum = "Car en azules";

            Cancion Amas = new Cancion();
            Amas.nombre = "Sera que no me amas";
            Amas.duracion = 4.42f;
            Amas.generos = "pop";
            Amas.numerodepista = 5;
            Amas.compositores = "Hex Hector";
        }
    }
}
