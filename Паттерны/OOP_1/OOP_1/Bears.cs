using System;

namespace OOP_1
{
    internal interface Bear
    {
        string Name { get; }
        int Age { get; set; }
        void Growl();

        Bear Clone();
    }

    internal class BrownBear : Bear
    {
        private static readonly string _name = "Brown bear";

        public string Name => _name;

        public int Age { get; set; }

        public BrownBear()
        {
            Age = 0;
        }

        public BrownBear (int age)
        {
            Age = age;
        }

        public void Growl()
        {
            Console.WriteLine($"{_name} growls");
        }

        public Bear Clone()
        {
            return new BrownBear(Age);
        }
    }

    internal class PolarBear : Bear
    {
        private static readonly string _name = "Polar bear";

        public string Name => _name;

        public int Age { get; set; }

        public PolarBear()
        {
            Age = 0;
        }

        public PolarBear(int age)
        {
            Age = age;
        }

        public void Growl()
        {
            Console.WriteLine($"{_name} growls");
        }

        public Bear Clone()
        {
            return new BrownBear(Age);
        }
    }
}
