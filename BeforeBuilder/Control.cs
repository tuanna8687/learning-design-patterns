using System;

namespace LearningDesignPatterns.BeforeBuilder
{
    public abstract class Control
    {
        public abstract string Text {get;set;}
        public abstract void Show();
    }
}
