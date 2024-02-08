using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Cat: Animal, IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public Cat(string Name, string Colour, int Age) : base(Name, Colour, Age) { }
        public Cat(string Name, string Colour, int Age, double Height) : base(Name, Colour, Age) {
            this.Height = Height;
        }

        public override double GetHeight() { return this.Height; }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public string Cry() {
            return "Meow!";
        }
    }
}
