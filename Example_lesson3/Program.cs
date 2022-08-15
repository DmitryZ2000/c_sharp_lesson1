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