using System;

namespace Practice
{
	public class Cat : Animal
	{
		public bool Indooronly {get; }

		public Cat (string name, string species, int age, bool indooronly) : base (name, species, age)
		{
			Indooronly = indooronly;
		}
		public override void MakeSound()
		{
			Console.WriteLine("Meow Meow");
		}
		public sealed override void Eat()
		{
			Console.WriteLine("I eat uniquely.");
		}
		
	}
}
