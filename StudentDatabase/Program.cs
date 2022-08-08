string[] names = {"Fred","Sally","Jack","Hank","Poppy" };
string[] hometown = { "Trenton", "Dearborn Heights", "Taylor", "Lincoln Park", "Plymouth" };
string[] food = { "Pizza", "Hamburger", "Chicken", "Noodles", "Shwarma" };
do
{
    bool okay = false;
    int studentIndex = 0;
    Console.WriteLine("Welcome to the student Database!");
    // Choose a student.
    while (!okay)
    {
        Console.WriteLine("Here is a list of students:");
        Console.WriteLine("1.Fred\n2.Sally\n3.Jack\n4.Hank\n5.Poppy");
        Console.Write("Please select a student corresponding to a number:");
        string entry = Console.ReadLine();
        bool validNumber = int.TryParse(entry, out studentIndex);

        if (validNumber)
        {
            if (studentIndex >= 1 && studentIndex <= names.Length) // using names.Length here as I do not think I hard code any other value for total number of students.
            {
                studentIndex--;
                okay = true;

            }
        }

    }

    funFact(studentIndex);

} while (KeepGoing());

void funFact(int x)
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

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to learn about another student? (y/n)");
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