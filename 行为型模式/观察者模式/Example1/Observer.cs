using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Example1
{
    public interface Observer
    {
        void Update(Subject subject);
    }

    public class BinaryObservar : Observer
    {


        public void Update(Subject subject)
        {
            string str = Convert.ToString(subject.GetState(), 2);  //转二进制
            Console.WriteLine("二进制观察者："+str);
        }
    }


    public class OctalObservar : Observer
    {
        public void Update(Subject subject)
        {
            string str = Convert.ToString(subject.GetState(), 8);  //转八进制
            Console.WriteLine("八进制观察者："+str);
        }
    }


    public class HexObservar : Observer
    {
        public void Update(Subject subject)
        {
            string str = Convert.ToString(subject.GetState(), 16);  //转八进制
            Console.WriteLine("十六进制观察者：" + str);
        }
    }

}
