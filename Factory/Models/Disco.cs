using System;

namespace Factory
{
    public abstract class Disco
    {
        protected string _tipo;
        protected FormatoDiscoEnum _formato;
        protected string _capacidad;
        protected float _precio;

        public void Mostrar()
        {
            Console.WriteLine($"{_tipo} formato {_formato} capa.");
            Console.WriteLine($"Capacidad: {_capacidad}");
            Console.WriteLine($"Precio: u$s {_precio}");
        }
    }
}
