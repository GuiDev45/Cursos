using System;

namespace Secao_14_Aula_210_Heranca_multipla.Devices
{
    internal class Printer : Device, IPrinter
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
