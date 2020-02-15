using System;

namespace OOP_1
{
    internal interface Bear
    {
        string Name { get; }
        void Growl();
    }

    internal class BrownBear : Bear
    {
        private static readonly string _name = "Brown bear";

        public string Name => _name;

        public void Growl()
        {
            Console.WriteLine($"{_name} growls");
        }
    }

    internal class PolarBear : Bear
    {
        private static readonly string _name = "Polar bear";

        public string Name => _name;

        public void Growl()
        {
            Console.WriteLine($"{_name} growls");
        }
    }
}
