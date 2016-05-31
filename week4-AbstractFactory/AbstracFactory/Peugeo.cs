namespace week4_AbstractFactory
{
    class Peugeo : ICarFactory
    {
        public IHybrid CreateHybrid()
        {
            return new Hybrid();
        }

        public ISUV CreateSUV()
        {
            return new SUV();
        }
    }
}