using System;

namespace OOP_4
{
    internal class Calculator
    {
        private static int Evaluate(int first, int second, string operation)
        {
            switch (operation[0])
            {
                case '&':
                    return first & second;
                case '|':
                    return first | second;
                case '^':
                    return first ^ second;
                default:
                    throw new InvalidOperationException();
            }
        }

        public static int Parse(string[] source)
        {
            if (source.Length < 2)
            {
                throw new IndexOutOfRangeException();
            }

            if (source[source.Length - 1][0] == '~')
            {
                if (int.TryParse(source[source.Length - 2], out int negInt))
                {
                    return ~negInt;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }


            if (source.Length != 3)
            {
                throw new ArgumentException();
            }

            if (int.TryParse(source[source.Length - 3], out int firstValue)
                && int.TryParse(source[source.Length - 1], out int secondValue))
            {
                return Evaluate(firstValue, secondValue, source[source.Length - 2]);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}