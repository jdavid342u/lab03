namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = GetStrInput("Dog Name", 3);
            Dog UserDog = new Dog(dogName, "Brown", 8);
            Console.WriteLine($"Dog name: {UserDog.GetName()}");
            Console.WriteLine($"Dog colour: {UserDog.GetColour()}");
            Console.WriteLine($"Dog age: {UserDog.GetAge().ToString()}");
            UserDog.Eat();

            Console.WriteLine();

            string catName = GetStrInput("Cat Name", 3);
            Cat UserCat = new Cat(catName, "Black", 42);
            Console.WriteLine($"Cat name: {UserCat.GetName()}");
            Console.WriteLine($"Cat colour: {UserCat.GetColour()}");
            Console.WriteLine($"Cat age: {UserCat.GetAge().ToString()}");
            UserCat.Eat();

            Console.WriteLine();

            Animal dog02 = GetAnimal("Dog");
            Console.WriteLine($"\nDog Name: {dog02.GetName()}");
            Console.WriteLine($"Dog Colour: {dog02.GetColour()}");
            Console.WriteLine($"Dog Age: {dog02.GetAge()}");
            Console.WriteLine($"Dog Height: {dog02.GetHeight()}\n");

            Animal cat02 = GetAnimal("Cat");
            Console.WriteLine($"\nCat Name: {cat02.GetName()}");
            Console.WriteLine($"Cat Colour: {cat02.GetColour()}");
            Console.WriteLine($"Cat Age: {cat02.GetAge()}");
            Console.WriteLine($"Cat Height: {cat02.GetHeight()}\n");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Doggy", "Green", 6, 2.3));
            animals.Add(new Cat("BlackCat", "Black", 42, 3.33));
            animals.Add(new Cat("Poe", "Dark Gray", 25, 1.5));
            animals.Add(new Dog("Matt", "Blue", 40));
            animals.Add(new Cat("Shady", "Black", 33, 42));

            Console.WriteLine("Animal(s) list name(s):\n");
            foreach (Animal animal in animals) {
                Console.WriteLine(animal.GetName());
            }
        }

        static string GetStrInput(string obj = "Object", int minLength = 1, bool showPrompt = true)
        {
            if (minLength < 1) { minLength = 1; }
            if (showPrompt)
            {
                Console.WriteLine($"Hello, please provide {obj} (minimum {minLength.ToString()} character(s)):");
            }

            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) || name.Length < minLength)
            {
                Console.WriteLine($"Please provide a valid name (minimum {minLength.ToString()} character(s)):");
                name = Console.ReadLine();
            }

            return name;
        }

        static Animal GetAnimal(string kind)
        {
            string animalName = GetStrInput($"{kind} Name", 3);
            string animalColor = GetStrInput($"{kind} Colour", 3);

            int animalAge;
            Console.WriteLine($"Please provide {kind} age:");
            bool validInput = int.TryParse(Console.ReadLine(), out animalAge);

            while (!validInput || animalAge < 0)
            {
                Console.WriteLine($"Please provide a valid {kind} age:");
                validInput = int.TryParse(Console.ReadLine(), out animalAge);
            }

            double animalHeight;
            Console.WriteLine($"Please provide {kind} height:");
            validInput = double.TryParse(Console.ReadLine(), out animalHeight);

            while (!validInput || animalHeight <= 0)
            {
                Console.WriteLine($"Please provide a valid {kind} height:");
                validInput = double.TryParse(Console.ReadLine(), out animalHeight);
            }

            Animal animal;
            if (kind.ToLower().Trim() == "dog")
            {
                animal = new Dog(animalName, animalColor, animalAge, animalHeight);
            }
            else
            {
                animal = new Cat(animalName, animalColor, animalAge, animalHeight);
            }

            return animal;
        }
    }
}
