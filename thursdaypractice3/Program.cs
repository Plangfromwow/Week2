List<int> numbers = new List<int> { 1,2,3,4,5,6,12,15,16,18,32,1,2,6,56};

foreach (var num in numbers)
{
    Console.WriteLine(num);
}


Console.WriteLine("Sorting the numbers.");
numbers.Sort();

foreach (var num in numbers)
{
    Console.WriteLine(num);
}

int median = getMedian();
Console.WriteLine("The median of these numbers is:");
Console.WriteLine(median);

int getMedian()
{
    int[] temp = numbers.ToArray();
    Array.Sort(temp);
    int count = temp.Length;
    if (count == 0)
    {
        throw new InvalidOperationException("Empty collection");
    }
    else if (count % 2 == 0)
    {
        int a = temp[(count / 2) - 1];
        int b = temp[count / 2];
        return (int)((a + b) /2m);
    }
    else
    {
        return temp[count / 2];
    }
    
}
