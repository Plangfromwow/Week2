// this all demonstrates 2 data structures, stacks and queues 
// different stack from the concept of stacks and heaps, this has nothing to do with those


Stack<string> cards = new Stack<string>();

cards.Push("3D");
cards.Push("AS");
cards.Push("QH");
cards.Push("10D");

string next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

// if we pop again we will get an error saying the stack is empty. 

// a que is like a line of people at the store. 


Console.WriteLine();
Console.WriteLine("Lets do some que practice");

Queue<int> nums = new Queue<int>();
nums.Enqueue(5);
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue());

foreach (int i in nums)
{
    Console.WriteLine(i);
}

Console.WriteLine();

Console.WriteLine("Advanced stack stuff... oh no ");

cards.Clear(); // empties out the stack 

cards.Push("5D");
cards.Push("JH");
cards.Push("3S"); // 5 OF DIAMOND ON THE BOTTOM, JH NEXT, AND THEN 3S AT THE TOP

Console.WriteLine(cards.Pop()); //expecting 3 of spades 

string top = cards.Peek();
int cardsLeft = cards.Count;
Console.WriteLine($"The top is {top} but we didn't remove it. There are {cardsLeft} left.");

Console.WriteLine(cards.Pop());
cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop());
cards.Push("5D");

Console.WriteLine("Drawing the rest of the cards:");
while (cards.Count > 0)
{
    next = cards.Pop();
    Console.WriteLine($"We just drew {next}");
}

Console.WriteLine($"The count of the deck is now {cards.Count}");

// one more stack 
cards.Clear();
Console.WriteLine("We are putting 5 cards on and drawing them all off.");
cards.Push("AD");
cards.Push("2D");
cards.Push("3D");
cards.Push("4D");
cards.Push("5D");

while (cards.Count > 0)
{
    Console.WriteLine(cards.Pop());
}

// one more que demonstration 
Console.WriteLine();
Console.WriteLine("we are going to put 5 numbers in a que then go through the whole list.");
nums.Clear();
nums.Enqueue(1);
nums.Enqueue(2);
nums.Enqueue(3);
nums.Enqueue(4);
nums.Enqueue(5);

while (nums.Count > 0)
{
    Console.WriteLine(nums.Dequeue());
}