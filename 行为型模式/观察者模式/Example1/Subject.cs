using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.行为型模式.观察者模式.Example1
{

    class program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            subject.Attach(new BinaryObservar());
            subject.Attach(new OctalObservar());
            subject.Attach(new HexObservar());

            subject.SetState(10);
            Console.WriteLine("\n");

            subject.SetState(100);
            Console.WriteLine("\n");

            subject.SetState(555);
            Console.WriteLine("\n");
        }
    }
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void Attach(Observer obs)
        {
            observers.Add(obs);
        }

        public void Detach(Observer obs)
        {
            if (observers.Contains(obs))
            {
                observers.Remove(obs);
            }
            else return;
        }

        private void NotifyAllObservers()
        {
            foreach (var obs in observers)
            {
                obs.Update(this);
            }
        }
    }
}
