
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
