Console.Write("Введите имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "dmitry")
{
    Console.WriteLine("Hi!!! My Friend Dmitry");
}
else
{
    Console.Write("Привет! ");
    Console.WriteLine(username );
}