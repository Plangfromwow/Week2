string reverseThis;

Console.WriteLine("Welcome to the string reverser.");
do
{

Console.WriteLine("Please input a string to see it backwards: ");
reverseThis = Console.ReadLine();


    //food 
for (int i = 0; i < reverseThis.Length; i++)
{
    Console.Write(reverseThis[reverseThis.Length - i - 1]);
}
    Console.WriteLine();


} while (KeepGoing());


static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
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