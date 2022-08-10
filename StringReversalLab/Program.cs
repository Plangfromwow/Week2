// create a method to reverse a string 
// create a readline for the string that will be reversed 
// loop it all up 
// all done 



Console.WriteLine("Welcome to the word Reverser!");
string reversed = "";
string reverseThis = "";

do
{
    reversed = "";
    bool validated = false;
    while (!validated)
    {
        
        Console.WriteLine();
        Console.Write("Please enter a word: ");
        reverseThis = Console.ReadLine();

        if (reverseThis.Contains(" "))
        {
            Console.WriteLine("Please only put in a word without spaces.");
        }
        else
        {
            validated = true;
        }

    }
    reverseWord(reverseThis);

    Console.WriteLine($"Your word reversed is, {reversed}. Isn't that magical?");

} while (KeepGoing());






static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to try again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            Console.Clear();
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





void reverseWord(string userInput)
{
    Stack<char> chars = new Stack<char>();
    char[] charsArray;
    charsArray = userInput.ToCharArray();

    for (int i = 0; i < charsArray.Length; i++)
    {
        chars.Push(charsArray[i]);
    }


    while (chars.Count > 0)
    {
        reversed = reversed + chars.Pop();
    }
}