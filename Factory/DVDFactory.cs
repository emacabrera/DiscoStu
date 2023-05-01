namespace Factory
{
    public class DVDFactory : DiscoFactory
    {
        public override Disco CrearDisco(FormatoDiscoEnum tipo)
        {
            if (tipo == FormatoDiscoEnum.SIMPLE)
            {
                return new DiscoSimple("DVD", "4,7 GB", 5);
            }
            else if (tipo == FormatoDiscoEnum.DOBLE)
            {
                return new DiscoDoble("DVD", "8,5 GB", 8);
            }

            return null;
        }
    }
}
