///该示例为UI在 MacOS和Windows系统下的工厂创建模式
///参考：https://refactoring.guru/design-patterns/abstract-factory

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Example2
{

    class program
    {
        //static void Main(string[] args)
        //{
        //    ApplicationConfigurator configurator = new ApplicationConfigurator();
        //    Application app = configurator.GetApp();
        //    app.CreateUI();
        //    app.ButtonPaint();
        //    app.CheckboxPaint();

        //    configurator.SetOS("Mac");
        //    app = configurator.GetApp();
        //    app.CreateUI();
        //    app.ButtonPaint();
        //    app.CheckboxPaint();


        //}
    }



    public interface GUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }


    public class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }


    public class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }


   
}
