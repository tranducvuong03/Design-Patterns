using DesignPatterns.CompositePattern.Component;

namespace DesignPatterns.CompositePattern
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }
    }
}
