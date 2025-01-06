
static long ffactorial(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

static long rfactorial (int n)
{
    return n < 1 ? 1 : n * rfactorial(n - 1);
}

long result1 = ffactorial(5);
long result2 = rfactorial(5); 
Console.WriteLine(result1);
Console.WriteLine(result2);