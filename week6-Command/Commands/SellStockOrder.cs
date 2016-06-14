namespace week6_Command
{
    public class SellStockOrder : IOrderCommand
    {
        private StockTrade _stock;

        public SellStockOrder(StockTrade st)
        {
            _stock = st;
        }

        public void Execute()
        {
            _stock.Sell();
        }

        public override string ToString()
        {
            return "Sell stock order has been placed";
        }
    }
}