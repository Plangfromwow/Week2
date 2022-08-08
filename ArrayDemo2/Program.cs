string[] names = { "Abdul Amin", "Barbara Baker", "Cherine Cooper", "Douglas Dickerson", "Emily Emerson" };
int[] grades = { 95, 98, 85, 80, 70 };

Console.WriteLine($"There are {names.Length} students.");

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{names[i]} has grade {grades[i]}");
}

do
{
	//version 2
	bool okay = false;
	int num = 0;
	while (!okay)
	{
		Console.WriteLine();
		Console.WriteLine("Please enter a number from 1-5:");
		string entry = Console.ReadLine();
		bool validNumber = int.TryParse(entry, out num);

		if (validNumber)
		{
			if (num >= 1 && num <= 5)
			{
				num--;
				okay = true;
			}
		}
	}

	// this code will run after they run a valid number.


	Console.WriteLine($"{names[num]} has grades {grades[num]}");
} while (KeepGoing());


static bool KeepGoing()
{
	while (true)
	{
		// Print out message asking if user wants to continue
		Console.WriteLine("Would you like to go again? (y/n)");
		// Ask the user for their input
		string response = Console.ReadLine();
		response = response.ToLower();
		// Check if they typed "y". If so, return true.
		// Otherwise return false.   YES   yes
		if (response == "y" || response == "yes")
		{
			return true;
		}
		else if (response == "n" || response == "no")
		{
			return false;
		}
		else
		{
			Console.WriteLine("Please enter y or n");
		}
	}
}