// creating a dictionary that is mapping numbers to the name of the number

Dictionary<int, string> numbers = new  Dictionary<int, string>();

numbers.Add(1, "One");
numbers.Add(10, "Ten");
numbers.Add(20, "Twenty");
numbers.Add(100, "One Hundred");


Console.WriteLine("Here are the keys.");
foreach (var num in numbers.Keys)
{
    Console.WriteLine(num);
}
Console.WriteLine();
Console.WriteLine("Here are the values:");
foreach (var value in numbers.Values)
{
    Console.WriteLine(value);
}