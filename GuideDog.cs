using System;

namespace Practice
{
	public class GuideDog : Dog
	{
		public string OwnerName {get; }

		public GuideDog(string name, string species, int age, int healthscore, string breed, string ownername) : base(name, species, age, healthscore, breed)
		{
			OwnerName = ownername;
		}
		public sealed override void MakeSound()
		{
			Console.WriteLine("Makes guidedog sounds");
		}
		public override void Eat()
		{
			Console.WriteLine("I am very discplined when i eat");
		}
		public new void Describe()
		{
		    Console.WriteLine("GuideDog");
		}
	}
}
