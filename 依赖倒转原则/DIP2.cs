using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    //public class Client
    //{
    //    static void Main(string[] args)
    //    {
    //        ToggleSwitch ts = new ToggleSwitch();
    //        BulbLight bl = new BulbLight();
    //        TubeLight tl = new TubeLight();
    //        TV tv = new TV();

    //        ts.Switch(tv);
    //        ts.Switch(tv);

    //        ts.Switch(bl);
    //        ts.Switch(bl);

    //        ts.Switch(tl);
    //        ts.Switch(tl);

    //    }
    //}


    public class ToggleSwitch
    {
        public void Switch(ISwitchable device)
        {
            if (device.IsOn)
                device.TurnOff();
            else
                device.TurnOn();

            device.IsOn = !device.IsOn;
        }

    }


    public interface ISwitchable
    {
        bool IsOn { get; set; }
        void TurnOn();
        void TurnOff();
    }

    public class TV : ISwitchable
    {
        public bool IsOn { get; set; }

        public void TurnOff()
        {
            Console.WriteLine("TV turn off");
        }
        public void TurnOn()
        {
            Console.WriteLine("TV turn on");
        }
    }

    public class TubeLight : ISwitchable
    {
        public bool IsOn { get; set; }
        public void TurnOff()
        {
            Console.WriteLine("TubeLight turn off");
        }
        public void TurnOn()
        {
            Console.WriteLine("TubeLight turn on");
        }
    }
    public class BulbLight : ISwitchable
    {
        public bool IsOn { get; set; }
        public void TurnOff()
        {
            Console.WriteLine("BulbLight turn off");
        }
        public void TurnOn()
        {
            Console.WriteLine("BulbLight turn on");
        }
    }
}
