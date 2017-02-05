using System;

namespace LearningDesignPatterns.Builder
{
    public class WindowsImplementor : ControlImplementor
    {
        public override void RenderButton(string text, bool isEnable)
        {
            Console.WriteLine("Windows button - Text: {0} - Is enable: {1}", text, isEnable);
        }

        public override void RenderTextBox(string text, bool isMultiLines)
        {
            Console.WriteLine("Windows text box - Text: {0} - Is multi-lines: {1}", text, isMultiLines);
        }
    }
}
