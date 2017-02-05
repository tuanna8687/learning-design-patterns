using System;

namespace LearningDesignPatterns.BeforeBuilder
{
    public class MacButton : Button
    {
        public override string Text {get;set;}

        public override void Show()
        {
            Console.WriteLine("Mac button - Text: {0} - Is enable: {1}", this.Text, this.IsEnable);
        }

        public override bool IsEnable {get;set;}
    }
}
