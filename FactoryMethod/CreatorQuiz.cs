namespace FactoryMethod
{
    public class CreatorQuiz : ICreatorQuiz
    {
        public IQuiz CreateQuiz(QuizType type)
        {
            IQuiz quiz;
            switch (type)
            {
                case QuizType.Advance:
                    quiz = new AdvanceQuiz();
                    break;

                case QuizType.Standar:
                    quiz = new StandarQuiz();
                    break;

                default:
                    throw new System.NotImplementedException();
            }

            return quiz;
        }
    }
}