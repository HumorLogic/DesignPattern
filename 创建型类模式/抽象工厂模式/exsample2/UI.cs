using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Example2
{
    public interface Button
    {
        void Paint();
    }

    public interface Checkbox
    {
        void Paint();
    }

    public class WinButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("WinButton paint");
        }
    }

    public class MacButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("MacButton paint");

        }
    }

    public class WinCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("WinCheckbox paint");

        }
    }

    public class MacCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("MacCheckbox paint");
        }
    }
}
