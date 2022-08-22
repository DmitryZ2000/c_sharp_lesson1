double FibonacciMy(int n)
{
    double a = 1;
    double b = 1;
    double c = 0;
    if (n == 0 ) return 1;
    else if (n == 1 ) return 1;
    else
    {
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
    }
    return c;
}
for (int i = 0; i <= 1000; i++)
{
   Console.WriteLine($"Порядковый номер-{i} = {FibonacciMy(i)}"); 
}