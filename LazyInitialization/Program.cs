using System;
using System.Linq;

namespace LazyInitialization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Create Quiz object: standard");
            var quizFactory = new LazyFactoryQuiz();
            var standard = quizFactory.GetQuizByType(FactoryMethod.QuizType.Standard);
            standard.GetQuestions().ToList().ForEach(f => Console.WriteLine($"  {f}"));

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Call again to try to create the object.");
            var standardTwo = quizFactory.GetQuizByType(FactoryMethod.QuizType.Standard);
            // standard and standardTwo have the same object instance.
            standardTwo.GetQuestions().ToList().ForEach(f => Console.WriteLine($"  {f}"));
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("GetQuestion() generate new question but you can check that is the same object.");
        }
    }
}