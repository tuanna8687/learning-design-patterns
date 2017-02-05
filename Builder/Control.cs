using System;

namespace LearningDesignPatterns.Builder
{
    public abstract class Control
    {
        public abstract string Text {get;set;}
        public abstract void Show();

        protected ControlImplementor _controlImplementor;
    }
}
