// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[1] соответствует символу w, s[3] - символу r

string Replace(string text, char OldValue, char NewValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue)
            result = result + $"{NewValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

// text = Replace(text, ' ', '|');  - можно так
string NewText = Replace(text, ' ', '|'); // - a можно так
Console.WriteLine(NewText);
Console.WriteLine();
Console.WriteLine(Replace(text, 'к', 'К'));
Console.WriteLine();
Console.WriteLine(Replace(text, 'с', 'С'));