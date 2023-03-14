// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

//  1 4 7 2                
//  5 9 2 3
//  8 4 2 4

//  1,1 -> 9
//  1,7 -> элемента с данными индексами в массиве нет

Console.Clear();

int k = Prompt("Введите номер строки: ");
int l = Prompt("Введите номер столбца: ");
int[,] array = FillArray(3, 4, 1, 9);
PrintArray(array);
Console.WriteLine();

Console.WriteLine((k < array.GetLength(0) && l < array.GetLength(1)) ? 
($"Значение элемента индекса [{k},{l}] в массиве равно: " + array[k, l]) : ("элемента с данными индексами в массиве нет"));

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
