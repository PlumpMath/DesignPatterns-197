using System.Collections.Generic;

namespace week6_Command
{
    public class Agent
    {
        public List<IOrderCommand> OrderList = new List<IOrderCommand>();

        public void PlaceOrder(IOrderCommand order)
        {
            OrderList.Add(order);
        }

        public void PerformOrder()
        {
            if (OrderList.Count != 0)
            {
                foreach (var o in OrderList)
                {
                    o.Execute();
                }
                OrderList.Clear();
            }
        }
    }
}