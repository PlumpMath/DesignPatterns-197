namespace week4_AbstractFactory
{
    class SUV : ISUV
    {
        public string OffRoadDriving()
        {
            return GetType().Name + " offroad tyre set";
        }

        public string Sell()
        {
            return this.GetType().Name + " car is sold";
        }
    }
}