namespace Factory
{
    public class DiscoDoble : Disco
    {
        public DiscoDoble(string tipo, string capacidad, float precio)
        {
            _formato = FormatoDiscoEnum.DOBLE;
            _tipo = tipo;
            _capacidad = capacidad;
            _precio = precio;
        }
    }
}
