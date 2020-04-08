using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacadePattern.Example1
{
    public interface Shape
    {
        void Draw();
    }

    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }

    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Square Draw");
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }
}
