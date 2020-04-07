/// 迪米特法则应用前，在Paperboy类中CollectPayments()方法，包含了
/// 间接朋友类Wallet的操作，这个操作可以分开写进Customer类中完成

using System.Collections.Generic;

namespace NotUseDesignPattern
{
    public class Paperboy
    {
        public List<Customer> Customers { get; set; }
        
        decimal fundsCollected;

        public Paperboy()
        {
            Customers = new List<Customer>();
        }


        public void CollectPayments()
        {
            // The newspaper costs $1
            decimal payment = 1m;

            foreach (Customer customer in Customers)
            {
                if (customer.Wallet.Money >= payment)
                {
                    customer.Wallet.Money -= payment;
                    fundsCollected += payment;
                }
            }
        }


    }

    public class Customer
    {
        public Wallet Wallet { get; set; }
        public Customer() : this(null) { }

        public Customer(Wallet wallet)
        {
            Wallet = wallet;
        }


    }

    public class Wallet
    {
        public decimal Money { get; set; }
        public Wallet(decimal money)
        {
            Money = money;
        }


    }
}
