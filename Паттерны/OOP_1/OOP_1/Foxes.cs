using System;

namespace OOP_1
{
    internal interface Fox
    {
        string Name { get; }
        void Run();
    }

    internal class PolarFox : Fox
    {
        private static readonly string _name = "Polar fox";

        public string Name => _name;

        public void Run()
        {
            Console.WriteLine($"{_name} is running");
        }
    }

    internal class CommonFox : Fox
    {
        private static readonly string _name = "Common fox";

        public string Name => _name;

        public void Run()
        {
            Console.WriteLine($"{_name} is running");
        }
    }
}
