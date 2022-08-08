string[] names = { "Fred", "Sally", "Jack", "Hank", "Poppy" };
string[] hometown = { "Trenton", "Dearborn Heights", "Taylor", "Lincoln Park", "Plymouth" };
string[] food = { "Pizza", "Hamburger", "Chicken", "Noodles", "Shwarma" };

int studentIndex = 2;


funFact(studentIndex);


 void funFact (int x)
{
  

    Console.WriteLine($"Your student chosen was {names[x]}");
    Console.WriteLine("Would you like to know about their Hometown or Favorite Food?");
    string choice = Console.ReadLine().ToLower();

    if (choice == "hometown")
    {
        Console.WriteLine($"{names[x]} was originally from {hometown[x]}");
    }
    else if (choice == "favorite food" || choice == "food")
    {
        Console.WriteLine($"{names[x]}'s favorite food is {food[x]}");
    }
    else
    {
        Console.WriteLine("That is not a valid response.");
        funFact(x);
    }

}