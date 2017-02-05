using System;

namespace LearningDesignPatterns.BeforeBuilder
{
    public class WindowsTextBox : TextBox
    {
        public override string Text {get;set;}

        public override void Show()
        {
            Console.WriteLine("Windows text box - Text: {0} - Is multi-lines: {1}", this.Text, this.IsMultiLines);
        }

        public override bool IsMultiLines {get;set;}
    }
}
