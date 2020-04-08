using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.创建型类模式.抽象工厂模式.exsample1
{
    public abstract class Phone
    {
        public abstract void Call();
    }

    public abstract class PC
    {
        public abstract void Play();
    }

    public class XiaomiPhone : Phone
    {
        public override void Call()
        {
            Console.WriteLine("xiaomi phone call");
        }
    }

    public class HuaweiPhone : Phone
    {
        public override void Call()
        {
            Console.WriteLine("huawei phone call");
        }
    }

    public class XiaomiPC : PC
    {
        public override void Play()
        {
            Console.WriteLine("xiaomi PC play");
        }
    }

    public class HuaweiPC : PC
    {
        public override void Play()
        {
            Console.WriteLine("huawei PC play");
        }
    }


}
