using System;

namespace LearningDesignPatterns.BeforeBuilder
{
    public abstract class TextBox : Control
    {
        public abstract bool IsMultiLines {get;set;}
    }
}
