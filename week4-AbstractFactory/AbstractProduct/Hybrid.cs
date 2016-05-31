namespace week4_AbstractFactory
{
    class Hybrid : IHybrid
    {
        public string ChargeCar()
        {
            return this.GetType().Name + " car is charged";
        }

        public string Sell()
        {
            return this.GetType().Name + " car is sold";
        }
    }
}