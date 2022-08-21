string[,] mytable = new string[2, 5];
//2 строки (rows) и 5 столбцоы (column)
//mytable[0,0], mytable[0,1] mytable[0,2], mytable[0,3], mytable[0,4]
//mytable[1,0], mytable[1,1] mytable[1,2], mytable[1,3], mytable[1,4]
mytable[1, 2] = "слово";
for (int row = 0; row < 2; row++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.Write($"-{mytable[row, column]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - колличество строк (колличество элементов в 0-й позиции)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - колличество столбцов (колличество элементов в 1-й позиции)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4]
// int[,] matrix = new int[,] //Можно так. Не обязательно указывать кол-во строчек и столбцов если есть фиксированные данные
{
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12} //Инициализация массива вручную
};


PrintMatrix(matrix);
Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);