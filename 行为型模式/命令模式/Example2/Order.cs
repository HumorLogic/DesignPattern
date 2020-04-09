using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.行为型模式.命令模式.Example2
{

    class program
    {
        static void Main(string[] arg)
        {

            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();


        }
    }

    public interface Order
    {
        void Execute();
    }



    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [Name: {0} , Quantity: {1}] bought.", name, quantity);
        }

        public void Sell()
        {
            Console.WriteLine("Stock [Name: {0} , Quantity: {1}] sold.", name, quantity);
        }


    }
    public class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock stock)
        {
            this.abcStock = stock;
        }
        public void Execute()
        {
            abcStock.Buy();
        }
    }

    public class SellStock : Order
    {
        private Stock abcStock;

        public SellStock(Stock stock)
        {
            this.abcStock = stock;
        }
        public void Execute()
        {
            abcStock.Sell();
        }
    }

    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void TakeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var item in orderList)
            {
                item.Execute();
            }

            orderList.Clear();
        }

    }

}
