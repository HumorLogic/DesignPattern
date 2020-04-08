using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    public class Client
    {
        public void ClientMethod(IAbstractFactory factory)
        {
            var phone = factory.CreatePhone();
            var pc = factory.CreatePC();

            phone.Call();
            pc.Play();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.ClientMethod(new HuaweiFactory());
            client.ClientMethod(new XiaoMiFactory());

        }
    }


    public interface IAbstractFactory
    {
        Phone CreatePhone();
        PC CreatePC();

    }

    public class XiaoMiFactory : IAbstractFactory
    {


        public PC CreatePC()
        {
            return new XiaomiPC();
        }

        public Phone CreatePhone()
        {
            return new XiaomiPhone();
        }
    }

    public class HuaweiFactory : IAbstractFactory
    {
        public PC CreatePC()
        {
            return new HuaweiPC();
        }

        public Phone CreatePhone()
        {
            return new HuaweiPhone();
        }
    }


}
