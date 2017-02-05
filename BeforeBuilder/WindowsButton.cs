using System;

namespace LearningDesignPatterns.BeforeBuilder
{
    public class WindowsButton : Button
    {
        public override string Text {get;set;}

        public override void Show()
        {
            Console.WriteLine("Windows button - Text: {0} - Is enable: {1}", this.Text, this.IsEnable);
        }

        public override bool IsEnable {get;set;}
    }
}
