using FactoryMethod;
using System.Collections.Generic;

namespace LazyInitialization
{
    /// <summary>
    /// This project depends the Factory method to create the object "Quiz".
    /// </summary>
    public class LazyFactoryQuiz
    {
        private IDictionary<QuizType, IQuiz> _LazyObjectList = new Dictionary<QuizType, IQuiz>();

        public LazyFactoryQuiz()
        {
            // empty constructor
        }

        /// <summary>
        /// Get the complex object.
        /// </summary>
        public IQuiz GetQuizByType(QuizType quizType)
        {
            // Validate if the object is already created.
            if (!_LazyObjectList.TryGetValue(quizType, out IQuiz quiz))
                quiz = CallFactoryMethod(quizType);

            return quiz;
        }

        /// <summary>
        /// Call the pattern factory to create the complex object.
        /// </summary>
        private IQuiz CallFactoryMethod(QuizType quizType)
        {
            ICreatorQuiz factory = new CreatorQuiz();
            IQuiz quiz = factory.CreateQuiz(quizType);
            _LazyObjectList.Add(quizType, quiz);

            return quiz;
        }
    }
}