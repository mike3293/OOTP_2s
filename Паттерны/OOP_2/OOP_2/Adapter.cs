using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    interface IPen
    {
        string Write();
    }

    class Pen : IPen
    {
        public string Write()
        {
            return "Write pith pen";
        }
    }

    interface IChalk
    {
        string Draw();
    }

    class Chalk : IChalk
    {
        public string Draw()
        {
            return "Write with chulk";
        }
    }

    class Student
    {
        public string Stuff(IPen stuff)
        {
            return stuff.Write();
        }
    }



    class ChalkToPenAdapter : IPen
    {
        Chalk chalk;
        public ChalkToPenAdapter(Chalk c)
        {
            chalk = c;
        }

        public string Write()
        {
            return chalk.Draw();
        }
    }
}
