var rand = new Random();
Stack<int> cards = new Stack<int>();
int player1Card, player2Card, player1Points, player2Points;
string player1Name, player2Name;
Console.WriteLine("This application plays WAR, if your number is smaller, you loose.");


do {
    shuffleDeck();
    namePlayers();
    playGame();
    Console.WriteLine();
    Console.WriteLine();


    if (player1Points > player2Points)
    {
        Console.WriteLine($"{player1Name} WINS THE GAME!!! WITH {player1Points} POINTS!!!");
    }
    else if (player1Points < player2Points)
    {
        Console.WriteLine($"{player2Name} WINS THE GAME!!! WITH {player2Points} POINTS!!!");
    }

} while (KeepGoing());


void playGame()
{
    player1Points = 0;
    player2Points = 0;
    while (cards.Count > 0)
    {
        Console.WriteLine("Drawing your cards...");
        Thread.Sleep(3000);
        
        player1Card = cards.Pop();
        player2Card = cards.Pop();

        Console.WriteLine($"{player1Name} drew {player1Card} and {player2Name} drew {player2Card}");

        if (player1Card > player2Card)
        {
            player1Points++;
            Console.WriteLine($"{player1Name} wins this round and now has {player1Points} points.");
            Console.WriteLine();
        }
        else if (player1Card < player2Card)
        {
            player2Points++;
            Console.WriteLine($"{player2Name} wins this round and now has {player2Points} points.");
            Console.WriteLine();
        }
        else if (player1Card == player2Card)
        {
            Console.WriteLine("Draw! No one gets a point!");
            Console.WriteLine();
        }
    }
}


void shuffleDeck()
{
	for (int i = 1; i < 11; i++)
	{
		int ranNum = rand.Next(1,11);
		cards.Push(ranNum);
	}
}


void namePlayers()
{
    Console.WriteLine();
    Console.Write("Please put in the name for Player 1:");
    player1Name = Console.ReadLine();
    Console.WriteLine($"Welcome {player1Name}!");
    Console.Write("Please put in the name for Player 2:");
    player2Name = Console.ReadLine();
    Console.WriteLine($"Welcome {player2Name}!");
}

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to play again? (y/n)");
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