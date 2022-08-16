int[] arr = { 3, 2, 3, 6, 7, 8, 8, 1, 1, 4, 5 };
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min_position = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min_position])
            {
                min_position = j;
            }
        }
        // int temp = array[min_position];
        // array[min_position] = array[i];
        // array[i] = temp;
        int temp = array[i];
        array[i] = array[min_position];
        array[min_position] = temp;
    }
}

void SortArrayMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int max_position = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[max_position])
            {
                max_position = j;
            }
        }
        // int temp = array[max_position];
        // array[max_position] = array[i];
        // array[i] = temp;
        int temp = array[i];
        array[i] = array[max_position];
        array[max_position] = temp;
    }
}

PrintArray(arr);
SortArray(arr);
PrintArray(arr);
SortArrayMax(arr);
PrintArray(arr);