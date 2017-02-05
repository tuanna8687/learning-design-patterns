using System;

namespace LearningDesignPatterns.Builder
{
    public abstract class ControlImplementor
    {
        public abstract void RenderButton(string text, bool isEnable);
        public abstract void RenderTextBox(string text, bool isMultiLines);
    }
}
