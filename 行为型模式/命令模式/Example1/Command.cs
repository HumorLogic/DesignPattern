using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.行为型模式.命令模式.Example1
{
    public abstract class Command
    {
        
        protected Application app;
        protected Editor editor;
        protected string backup;

        public Command(Application app, Editor editor)
        {
            this.app = app;
            this.editor = editor;
        }

        public void SaveBackUp()
        {
            backup = editor.text;
        }

        public void Undo()
        {
            editor.text = backup;
        }

        public abstract void Execute();

    }


    public class CopyCommand : Command
    {
        public CopyCommand(Application app,Editor editor) : base(app,editor)
        {

        }
        public override void Execute()
        {
            app.clipboard = editor.GetSelection();
        }
    }

    public class CommandHistory
    {
    }
}
