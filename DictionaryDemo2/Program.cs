//// more dictionary fun 

//// list of salaries, key = string, value = Decimal
//Dictionary<string,decimal> salary = new Dictionary<string,decimal>();

//salary["Paul"] =65000m;
//salary["Sarah"] = 100000m;
//salary["Quincy"] = 80000m;
//salary["Ruby"] = 750000m;
//salary["Terry"] = 1000000m;

////foreach (var pair in salary)
////{
////    Console.WriteLine(pair.Key);
////}

//foreach (var key in salary.Values)
//{
//    Console.WriteLine(key);
//}

//Console.Write("Please enter a name: ");
//string name = Console.ReadLine();

//if (salary.ContainsKey(name))
//{
//    Console.WriteLine(salary[name]);
//}
//else
//{
//    Console.WriteLine("That person doesn't work here.");
//}

//Console.Write("Please add a new employee. Enter their name: ");
//var name2 = Console.ReadLine();
//Console.Write("Please enter a salary: ");
//decimal entry = Convert.ToDecimal(Console.ReadLine());
//salary[name2] = entry;
//Console.WriteLine("here is everybody:");

//foreach (var item in salary)
//{
//    Console.WriteLine($"{item.Key} makes {item.Value}");

//}


// Dictionary of favorite numbers 
Dictionary<string, List<int>> Favorites = new Dictionary<string, List<int>>();

Favorites["Paul"] = new List<int>() { 10,100,1000,100000};
Favorites["Sarah"] = new List<int>() {45,1,2,3,5 };
Favorites["Quincy"] = new List<int>() { 5,6,8,7,2};
Favorites["Ruby"] = new List<int>() { 6,1,1,1,1,4};
Favorites["Jacob"] = new List<int>() { 7,7,7,7,7};
Favorites["Terry"] = new List<int>() {15,1546,84,62,354 };

foreach (var pair in Favorites)
{
    Console.WriteLine(pair.Key);
    foreach (var list in pair.Value)
    {
        Console.WriteLine(list);
    }
}