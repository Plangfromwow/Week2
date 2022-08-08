string[] names = { "Abdul Amin", "Barbara Baker", "Cherine Cooper", "Douglas Dickerson", "Emily Emerson" };
int[] grades = { 95, 98, 85, 80, 70 };

Console.WriteLine($"There are {names.Length} students.");

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{names[i]} has grade {grades[i]}");
}

// ask the user which one to print out. 
//Console.WriteLine();
//Console.WriteLine("Please enter a number:");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//Console.WriteLine($"{names[num]} has grades {grades[num]}");

//ask user which one to print out starting at 1 
// so if they type in 1 we want to give them back index 0. We have to minus 1 OMEGALUL
//version 1
//Console.WriteLine();
//Console.WriteLine("Please enter a number from 1-5:");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//num--;
//Console.WriteLine($"{names[num]} has grades {grades[num]}");


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
            okay = true;
        }
    }
}

// this code will run after they run a valid number.
if (okay)
{
    num--;
    Console.WriteLine($"{names[num]} has grades {grades[num]}");
}

