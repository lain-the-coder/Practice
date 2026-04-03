using System;

namespace Practice
{
	public abstract class Animal
	{
		public const string ShelterName = "Paws & Care";
		public Guid ID {get; }
		private static int _count;
		private int _healthscore;
		public static int Count
		{
			get
			{
				return _count;
			}
			private set
			{
				if (value < 0)
				{
					throw new ArgumentException("Count cannot be negative");
				}
				_count = value;
			}
		}
		public string Name {get; }
		public string Species {get; }
		public int Age {get; }
		public int Healthscore
		{
			get
			{
				return _healthscore;
			}
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Value has to be between 0 and 100.");
				}
				_healthscore = value;
			}
		}
		static Animal()
		{
			Console.WriteLine("Animal registry initialized");
		}
		public Animal(string name, string species, int age, int healthscore)
		{
			Count++;
			ID = Guid.NewGuid();
			Name = name;
			Species = species;
			Age = age;
			Healthscore = healthscore;
		}
		public Animal(string name, string species, int age) : this(name, species, age, 100)
		{
			
		}
		public Animal(string name) : this(name, "Unknown", 0, 100)
		{
			
		}
		public void PrintDetails()
		{
			Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, HealthScore: {Healthscore}");
		}
		public void PrintDetails(bool shortForm)
		{
			if (shortForm)
			{
				Console.WriteLine($"Animal name is {Name}");
			}
		}
		public void Treatment(string treatmentname, int healamount = 10, bool log = false)
		{
			Healthscore = Math.Min(100, Healthscore + healamount);
			if (log)
			{
				Console.WriteLine($"Treatment {treatmentname} applied, +{healamount}HP");
			}
		}
		public abstract void MakeSound();
		public virtual void Eat()
		{
			Console.WriteLine("All animals ingest their food");	
		}
		public void Describe()
		{
			Console.WriteLine("Animal");
		} 
	}
}
