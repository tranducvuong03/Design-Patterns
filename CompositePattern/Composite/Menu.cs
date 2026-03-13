using DesignPatterns.CompositePattern.Component;

namespace DesignPatterns.CompositePattern.Composite
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent component)
        {
            menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            menuComponents.Remove(component);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            Console.WriteLine("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            foreach (MenuComponent component in menuComponents)
            {
                component.Print();
            }
        }
    }
}
