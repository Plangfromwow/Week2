List<string> letters = new List<string>();
letters.Add("Abc");
letters.Add("def");
letters.Add("ghi");
letters.Add("jkl");
letters.Add("mno");

foreach (string item in letters)
{
    Console.WriteLine(item);
}

// Dictionary takes Key and Value
Dictionary<string, string>  foods = new Dictionary<string, string>();

foods["Paul"] = "Meatballs";
foods["Sarah"] = "Pizza";
foods["Quincy"] = "Tacos";
foods["Ruby"] = "Ice Cream";
foods["Terry"] = "Tacos";

// print out food 
Console.WriteLine(foods["Ruby"]);

// Paul changed his mind and now he wants hamburgers 
foods["Paul"] = "Hamburgers";
Console.WriteLine($"Paul now likes {foods["Paul"]}");

Console.WriteLine();
foreach (var pair in foods)
{
    Console.WriteLine("The name and food are:");
    Console.WriteLine(pair.Key);
    Console.WriteLine(pair.Value);
}