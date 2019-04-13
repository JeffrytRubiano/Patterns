namespace FactoryMethod
{
    public interface ICreatorQuiz
    {
        IQuiz CreateQuiz(QuizType type);
    }
}