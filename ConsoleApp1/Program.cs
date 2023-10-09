using SabirovZ2;

static int CheckInt()
{
    int a = 0;
    while (true)
    {
        Console.Write("Write int: ");
        string s = Console.ReadLine();
        if (int.TryParse(s, out a))
            break;
    }
    return a;
}

static void Main()
{
    try
    {
        Console.WriteLine("First:");
        int n = CheckInt();
        if (Second.O1(n))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");


        Console.WriteLine("Second:");
        Console.WriteLine("Write number 1:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Write number 2:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        if (n1 > n2)
            Console.WriteLine($"{n1} > {n2}");
        else if (n1 < n2)
            Console.WriteLine($"{n1} < {n2}");
        else
            Console.WriteLine($"{n1} = {n2}");


        Console.WriteLine("Third:");
        int summ = 0;
        int a;
        do
        {
            a = CheckInt();
            summ += a;
        } while (a != 0);
        Console.WriteLine($"Summ = {summ}");

        Console.WriteLine("Fourth:");
        Second.O4();


        Console.WriteLine("Fifth:");
        Second.O5();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Main();






