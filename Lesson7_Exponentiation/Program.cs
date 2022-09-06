
int PowerRec1(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec1(a, n - 1) * a;
}

int PowerRec2(int a, int n)
{ 
    return n == 0 ? 1 : PowerRec2(a, n - 1) * a;  
    //Аналогичный способ записи в С# с использованием тернарного оператора ? 
}

int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerRec1(2, 10)); // 1024
Console.WriteLine(PowerRec2(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10));
