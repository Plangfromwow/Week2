// create a method to reverse a string 
// create a readline for the string that will be reversed 
// loop it all up 
// all done 



using System.Text.RegularExpressions;

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
            validated = true;
            string thisIsaSentence = reverseThis;
            reverseSetnence(thisIsaSentence);
            //validated = true;
            
        }
        else if (reverseThis.Any(char.IsDigit))
        {
            Console.WriteLine("Please only put in a word. No Numbers.");
        }
        else
        {
            validated = true;
            reversed = reverseWord(reverseThis);
            Console.WriteLine($"Your word reversed is, {reversed}. Isn't that magical?");
        }

    }
    

} while (KeepGoing());


static bool KeepGoing()
{
    while (true)
    {
        Console.WriteLine();
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

static string reverseWord(string userInput)
{
    string reversed = "";
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

    return reversed;
}


void reverseSetnence(string userInput)
{
    
    Queue<string> newWord = new Queue<string>();
    string newSentence = "";
    string[] words = userInput.Split(" ");
  

    for (int i = 0; i < words.Length; i++)
    {
        
         string reversedWords = reverseWord(words[i]);
         newWord.Enqueue(reversedWords);  
    }

    foreach (var word in newWord)
    {
        Console.Write($" {word}");
    }

}