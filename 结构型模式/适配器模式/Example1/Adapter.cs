using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.结构型模式.适配器模式.Example1
{
    class program
    {
        static void Main(string[] arg)
        {
            RoundHole hole = new RoundHole(5);
            RoundPeg rpeg = new RoundPeg(5);
            hole.Fits(rpeg); // true

            SquarePeg s_sqpeg = new SquarePeg(5);
            SquarePeg b_sqpeg = new SquarePeg(10);

            SquarePegAdapter smallSqAdapter = new SquarePegAdapter(s_sqpeg, 10);
            SquarePegAdapter bigSqAdapter = new SquarePegAdapter(b_sqpeg, 10);

            
            Console.WriteLine( smallSqAdapter.GetRadius());
            Console.WriteLine(hole.Fits(smallSqAdapter));

            Console.WriteLine(bigSqAdapter.GetRadius());
            Console.WriteLine(hole.Fits(bigSqAdapter));
        }
    }
    


    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg peg;
        public SquarePegAdapter(SquarePeg peg,float radius) : base(radius)
        {
            this.peg = peg;
            this.radius = radius;
        }

        public override float GetRadius()
        {
            return (float)(peg.GetWidth() * Math.Sqrt(2) / 2);
        }
    }

   public class RoundHole
    {
         float radius;
        public RoundHole(float radius)
        {
            this.radius = radius;
        }

        public float GetRadius()
        {
            return radius;
        }

        public bool Fits(RoundPeg peg)
        {
            return this.GetRadius() >= peg.GetRadius();
        }
    }

    public class RoundPeg
    {
        protected float radius;

        public RoundPeg(float radius)
        {
            this.radius = radius;
        }

        public virtual float GetRadius()
        {
            return radius;
        }

    }

    public class SquarePeg
    {
        private float width;

        public SquarePeg(float width)
        {
            this.width = width;
        }

        public float GetWidth()
        {
            return width;
        }
    }

}
