using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AbstractFactoryPattern.Example2;

namespace DesignPattern.创建型类模式.工厂方法模式.Example1
{
  //class program
  //  {
  //      static void Main(string[] arg)
  //      {
  //          Application app = new Application();
  //          app.Main();
  //      }
  //  }


    public class Application
    {
        private Dialog dialog;
        private Config config ;
        private ApplicationConfigurator configurator = new ApplicationConfigurator();


        void Initialize()
        {
            
            config = configurator.ReadApplicationConfiFile();
            configurator.SetOS("Web");

            if (config.OS == "Windows")
            {
                dialog = new WindowsDialog();
            }else if (config.OS == "Web")
            {
                dialog = new WedDialog();
            }
            else
            {
                throw new Exception("Error! Unknown operating system.");
            }

        }

    public   void Main()
        {
            this.Initialize();
            dialog.Render();
            
        } 
    }


  public abstract class Dialog
    {
        public abstract Button CreateButton();
        
        public void Render()
        {
            Button btn = CreateButton();
            btn.OnClick();
            btn.Render();
        }
    }

    public class WindowsDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }
    }

    public class WedDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new HTMLButton();
        }
    }

}
