using System;

namespace LearningDesignPatterns.Builder
{
    public class Button : Control
    {
        public Button(ControlImplementor ControlImplementor, string text, bool isEnable)
        {
            _controlImplementor = ControlImplementor;
            this.IsEnable = isEnable;
            this.Text = text;
        }

        public bool IsEnable {get; private set;}

        public override string Text {get;set;}

        public override void Show()
        {
            _controlImplementor.RenderButton(this.Text, this.IsEnable);
        }
    }
}
