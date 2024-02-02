using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Board;

        public Collectable(string description)
        {
            this.Description = description;
        }

        public virtual void AddMe(List<Collectable> collectable)
        {
            collectable.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }

        public abstract void Display();
    }
}
