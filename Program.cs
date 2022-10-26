//Show Character
char ShowCharacter(string word, int index)
{
    return word[index - 1];
}

Console.WriteLine(ShowCharacter("NewYork", 2));

//Retail Price
double CalculateRetail(double retailprice, double markup)
{
    return retailprice + (retailprice * (markup / 100));
}

Console.WriteLine(CalculateRetail(5.0, 100));
Console.WriteLine(CalculateRetail(5.0, 50));

//Temperature Table
double Celsius(double F)
{
    return (Math.Round(5.0 / 9.0 * (F - 32), 2));
}

for (int i = 80; i <= 100; i++)
{
    Console.WriteLine(Celsius(i));
}

//Prime Numbers
static bool IsPrime(int number)
{
    if (number == 2)
        return true;
    if (number % 2 == 0)
        return false;
    return true;
}

Console.WriteLine(IsPrime(5));