using System;

namespace Lab_3
{
    internal interface ICommand
    {
        void Execute();
    };

    public class JumpCommand : ICommand
    {
        public void Execute()
        {
            Jump();
        }

        private void Jump()
        {
            Console.WriteLine("Прыжок!");
        }
    };

    public class FireCommand : ICommand
    {
        public void Execute()
        {
            Fire();
        }

        private void Fire()
        {
            Console.WriteLine("Огонь!");
        }
    };

    public class ClimbCommand : ICommand
    {
        public void Execute()
        {
            Climb();
        }

        private void Climb()
        {
            Console.WriteLine("Подниматься!");
        }
    };
}
