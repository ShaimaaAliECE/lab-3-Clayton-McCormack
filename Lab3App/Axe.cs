using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {

        public Axe(string description) : base(description) { }

        public override void DoAction()
        {
            Console.WriteLine("Axe is used.");
        }

        public override void Display()
        {
            Console.WriteLine(GetType().Name + " " + Description + " is displayed.");
        }
    }
}
