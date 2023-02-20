// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, colums, 1, 10);
PrintArray(array);

Console.WriteLine();
PrintArray(FrequencyDictionary(array));

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

int[,] FrequencyDictionary(int[,] inArray)
{
    int rows = inArray.GetLength(0);
    int cols = inArray.GetLength(1);
    string[] cheating = new string[rows * cols];
    int[,] res = new int[2, rows * cols];
    int counter1 = 0;
    int counter2;
    string tmp;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            cheating[counter1] = inArray[i, j].ToString();
            counter1++;
        }
    }
    counter1 = 0;
    for (int i = 0; i < cheating.Length; i++)
    {
        if (cheating[i] != "x")
        {
            res[0, counter1] = int.Parse(cheating[i]);
            counter2 = 0;
            tmp = cheating[i];
            for (int j = i; j < cheating.Length; j++)
            {
                if (cheating[j] == tmp)
                {
                    counter2++;
                    cheating[j] = "x";
                }
            }
            res[1, counter1] = Convert.Toint(counter2);
            counter1++;
        }
    }
    return res;
}





// 1,2,3,8,1,2,6,
