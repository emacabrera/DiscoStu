namespace Factory
{
    public class BlueRayFactory : DiscoFactory
    {
        public override Disco CrearDisco(FormatoDiscoEnum tipo)
        {
            if (tipo == FormatoDiscoEnum.SIMPLE)
            {
                return new DiscoSimple("BlueRay", "25 GB", 20);
            }
            else if (tipo == FormatoDiscoEnum.DOBLE)
            {
                return new DiscoDoble("BlueRay", "50 GB", 40);
            }

            return null;
        }
    }
}
