using System.Collections.Generic;

namespace FactoryMethod
{
    public interface IQuiz
    {
        IReadOnlyList<string> GetQuestions();
    }
}