using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.创建型类模式.简单工厂模式.Example1
{
    class program
    {
        static void Main(string[] arg)
        {
          
            Operation oper;
            oper = OperationFactory.CreateOperation("+");
            oper.numA = 10;
            oper.numB = 5;
            oper.GetResult();

            oper = OperationFactory.CreateOperation("-");
            oper.numA = 10;
            oper.numB = 5;
            oper.GetResult();

            oper = OperationFactory.CreateOperation("*");
            oper.numA = 888;
            oper.numB = 666;
            oper.GetResult();
        }
    }
    public abstract class Operation
    {
        public float numA;
        public float numB;
       public abstract  void GetResult();
    }

    public class Add : Operation
    {
        public override void GetResult()
        {
            Console.WriteLine(numA + numB);
        }
    }

    public class Subtract : Operation
    {
      
        public override void GetResult()
        {
            Console.WriteLine(numA - numB);
        }
    }

    public class Multiply : Operation
    {
        public override void GetResult()
        {
            Console.WriteLine(numA * numB);
        }
    }


    class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            
            switch (operate)
            {
                case "+":
                    return new Add();
                case "-":
                    return new Subtract();
                case "*":
                    return new Multiply();
                default:
                    return null;
            }

        }

    }
}
