string fizz = "Fizz";
string buzz = "Buzz";
string fizzBuzz = "FizzBuzz";

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - {fizzBuzz}");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - {fizz}");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - {buzz}");
    }
    else
    {
        Console.WriteLine(i);
    }
}

