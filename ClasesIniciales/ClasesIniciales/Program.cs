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
            celularNestor.PlatformOS = "Android 11";
            celularNestor.PlatformChip = "Qualcomm SM7125 Snapdragon 720G";
            celularNestor.PlatformCPU = "Octa-core";
            celularNestor.PlatformGPU = "Adreno 618";
            celularNestor.MemoryCard = "microSDXC";
            celularNestor.MemoryInternal = 128;
            celularNestor.MemoryRAM = 4;
            celularNestor.MainCamQuad = "64 MP, f/1.8, 26mm (wide), " +
                "12 MP, f / 2.2, 123˚ (ultrawide), 1.12µm 5 MP, f / 2.4, (macro) " +
                "5 MP, f / 2.4, (depth)";
            celularNestor.MainCamFeatures = "LED flash, panorama, HDR";
            celularNestor.MainCamVideo = "4K 30fps, 1080 30/60fps";
            celularNestor.SelfCamSingle = "32 MP, f/2.2, 26mm (wide)";
            celularNestor.SelFCamFeatures = "HDR";
            celularNestor.SelfCamVideo = "4K 30fps, 1080p 30fps";
            celularNestor.SoundSpeaker = true;
            celularNestor.SoundJack = true;
            celularNestor.CommsWLAN = "Wifi 802.11 a/b/g/n/ac, dual band, Wifi Direct";
            celularNestor.CommsBt = "5.0, A2DP, LE";
            celularNestor.CommsPos = "GPS, GLONASS, GALILEO, BDS";
            celularNestor.CommsNFC = true;
            celularNestor.CommsRadio = "FM radio";
            celularNestor.CommsUSB = "USB Type-C 2.0, OTG";
            celularNestor.FeaturesSen = "Fingerprint, accelerometer, gyro, compass, Virtual proximity sensing";
            celularNestor.BatteryType = "Li-Po 4500 mAh, non-removable";
            celularNestor.BaterryCharge = "25W wired, 50% in 30min";
            celularNestor.Misccolor = "Awesome Blue";
            celularNestor.MiscModels = "SM-A525F";
            celularNestor.MiscSAREUHead = 0.35f;
            celularNestor.MiscSAREUBody = 0.84f;
            celularNestor.MiscPrice = 400;
            celularNestor.TestsPerf = "AnTuTu: 261282 (v8) " +
                "GeekBench: 5865(v4.4), 1577(v5.1) " +
                "GFXBench: 15fps(ES 3.1 onscreen)";
            celularNestor.TestsDis = "Contrast ratio: Infinite (nominal)";
            celularNestor.TestsCam = "Photo/Video";
            celularNestor.TestsLoudspeaker = "-27.0 LUFS";
            celularNestor.TestsEndurance = "Endurance rating 105h";
    }
    }
}
