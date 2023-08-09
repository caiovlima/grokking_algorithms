Console.WriteLine("03 Recursion!");

#region Coutdown
Console.WriteLine("======COUTDOWN=======");
Countdown(5);
static void Countdown(int i)
{
    Console.WriteLine(i);

    // base case
    if (i <= 0) return;

    // recursive case
    Countdown(i - 1);
}
#endregion

#region Greet 
Console.WriteLine("======GREET=======");
Greet("adit");

static void Greet(string name)
{
    Console.WriteLine($"hello, {name}!");
    Greet2(name);
    Console.WriteLine("getting ready to say bye...");
    Bye();
}

static void Greet2(string name)
{
    Console.WriteLine($"how are you, {name}?");
}

static void Bye()
{
    Console.WriteLine("ok bye!");
}

#endregion

#region Factorial
Console.WriteLine("======FACTORIAL=======");

Console.WriteLine(Fact(5));
static int Fact(int x)
{
    if (x <= 1) return 1;

    return x * Fact(x - 1);
}
#endregion
