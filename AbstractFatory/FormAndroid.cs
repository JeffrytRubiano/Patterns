using System;

namespace AbstractFactory
{
    public class FormAndroid : IForm
    {
        public void Paint()
        {
            Console.WriteLine("Android form was built");
        }
    }
}
