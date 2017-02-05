using System;
using LearningDesignPatterns.BeforeBuilder;

namespace LearningDesignPatterns.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------Before applying buidler pattern----------");
            Button btn = new WindowsButton();
            btn.Text = "Hello";
            btn.IsEnable = true;
            btn.Show();

            btn = new MacButton();
            btn.Text = "Hello";
            btn.IsEnable = true;
            btn.Show();

            TextBox txt = new WindowsTextBox();
            txt.Text = "Hello";
            txt.IsMultiLines = true;
            txt.Show();

            txt = new MacTextBox();
            txt.Text = "Hello";
            txt.IsMultiLines = false;
            txt.Show();

            Console.WriteLine("----------Applying buidler pattern----------");
            LearningDesignPatterns.Builder.ControlImplementor controlImplementor = new LearningDesignPatterns.Builder.WindowsImplementor();
            LearningDesignPatterns.Builder.Control newBtn = new LearningDesignPatterns.Builder.Button(controlImplementor, "Hello Builder", true);
            newBtn.Show();

            controlImplementor = new LearningDesignPatterns.Builder.MacImplementor();
            newBtn = new LearningDesignPatterns.Builder.Button(controlImplementor, "Hello Builder", true);
            newBtn.Show();

            controlImplementor = new LearningDesignPatterns.Builder.WindowsImplementor();
            LearningDesignPatterns.Builder.Control newTxt = new LearningDesignPatterns.Builder.TextBox(controlImplementor, "Hello Builder", false);
            newTxt.Show();

            controlImplementor = new LearningDesignPatterns.Builder.MacImplementor();
            newTxt = new LearningDesignPatterns.Builder.TextBox(controlImplementor, "Hello Builder", false);
            newTxt.Show();

            Console.ReadLine();
        }
    }
}
