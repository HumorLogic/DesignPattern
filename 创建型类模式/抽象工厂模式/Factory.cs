using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    public class Client
    {
        static void Main(string[] args)
        {
            Shape shape;
            
            
            AbstractFactory factoryA = new ShapeFactory();
            shape= factoryA.GetShape("Rectangle");
            shape.Draw();
            shape = factoryA.GetShape("Square");
            shape.Draw();

            AbstractFactory factoryB = new RoundedShapeFactory();
            shape = factoryB.GetShape("Rectangle");
            shape.Draw();
            shape = factoryB.GetShape("Square");
            shape.Draw();

        }
    }
  


    public interface AbstractFactory
    {
        Shape GetShape(string shapeType);
    }

    public class ShapeFactory : AbstractFactory
    {
        public Shape GetShape(string shapeType)
        {
            if (shapeType == "Rectangle")
            {
                return new Rectangle();
            }else if (shapeType == "Square")
            {
                return new Square();
            }
            return null;
        }
    }

    public class RoundedShapeFactory : AbstractFactory
    {
        public Shape GetShape(string shapeType)
        {
            if (shapeType == "Rectangle")
            {
                return new RoundedRectangle();
            }
            else if (shapeType == "Square")
            {
                return new RoundedSquare();
            }
            return null;
        }
    }


}
