// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int row = Prompt("Введите количество строк в массиве: ");
int column = Prompt("Введите количество столбцов в массиве: ");
int min = Prompt("Введите минимальное значение в массиве: ");
int max = Prompt("Введите максимальное значение в массиве: ");
int[,] array = FillArray(row, column, min, max);
PrintArray(array);
//PrintArray(GetAverage(array));
Console.WriteLine();
GetSum(GetAverage(array));



int Prompt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int rowArray, int columnArray, int min, int max)
{
    int[,] resultArray = new int[rowArray, columnArray];
    Random rnd = new Random();
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
            resultArray[i, j] = rnd.Next(min, max + 1);
        }
    }
    return resultArray;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("----------------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetAverage(int[,] inputArray)
{
    int[,] result = new int[inputArray.GetLength(1), inputArray.GetLength(0)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            result[j, i] = inputArray[i, j];

        }
    }
    return result;
}

void GetSum(int[,] inputArray)
{
    double res = 0;  
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
            res = sum / inputArray.GetLength(1);
            res = Math.Round(res, 1);
        }
        Console.WriteLine($"Cреднее арифметическое элементов в {i+1} столбце равно " + res);
    }
}