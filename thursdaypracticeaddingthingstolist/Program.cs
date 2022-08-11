List<string> userList = new List<string>();
bool leave = false;
Console.WriteLine("Welcome to your personal List!");
do {
    Console.WriteLine("What would you like to do? Add/View/Delete/Leave");
    string entry = Console.ReadLine().ToLower();

    if (entry == "add" || entry == "a")
    {
        addToList();
    }
    else if (entry == "view" || entry == "v")
    {
        printList();
    }
    else if (entry == "delete" || entry == "d")
    {
        deleteItem();
    }
    else if(entry == "leave" || entry == "l") {
        Console.WriteLine("Thank you for stopping by!");
        leave = true;
    }
    else
    {
        Console.WriteLine("That's not an option.");
    }

}while (!leave);


void deleteItem()
{
    Console.WriteLine("Here is a list of your current items: ");
    foreach (var item in userList)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Which item would you like to delete?");
    string deleteThis = Console.ReadLine().ToLower();
    if (userList.Contains(deleteThis))
    {
        userList.Remove(deleteThis);
        Console.WriteLine($"{deleteThis} has been removed!");
    }
    else
    {
        Console.WriteLine("Sorry, that item isn't in your list. Try again: ");
    }

}




void printList()
{
    Console.WriteLine("Here is a list of your current items: ");
    foreach (var item in userList)
    {
        Console.WriteLine(item);
    }
}



void addToList()
{
    Console.WriteLine("What would you like to add?");
    string newItem = Console.ReadLine();
    
    userList.Add(newItem);

}
