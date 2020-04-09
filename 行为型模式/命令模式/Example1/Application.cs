using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.行为型模式.命令模式.Example1
{
    public class Application
    {
        public string clipboard;
        public Editor[] editors;
        public Editor activateEditor;
        public CommandHistory history;



    }

    public class Text
    {

    }

    public class Editor
    {
        public  string text;

        public string GetSelection()
        {
            return null;
        }
    }
}
