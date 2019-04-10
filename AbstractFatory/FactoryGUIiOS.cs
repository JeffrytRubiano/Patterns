namespace AbstractFactory
{
    public class FactoryGUIiOS : IGUIFactory
    {
        public IForm Form()
        {
            return new FormiOS();
        }
    }
}
