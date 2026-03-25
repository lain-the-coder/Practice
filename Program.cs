using System;

namespace Practice
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				int i = 1;
				foreach (var arg in args)
				{
					Console.WriteLine($"Argument {i}: {arg}");
				}
			}
			else
			{
				Console.WriteLine("No arguments provided!");
			}
			Console.Write("What is your favorite day of the week: ");
			string input1 = Console.ReadLine()!;
			string day = string.IsNullOrEmpty(input1) ? "No day provideed" : input1;
			Console.WriteLine($"Day given is: {day}");
			Console.Write("Enter a valid integer: ");
			int parsedOutput;
			string input2;
			bool success = false;
			while (!success)
			{
				input2 = Console.ReadLine()!;
				success = int.TryParse(input2, out parsedOutput);
				if (success)
				{
					Console.WriteLine($"Your output is: {parsedOutput}");
				}
				else
				{
					Console.Write("Please enter a valid integer: ");
				}
			}
		}
	}
}
