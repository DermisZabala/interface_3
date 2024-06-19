using System;

namespace Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisoTransito aviso1 = new AvisoTransito();
            aviso1.MostrarAviso();

            AvisoTransito aviso2 = new AvisoTransito("DIGESETT", "Sanción de velocidad RD1500", "22/09/2004");
            aviso2 .MostrarAviso();
        }
    }
}
