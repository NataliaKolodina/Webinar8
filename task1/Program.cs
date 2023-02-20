// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, colums, 1, 10);
PrintArray(array);

Console.WriteLine();
PrintArray(ChangeRows(array));

Console.WriteLine();
ChangeRows2(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRows(int[,] array)
{
    int[,] ChangeRows = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != 0)
            {
                ChangeRows[i, j] = array[i, j];
            }
            else
            {
                ChangeRows[i, j] = array[array.GetLength(0) - 1, j];
                ChangeRows[array.GetLength(0) - 1, j] = array[i, j];
            }
        }
    }
    return ChangeRows;
}

void ChangeRows2(int[,] array)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}
