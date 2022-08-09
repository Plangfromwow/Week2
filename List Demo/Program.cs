// Array for comparrison 
string[] myArray = { "Silly", "Array", "Things and what not" };

// print out one element
Console.WriteLine(myArray[0]);

// changing one of the members
myArray[1] = "ArraysAreDumb";

// looping through it
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

Console.WriteLine();


//  
// Now lets use a list.
//

List<string> myList = new List<string>();

myList.Add("String");
myList.Add("Arrays are dumb");
myList.Add("another thing");

// printing one element 
Console.WriteLine(myList[0]);

// changing the middle one 

myList[1] = "I changed this";

// also adding one 

myList.Add("New item");

// loop through the list

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

Console.WriteLine();
// delete from list 
Console.WriteLine("Removing one at index 2");
myList.RemoveAt(2);
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

Console.WriteLine();
Console.WriteLine("Lets remove one by name:");
myList.Remove("String");
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}
// insert into list 
Console.WriteLine();
Console.WriteLine("now we are inserting one:");
myList.Insert(1,"Banana");
foreach (var item in myList)
{
    Console.WriteLine(item);
}
// sorting the list 
Console.WriteLine("Sorting the list:");
myList.Sort();
foreach (var item in myList)
{
    Console.WriteLine(item);
}
// lists are not immutable, you can modify the list and change the list unlike strings. Stupid strings. We hate strings.
// checking if one exists 
Console.WriteLine("Type in a word and we'll see if it's in the list");
string entry = Console.ReadLine();
int index = myList.IndexOf(entry);

if (index >= 0)
{
    Console.WriteLine($"Found {entry} at {index}");
}
else
{
    Console.WriteLine($"{entry} is not in the list.");
}

// initiallzing a list
List<int> numbers = new List<int> { 5, 8, 23,15,63 };

foreach (var item in numbers) 
{ 
    Console.WriteLine($"The next number is {item}"); 
}

