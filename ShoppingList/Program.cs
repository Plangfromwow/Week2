// dictionary will contain string,decimal <item,price> for the menu 
// list for the cart <strings> 
// then you want to print out everything in the cart, 
// first iteration the item will be apple, menu[item] = price 

Dictionary<string,decimal> menu = new Dictionary<string,decimal>(StringComparer.InvariantCultureIgnoreCase);
menu.Add("Apple", 1.00m);
menu.Add("Banana",2.00m );
menu.Add("Potato", 5.00m);
menu.Add("Tomato", 18.00m);
menu.Add("Milk", 5.50m);
menu.Add("Bread", 16.00m);
menu.Add("Candy Bar", 25.00m);
menu.Add("Happiness", 15.00m);

List<string> cart = new List<string>();

Console.WriteLine("Welcome to the Grocery Store!");

var cartTotal = 0.00m;
bool userLeaves = true;
do {
    Console.WriteLine("What would you like to do? (List/Cart/Total/add items/exit)");
    string response = Console.ReadLine();


    if (response == "list" || response == "l")
    {
        Console.Clear();
        listMenu();
    }
    else if (response == "cart" || response == "c")
    {
        listCart();
    }
    else if (response == "add" || response == "add items" || response == "a")
    {
        Console.Write("Please type the item you would like to add: ");
        string addItemEntry = Console.ReadLine();
        addItemToCart(addItemEntry);

    }
    else if (response == "total" || response == "t")
    {
        cartTotal = 0.00m;
        totalCartCost();
        Console.WriteLine($"${cartTotal}");
    }
    else if (response == "exit" || response == "leave" || response == "e")
    {
        userLeaves = false;
    }
    else
    {
        Console.WriteLine("That is not an option.");
    }

} while (userLeaves);


Console.WriteLine("Thank you for stopping by!");



void totalCartCost()
{
    foreach (var item in cart)
    {
        
        cartTotal = menu[item] + cartTotal;
        
    }
}



void addItemToCart(string itemEntry)
{

    if (menu.ContainsKey(itemEntry))
    {
        cart.Add(itemEntry);
    }
    else
    {
        Console.WriteLine("That is not on the menu.");
    }
}



void listCart()
{
    Console.WriteLine("List of your currently selected items:");
    foreach (var item in cart)
    {
        Console.WriteLine(item);
    }
}



 void listMenu()
{
    Console.WriteLine("Here is what we sell:");
    foreach (var item in menu)
    {

        Console.Write($"{item.Key} ");
        Console.Write($"${item.Value}");
        Console.WriteLine();
    }
}
