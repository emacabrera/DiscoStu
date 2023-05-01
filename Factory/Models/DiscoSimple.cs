namespace Factory
{
    public class DiscoSimple : Disco
    {
        public DiscoSimple(string tipo, string capacidad, float precio)
        {
            _formato = FormatoDiscoEnum.SIMPLE;
            _tipo = tipo;
            _capacidad = capacidad;
            _precio = precio;
        }
    }
}
