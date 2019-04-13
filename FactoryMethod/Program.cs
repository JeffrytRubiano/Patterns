using System;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICreatorQuiz factory = new CreatorQuiz();

            Console.WriteLine("Standard quiz");
            Console.WriteLine(" Questions:");
            var standar = factory.CreateQuiz(QuizType.Standar).GetQuestions();
            foreach (var q in standar)
            {
                Console.WriteLine($"  {q}");
            }
            Console.WriteLine("");
            Console.WriteLine("Advance quiz");
            Console.WriteLine(" Questions:");
            var adv = factory.CreateQuiz(QuizType.Advance).GetQuestions();
            foreach (var q in adv)
            {
                Console.WriteLine($"  {q}");
            }

            Console.Read();
        }
    }
}