using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // REQUIREMENT 1 — three constructors
            //Animal a1 = new Animal("Buddy", "Dog", 3, 80);
            //Animal a2 = new Animal("Milo", "Cat", 5);
            /* Animal a3 = new Animal("Unknown");
             // REQUIREMENT 2 — treatment three ways
             a1.Treatment("Vaccine", 15, true);
             a1.Treatment("Checkup", log: true);
             a1.Treatment("Rest");
             // REQUIREMENT 3 — both print versions
             a1.PrintDetails();
             a1.PrintDetails(true);
             // REQUIREMENT 4 — invalid health score
             try
             {
                # a1.Healthscore = 150;
             }
             catch (ArgumentException e)
             {
                # Console.WriteLine($"Error: {e.Message}");
             }
             // REQUIREMENT 5 — reference type gotcha
             Animal ref1 = a1;
             ref1.Treatment("Emergency", 20);
             Console.WriteLine($"a1 health after modifying via ref1: {a1.Healthscore}");
             // REQUIREMENT 6 — count and shelter name
             Console.WriteLine($"Total animals: {Animal.Count}");
             Console.WriteLine($"Shelter: {Animal.ShelterName}");*/

            // ── SECTION 07 ASSIGNMENT ────────────────────────────────────

            // REQUIREMENT 1 — one Dog, one Cat, one GuideDog stored in Animal array
            Animal[] animals = new Animal[]
            {
                new Dog("Rex", "Dog", 4, 90, "Labrador"),
                new Cat("Whiskers", "Cat", 2, true),
                new GuideDog("Bolt", "Dog", 5, 95, "German Shepherd", "John")
            };

            // REQUIREMENT 2 — runtime dispatch: same call, each picks its own MakeSound
            Console.WriteLine("\n-- MakeSound (runtime dispatch) --");
            foreach (Animal a in animals)
            {
                a.MakeSound(); // actual type wins: Dog, Cat, GuideDog versions
            }

            // REQUIREMENT 3 — eating: sealed vs non-sealed
            Console.WriteLine("\n-- Eat (sealed vs non-sealed) --");
            foreach (Animal a in animals)
            {
                a.Eat(); // Dog calls base.Eat() then its own; Cat is sealed; GuideDog overrides freely
            }

            // REQUIREMENT 4 — method hiding: Animal reference vs GuideDog reference
            Console.WriteLine("\n-- Describe (hiding demonstration) --");
            Animal animalRef = new GuideDog("Bolt", "Dog", 5, 95, "German Shepherd", "John");
            GuideDog guideDogRef = new GuideDog("Bolt", "Dog", 5, 95, "German Shepherd", "John");
            animalRef.Describe();   // "Animal" — reference type wins (hiding)
            guideDogRef.Describe(); // "GuideDog" — reference is GuideDog so new method is visible

            // REQUIREMENT 5 — cannot instantiate Animal directly
            // new Animal("Test", "Unknown", 0, 100); // ❌ compile error — Animal is abstract,
                                                      // it's a concept not a real object

            // REQUIREMENT 6 — PrintDetails works on all via inheritance
            Console.WriteLine("\n-- PrintDetails (inherited behavior) --");
            foreach (Animal a in animals)
            {
                a.PrintDetails();
            }
        }
    }
}
