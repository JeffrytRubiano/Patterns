using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of form do you like to build?");
            Console.WriteLine("1: Android form.");
            Console.WriteLine("2: iOS form.");
            IGUIFactory factory;

            var style = Console.ReadLine();
            switch (style)
            {
                case "1":
                    factory = new FactoryGUIAndroid();
                    break;
                case "2":
                    factory = new FactoryGUIiOS();
                    break;
                default:
                    throw new System.NotImplementedException();
            }

            factory.Form().Paint();
            Console.ReadKey();
        }
    }
}
