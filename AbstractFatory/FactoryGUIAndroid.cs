namespace AbstractFactory
{
    public class FactoryGUIAndroid : IGUIFactory
    {
        public IForm Form()
        {
            return new FormAndroid();
        }
    }
}
