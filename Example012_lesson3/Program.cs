void Method1()
{
    Console.WriteLine("Я автор....");
}
// Method1(); //Не забываем писать скобки после вызова метода.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Мой текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "My Text", count: 4);
Console.WriteLine();
Method21(count: 4, msg: "Новое сообщение"); //Использование именнованных аргументов, позволяет передавать значения не попорядку

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

string Method4(int count, string txt)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + txt;
        i++;
    }
    return result;
}
string res = Method4(10, "abc ");
Console.WriteLine(res);

string Method41(int count, string txt)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
        {
            result = result + txt;
        }
    return result;
}

string res1 = Method4(10, "BMW ");
Console.WriteLine(res1);