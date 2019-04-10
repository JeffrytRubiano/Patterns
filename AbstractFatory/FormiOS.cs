using System;

namespace AbstractFactory
{
    public class FormiOS : IForm
    {
        public void Paint()
        {
            Console.WriteLine("iOS form was built");
        }
    }
}
