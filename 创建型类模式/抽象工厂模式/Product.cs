using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class Shape
    {
        public abstract void Draw();
    }


    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle ");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Square ");
        }
    }

    public class RoundedSquare : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw RoundedSquare ");

        }
    }

    public class RoundedRectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw RoundedRectangle ");
        }
    }
}
