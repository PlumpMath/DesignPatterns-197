namespace week6_Command
{
    public class BuyStockOrder : IOrderCommand
    {
        private StockTrade _stock;

        public BuyStockOrder(StockTrade st)
        {
            _stock = st;
        }

        public void Execute()
        {
            _stock.Buy();
        }

        public override string ToString()
        {
            return "Buy stock order has been placed";
        }
    }
}