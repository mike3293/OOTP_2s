using System;

namespace Lab_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.KeyChar)
                {
                    case 'w':
                        {
                            JumpCommand jump = new JumpCommand();
                            jump.Execute();
                            break;
                        }
                    case 'd':
                        {
                            ClimbCommand climb = new ClimbCommand();
                            climb.Execute();
                            break;
                        }
                    case 's':
                        {
                            FireCommand fire = new FireCommand();
                            fire.Execute();
                            break;
                        }
                    default: break;
                }
            }


            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
            water.Frost();


            Person person = new Person();
            PersonState state = person.GetState();


            Console.ReadKey();
        }
    }
}
