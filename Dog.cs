using System;

namespace Practice
{
	public class Dog : Animal
	{
		public string Breed {get; }

		public Dog(string name, string species, int age, int healthscore, string breed) : base(name, species, age, healthscore)
		{
			Breed = breed;	
		}
		public override void MakeSound()
		{
			Console.WriteLine("Woof Woof!");
		}
		public override void Eat()
		{
			base.Eat();
			Console.WriteLine("Dog eats on four feet.");
		}	
	}
}
