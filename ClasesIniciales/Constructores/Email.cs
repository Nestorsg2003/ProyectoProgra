using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Email
    {
        private string subject = "aaaaaa";
        private string contenido = "bbbbbb";
        private string destinatario = "ccccccc";


        public Email()
        { }

        public Email(string contSubject, string contCont, string contDest)
        {
            subject = contSubject;
            contenido = contCont;
            destinatario = contDest;

        }
        public void leer()
        {
            Console.WriteLine(subject);
            Console.WriteLine(contenido);
            Console.WriteLine(destinatario);
        }
    }
}