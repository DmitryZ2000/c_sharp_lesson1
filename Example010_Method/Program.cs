int[] array = { 31, 23, 32, 34, 56, 73, 83, 93, 03, 32 };

int n = array.Length; // возвращает длину массива
int find = 32;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = index +1;
}
