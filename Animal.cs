using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        public string Name { get; set; } = "";
        public Animal(string name)
        {
            this.Name = name;
        }
        public virtual void Info(string name)
        {
            Console.WriteLine($"Name: {name}");
        }
        

    }
    public class Tiger : Animal
    {
        public string Name { get; set; }
        public Tiger(string name = "") : base(name)
        {
            
        }
        public override void Info (string name)
        {
            Console.WriteLine("Tiger");
            base.Info(name);
        }

    }
}
