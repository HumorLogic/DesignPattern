using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Example2
{
    public class Config
    {
        public string OS { get; private set; }
        public Config()
        {
            OS = "Windows";
        }

        public void SetOS(string os)
        {
            if (os == "Windows" || os == "Mac")
            {
                OS = os;
            }
            else return;
        }

    }


    public class ApplicationConfigurator
    {
        //Application app = new Application(new WinFactory());
        Config config;
        GUIFactory factory;
       void main()
        {
            config = ReadApplicationConfiFile();

            if (config.OS == "Windows")
            {
                factory = new WinFactory();
            }
            else if (config.OS == "Mac")
            {
                factory = new MacFactory();
            }
            else
            {
                throw new Exception("Error! Unknown operating system.");
            }

           
        }

        public void SetOS(string os)
        {
            config.SetOS(os);
        }
        public Application GetApp()
        {
            main();
            return new Application(factory);
        }

        Config ReadApplicationConfiFile()
        {
            if (config == null)
                return new Config();
            else return config;
        }
    }


    public class Application
    {
        private GUIFactory factory;
        private Button button;
        private Checkbox checkbox;

        public Application(GUIFactory factory)
        {
            this.factory = factory;
        }

        public void CreateUI()
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
        }

        public void ButtonPaint()
        {
            button.Paint();
        }

        public void CheckboxPaint()
        {
            checkbox.Paint();
        }
    }
}
