//Собираем от большего к меньшему a>=b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)  //Решение с циклом for
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecusion(int a, int b)
{
if (a > b) return  $"{a} " + NumbersRecusion(a - 1, b);
else return $"{b} ";
}

Console.WriteLine(NumbersFor(20, 10));
Console.WriteLine(NumbersRecusion(10, 1));