using System;

namespace LearningDesignPatterns.Builder
{
    public class MacImplementor : ControlImplementor
    {
        public override void RenderButton(string text, bool isEnable)
        {
            Console.WriteLine("Mac button - Text: {0} - Is enable: {1}", text, isEnable);
        }

        public override void RenderTextBox(string text, bool isMultiLines)
        {
            Console.WriteLine("Mac text box - Text: {0} - Is multi-lines: {1}", text, isMultiLines);
        }
    }
}
