Dictionary<long,string> phoneBook = new Dictionary<long,string>();
phoneBook.Add(1, "George Lucas");
phoneBook.Add(2, "George Martin");
phoneBook.Add(3, "George Washington");
phoneBook.Add(4, "George Harrison");
phoneBook.Add(5, "George Michael");

Dictionary<string, string> georgeFoodcus = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
georgeFoodcus.Add("George Lucas", "Ruining childhood treasures.");
georgeFoodcus.Add("George Martin","Thrones");
georgeFoodcus.Add("George Washington", "Pies");
georgeFoodcus.Add("George Harrison", "Baggles");
georgeFoodcus.Add("George Michael", "Pizza");
bool leave = false;

Console.WriteLine("Welcome to the George Database!");
do {
    
    bool validated = false;
    while(!validated)
    {
        Console.WriteLine("Make a selection for your George or type 10 to see all of the options. 20 to exit.");
        int selection = int.Parse(Console.ReadLine());

        if (selection == 10)
        {
            validated = true;
            georgeLoopus();
        }
        else if (selection <= phoneBook.Count && selection >= 1)
        {
            validated = true;
            dataOnGeorge(selection);
        }
        else if (selection == 20)
        {
            validated = true;
            leave = true;
        }
        else
        {
            Console.WriteLine("Please put in a proper response.");
        }
    }
}while(!leave);





void georgeLoopus()
{
    for (int i = 1; i <= phoneBook.Count; i++)
    {
        Console.WriteLine($"{i}. {phoneBook[i]}"); 
    }
}

void dataOnGeorge(int x)
{
    Console.WriteLine($"You've chosen {phoneBook[x]} ");
    Console.WriteLine($"His favorite food is {georgeFoodcus[phoneBook[x]]}");
}