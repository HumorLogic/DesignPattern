using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.结构型模式.组合模式.Example1
{
    public class ImageEditor
    {
        CompoundGraphic all;

        public void Load()
        {
            all = new CompoundGraphic();
            all.Add(new Dot(1, 2));
            all.Add(new Circle(5, 5, 3));
        }

        public void GroupSelected(Graphic[] components)
        {
            CompoundGraphic group = new CompoundGraphic();
            foreach (var component  in components)
            {
                group.Add(component);
                all.Remove(component);
            }
            all.Add(group);
            all.Draw();
        } 

    }

    class program
    {
        static void Main(string[] arg)
        {

            ImageEditor imageEditor = new ImageEditor();
            imageEditor.Load();

            Graphic[] graphics =  { new Dot(9, 9), new Circle(2, 2, 6) };
            imageEditor.GroupSelected(graphics);

            Graphic[] graphics2 = { new Dot(88, 1), new Circle(100, 1, 8), new Circle(4, 4, 6) };
            imageEditor.GroupSelected(graphics2);


        }
    }
    public interface Graphic
    {
        void Move(float x, float y);
        void Draw();
    }

    public class Dot : Graphic
    {
        protected float x;
        protected float y;

        public Dot(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Draw a dot at {0},{1}",x,y);
        }

        public void Move(float x, float y)
        {
            this.x += x;
            this.y += y;
        }
    }

    public class Circle : Dot
    {
        float radius;
        public Circle(float x, float y, float radius):base(x,y)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a radius = {0} Circle at {1},{2}",radius ,x, y);
        }
    }

    public class CompoundGraphic : Graphic
    {
         List<Graphic> children = new List<Graphic>();

        public void Add(Graphic child)
        {
            children.Add(child);
        }

        public void Remove(Graphic child)
        {
            children.Remove(child);
        }
        public void Draw()
        {
            foreach (var item in children)
            {
                item.Draw();
            }
        }

        public void Move(float x, float y)
        {
            foreach (var item in children)
            {
                item.Move(x, y);
            }
        }

        
    }
}
