using System;

namespace LearningDesignPatterns.BeforeBuilder
{
    public class MacTextBox : TextBox
    {
        public override string Text {get;set;}

        public override void Show()
        {
            Console.WriteLine("Mac text box - Text: {0} - Is multi-lines: {1}", this.Text, this.IsMultiLines);
        }

        public override bool IsMultiLines {get;set;}
    }
}
