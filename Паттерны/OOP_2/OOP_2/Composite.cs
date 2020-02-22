using System.Collections.Generic;

namespace OOP_2
{
    internal abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual string Search(string itemName)
        {
            return "";
        }
        public virtual string GetName()
        {
            return "";
        }

        public virtual string Print()
        {
            return name;
        }
    }

    internal class Box : Component
    {
        private List<Component> components = new List<Component>();

        public Box(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override string GetName()
        {
            return name;
        }

        public override string Search(string itemName)
        {
            string result = "";

            for (int i = 0; i < components.Count; i++)
            {
                foreach (Item item in (components[i] as Box).components)
                {
                    if (components[i].GetName() == itemName)
                    {
                        result = "item found";
                    }
                    if (item.GetName() == itemName)
                    {
                        result = "item found";
                    }
                }
            }

            if (result == "")
            {
                result = "item not found";
            }

            return result;
        }

        public override string Print()
        {
            string message = "";
            message += name.ToUpper() + "\n";
            for (int i = 0; i < components.Count; i++)
            {
                message += "- " + components[i].Print() + "\n";
            }
            return message;
        }
    }

    internal class Item : Component
    {
        public Item(string name)
                : base(name)
        { }

        public override string Print()
        {
            return name;
        }

        public override string GetName()
        {
            return name;
        }

    }
}
