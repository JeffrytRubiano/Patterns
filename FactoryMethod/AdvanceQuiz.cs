using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public class AdvanceQuiz : IQuiz
    {
        public IReadOnlyList<string> GetQuestions()
        {
            return new List<string>()
            {
               Guid.NewGuid().ToString(),
               Guid.NewGuid().ToString(),
               Guid.NewGuid().ToString()
            };
        }
    }
}