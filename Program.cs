using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // REQUIREMENT 1 — three constructors
            Animal a1 = new Animal("Buddy", "Dog", 3, 80);
            Animal a2 = new Animal("Milo", "Cat", 5);
            Animal a3 = new Animal("Unknown");

            // REQUIREMENT 2 — treatment three ways
            a1.Treatment("Vaccine", 15, true);  // all arguments
            a1.Treatment("Checkup", log: true); // skip healamount
            a1.Treatment("Rest");               // all defaults

            // REQUIREMENT 3 — both print versions
            a1.PrintDetails();
            a1.PrintDetails(true);

            // REQUIREMENT 4 — invalid health score
            try
            {
                a1.Healthscore = 150;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // REQUIREMENT 5 — reference type gotcha
            Animal ref1 = a1;
            ref1.Treatment("Emergency", 20);
            Console.WriteLine($"a1 health after modifying via ref1: {a1.Healthscore}");

            // REQUIREMENT 6 — count and shelter name
            Console.WriteLine($"Total animals: {Animal.Count}");
            Console.WriteLine($"Shelter: {Animal.ShelterName}");
        }
    }
}
