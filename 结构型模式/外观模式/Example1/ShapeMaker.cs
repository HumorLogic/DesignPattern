using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacadePattern.Example1
{

    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        ShapeMaker shapeMaker = new ShapeMaker();

    //        shapeMaker.DrawCircle();
    //        shapeMaker.DrawSquare();
    //        shapeMaker.DrawRectangle();
    //    }
    //}


    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }

    }
}
