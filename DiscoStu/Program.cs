using Factory;
using System;

namespace DiscoStu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscoFactory factory;
            Disco disco;

            factory = new DVDFactory();

            disco = factory.CrearDisco(FormatoDiscoEnum.SIMPLE);
            disco.Mostrar();
            Console.WriteLine();
            disco = factory.CrearDisco(FormatoDiscoEnum.DOBLE);
            disco.Mostrar();
            Console.WriteLine();

            factory = new BlueRayFactory();
            disco = factory.CrearDisco(FormatoDiscoEnum.SIMPLE);
            disco.Mostrar();
            Console.WriteLine();
            disco = factory.CrearDisco(FormatoDiscoEnum.DOBLE);
            disco.Mostrar();

            Console.ReadKey();
        }
    }
}
