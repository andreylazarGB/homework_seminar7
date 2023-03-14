// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

int row = Prompt("Введите количество строк в массиве: ");
int column = Prompt("Введите количество столбцов в массиве: ");
int min = Prompt("Введите минимальное значение в массиве: ");
int max = Prompt("Введите максимальное значение в массиве: ");
double[,] array = FillArray(row, column, min, max);
PrintArray(array);

int Prompt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[,] FillArray(int rowArray, int columnArray, int min, int max)
{
    double[,] resultArray = new double[rowArray, columnArray];
    Random rnd = new Random();
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
        resultArray[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble();
        resultArray[i, j] = Math.Round(resultArray[i, j], 1);
        }
    }
    return resultArray;
}

void PrintArray(double[,] arr)
{
    Console.WriteLine("----------------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + $"  ");
        }
        Console.WriteLine();
    }
}