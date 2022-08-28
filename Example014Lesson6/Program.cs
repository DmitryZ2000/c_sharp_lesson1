using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")","");
Console.WriteLine(text);
var data = text.Split(" ")
                .Select(item => item.Split(','))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i]);
    for (int k = 0; k < data[i].Length; k++)
    {
        Console.WriteLine(data[i][k]);
    }
    Console.WriteLine();
}