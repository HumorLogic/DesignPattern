using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.创建型类模式.工厂方法模式.Example1
{
    public interface Button
    {
        void Render();
        void OnClick();
    }

    public class WindowsButton : Button
    {
        public void OnClick()
        {
            Console.WriteLine("WinButton Clicked");
        }

        public void Render()
        {
            Console.WriteLine("WinButton Render");
        }
    }

    public class HTMLButton : Button
    {
        public void OnClick()
        {
            Console.WriteLine("HTMLButton Clicked");
        }

        public void Render()
        {
            Console.WriteLine("HTMLButton Render");
        }
    }
}
