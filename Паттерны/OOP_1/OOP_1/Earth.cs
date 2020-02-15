using System;

namespace OOP_1
{
    internal class Earth
    {
        private static Lazy<Earth> lazy = new Lazy<Earth>(() => new Earth());

        public void EarthShake()
        {
            Console.WriteLine("Shake");
        }

        private Earth() { }

        public static Earth GetInstance()
        {
            return lazy.Value;
        }
    }
}
