using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.行为型模式.策略模式.Example1
{
    
    public class program
    {
        //static void Main(string[] arg)
        //{
        //    Context context = new Context();
        //    double firstNum;
        //    double lastNum;
        //    char operate;
        //    Console.WriteLine("请输入第一个数字：");
        //    firstNum= double.Parse( Console.ReadLine());

        //    Console.WriteLine("请输入第二个数字：");
        //    lastNum = double.Parse(Console.ReadLine());

        //    Console.WriteLine("请输入运算符：");
        //    operate= char.Parse(Console.ReadLine());


        //    if (operate == '+')
        //    {
        //        context.SetStrategy(new ConcreteStrategyAdd());
        //    }else if (operate == '-')
        //    {
        //        context.SetStrategy(new ConcreteStrategySubtract());
        //    }else if (operate == '*')
        //    {
        //        context.SetStrategy(new ConcreteStrategyMultiply());
        //    }


        //    Console.WriteLine("结果：");
        //    Console.Write("{0} {1} {2} = ",firstNum,operate,lastNum);
        //    Console.Write(context.ExecuteStrategy(firstNum,lastNum));
           
        //}
    }

   public interface Strategy
    {
        double Execute(double a, double b);
    }

   public class ConcreteStrategyAdd : Strategy
    {
        public double Execute(double a, double b)
        {
            return a + b;
        }
    }

   public class ConcreteStrategySubtract : Strategy
    {
        public double Execute(double a, double b)
        {
            return a - b;
        }
    }

    public class ConcreteStrategyMultiply : Strategy
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }
    }

    public class Context
    {
        private Strategy strategy;

        public void SetStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public double ExecuteStrategy(double a, double b)
        {
            return strategy.Execute(a, b);
        }

    }
}
