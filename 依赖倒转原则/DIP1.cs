using System;
using System.Collections.Generic;
using System.Text;

namespace NotUseDesignPattern
{

    //public class Client
    //{

    //    static void Main(string[] args)
    //    {
    //        ToggleSwitch ts = new ToggleSwitch();
    //        Light light = new Light();
    //        TV tv = new TV();

    //        ts.SwitchLight(light);
    //        ts.SwitchLight(light);

    //        ts.SwitchTV(tv);
    //        ts.SwitchTV(tv);

    //    }
    //}

   
    public class ToggleSwitch
    {
       
        public void SwitchLight(Light light )
        {
            if (light.isOn)
                light.TurnOff();
            else
                light.TurnOn();

            light.isOn = !light.isOn;
        }

        public void SwitchTV(TV tv)
        {
            if (tv.isOn)
                tv.TurnOff();
            else
                tv.TurnOn();

            tv.isOn = !tv.isOn;
        }

       

    }

    public class Light
    {
        public bool isOn;
        public void TurnOff()
        {
            Console.WriteLine("Light turn off");
        }
        public void TurnOn()
        {
            Console.WriteLine("Light turn on");
        }
    }
    public class TV
    {
        public bool isOn;
        public void TurnOff()
        {
            Console.WriteLine("TV turn off");
        }
        public void TurnOn()
        {
            Console.WriteLine("TV turn on");
        }
    }
}
