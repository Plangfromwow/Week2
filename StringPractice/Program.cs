string sentence = "Hello there everybody from planet earth.";

string[] words = sentence.Split(); // noun dot verb, the noun is a variable, in this case sentence 

foreach (var word in words)
{
    Console.WriteLine(word);
}
Console.WriteLine();
Console.WriteLine("Another split");
sentence = "Hello,there,everyboyd,from,planet,earth,";
words = sentence.Split(',');
foreach (var word in words)
{
    Console.WriteLine(word);
}

char[] delims = { ',', ' ' };//split by comma or space

words = sentence.Split(delims);
foreach (var word in words)
{
    Console.WriteLine(word);
}

// lets join these words back together 

sentence = String.Join('>',words); // noun dot verb, the noun is a type, in this case string 
                                    // methods that are attached to the type itself are called static methods 
                                    // methods that are tied to an instance of the type (such as sentence) are called instance methods.
Console.WriteLine(sentence);

// lets find the position of a letter in a string 
// indexof uses common approach, it returns a 0-based index, or -1 if it doesn't find it. 

sentence = "We will find a letter position.";
Console.WriteLine(sentence.IndexOf('x'));
Console.WriteLine(sentence.LastIndexOf('i'));

// using Substring to find a piece of a string. 
Console.WriteLine();
Console.WriteLine("Substring Practice: ");
sentence = "Hello World";
Console.Write(sentence.Substring(6,1)); // Expect World
Console.WriteLine(sentence.Substring(4,3));