using System.ComponentModel.DataAnnotations;

string sentence = "";
string word = "";

do
{
    bool validated = false;
    while (!validated)
    {
        Console.WriteLine("Please enter a sentence: ");
        sentence = Console.ReadLine();

        if (sentence.Contains(" "))
        {
            validated = true;
        }
        else
        {
            Console.WriteLine("make sure your sentence contains at least one space. You goober.");
        }
    }

    validated = false;
    while (!validated)
    {
        Console.WriteLine("Please enter a word: ");
        word = Console.ReadLine();

        if (word.Contains(" "))
        {
            Console.WriteLine("Make sure to enter a word with no spaces. you goober.");
        }
        else
        {
            validated = true;
        }

    }
    bool contains = sentence.ToLower().Contains(word.ToLower());

    if (contains)
    {
        Console.WriteLine($"Yup! {word} exists in the sentence!");
    }
    else
    {
        Console.WriteLine("Nope!");
    }
} while (KeepGoing());

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine().ToLower();
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