using System;

namespace LearningDesignPatterns.Builder
{
    public class TextBox : Control
    {
        public bool IsMultiLines {get; private set;}

        public TextBox(ControlImplementor ControlImplementor, string text, bool isMultiLines)
        {
            _controlImplementor = ControlImplementor;
            this.Text = text;
            this.IsMultiLines = isMultiLines;
        }
        public override string Text {get;set;}

        public override void Show()
        {
            _controlImplementor.RenderTextBox(this.Text, this.IsMultiLines);
        }
    }
}
