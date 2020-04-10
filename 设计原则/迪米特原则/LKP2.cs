///应用迪米特法则

using System.Collections.Generic;


namespace DesignPattern
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
            
            decimal charge= 1m;

            foreach (Customer customer in Customers)
            {
                decimal payment = customer.MakePayment(charge);

                if (payment != 0m)
                {
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

        public decimal MakePayment(decimal amount)
        {
            if (Wallet.Money >= amount)
            {
                Wallet.Money -= amount;
                return amount;
            }
            return 0m;
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
