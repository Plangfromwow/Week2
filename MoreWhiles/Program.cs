
int x = 0;

//while (10 > 9)
//{
//    // this will run forever 
//    Console.WriteLine($"Inside the while loop {x}");
//    x++;
//}

//while (9 > 10)
//{
//    // this will never run
//    Console.WriteLine($"x is {x}");
//    x++;
//}


bool done = false;
while (!done)
{
    Console.WriteLine($"x is {x}");
    x++;

    if (x == 1000)
    {
        done = true;
    }
}

Console.WriteLine($"ALL DONE FOR THE DAY x is {x}");