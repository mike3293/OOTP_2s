using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Pen pen = new Pen();
            Console.WriteLine(student.Stuff(pen));

            Chalk chalk = new Chalk();
            IPen chalkStuff = new ChalkToPenAdapter(chalk);
            Console.WriteLine(student.Stuff(chalkStuff));

            Console.WriteLine();

            Cake Cake1 = new AppleCake();
            Cake1 = new DeliveryCake(Cake1);
            Console.WriteLine(String.Format("Name: {0}", Cake1.Name));
            Console.WriteLine(String.Format("Cost: {0}\n", Cake1.GetCost()));

            Cake Cake2 = new AppleCake();
            Cake2 = new ThereCake(Cake2);
            Console.WriteLine(String.Format("Name: {0}", Cake2.Name));
            Console.WriteLine(String.Format("Cost: {0}\n", Cake2.GetCost()));

            Cake Cake3 = new ChocolateCake();
            Cake3 = new DeliveryCake(Cake3);
            Console.WriteLine(String.Format("Name: {0}", Cake3.Name));
            Console.WriteLine(String.Format("Cost: {0}\n", Cake3.GetCost()));

            Cake Cake4 = new ChocolateCake();
            Cake4 = new ThereCake(Cake4);
            Console.WriteLine(String.Format("Name: {0}", Cake4.Name));
            Console.WriteLine(String.Format("Cost: {0}\n", Cake4.GetCost()));


            Component Box = new Box("big box:");

            Component smallBox = new Box("small box");
            Component Item1 = new Item("book");
            Component Item2 = new Item("mobile");

            smallBox.Add(Item1);
            smallBox.Add(Item2);

            Box.Add(smallBox);
            Console.WriteLine(Box.Print());


            smallBox.Remove(Item1);

            Component newBox = new Box("Gift box");

            Component Item3 = new Item("Candy");
            Component Item4 = new Item("Letter");
            newBox.Add(Item3);
            newBox.Add(Item4);
            Box.Add(newBox);

            Console.WriteLine(Box.Print());

            Console.WriteLine(Box.Search("Letter"));
            Console.WriteLine(Box.Search("Toy"));

            Console.ReadKey();
        
        }
    }
}
