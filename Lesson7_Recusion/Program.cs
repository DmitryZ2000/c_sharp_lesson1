string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)  //Решение с циклом for
    {
        result += $"{i} ";
    }
    return result;
}

// string NumbersRecusion(int a, int b)  //Как в лекции.
// {
// if (a <= b) return $"{a} " + NumbersRecusion(a + 1, b);
// else return String.Empty;
// }

string NumbersRecusion(int a, int b) //Оптимизировано по заданию Камянецкого
{
if (a < b) return $"{a} " + NumbersRecusion(a + 1, b);
else return $"{b} ";
}

// Console.WriteLine(NumbersFor(10, 20));
Console.WriteLine(NumbersRecusion(1, 10));

