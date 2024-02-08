using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Dog : Animal, IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public Dog(string Name, string Colour, int Age) : base(Name, Colour, Age) { }
        public Dog(string Name, string Colour, int Age, double Height) : base(Name, Colour, Age) {
            this.Height = Height;
        }
        public override double GetHeight() { return this.Height; }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry() {
            return "Woof!";
        }
    }
}
