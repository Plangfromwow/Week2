int[] grades = { 100, 80, 100, 60, 85 };

string[] names = { "Fred", "Jamal", "Yasmine", "Ziggy" };

Console.WriteLine();

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{names[i]}'s grade right now is {grades[i]}%");
}

Console.WriteLine();

for (int i = 0; i <= 3; i++) // clearly shows the start and end 
{
    Console.WriteLine(names[i]);
}

// if we change one, suppose we mispelled the third name. 

names[2] = "Jasmine";
Console.WriteLine();
// actually changing the entire string, because strings are immutable, we can't change an individual letter. We have to make a whole new string.
Console.WriteLine($"We corrected the spelling of {names[2]}");
