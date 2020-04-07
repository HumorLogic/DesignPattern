using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    public class Client
    {
        static void Main(string[] args)
        {
            Phone phone;
            PC pc;
            AbstractFactory xiaomiF = new XiaoMiFactory();
            phone = xiaomiF.CreatePhone();
            phone.Call();
            pc = xiaomiF.CreatePC();
            pc.Play();

            AbstractFactory huaweiF = new HuaweiFactory();
            phone = huaweiF.CreatePhone();
            phone.Call();

            pc = huaweiF.CreatePC();
            pc.Play();

        }
    }
  


    public interface AbstractFactory
    {
        Phone CreatePhone();
        PC CreatePC();

    }

    public class XiaoMiFactory : AbstractFactory
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

    public class HuaweiFactory : AbstractFactory
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
