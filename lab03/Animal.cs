using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        protected string Colour { get; set; }
        protected int Age { get; set; }

        protected Animal(string Name, string Colour, int Age) { 
            this.Name = Name;
            this.Colour = Colour;
            this.Age = Age;
        }

        public string GetName() { return this.Name; }
        public void SetName(string Name) { this.Name = Name; }
        public string GetColour() { return this.Colour; }
        public void SetColour(string Colour) { this.Colour = Colour; }
        public int GetAge() { return this.Age; }
        public void SetAge(int Age) { this.Age = Age; }
        public abstract void Eat();
        public abstract double GetHeight();
    }
}
