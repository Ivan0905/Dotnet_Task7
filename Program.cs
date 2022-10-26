// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// int rows = 3;
// int columns = 4;
// double[,] array = GetArray(rows, columns, -9.5, 9.5);
// PrintArr(array);

// double[,] GetArray(int n, int m, double min, double max)
// {
//     double[,] arr = new double[n, m];

//     for (int i = 0; i < n; i++)
//     {

//         for (int j = 0; j < m; j++)
//         {

//             arr[i, j] = new Random().NextDouble() * (max - min) + min;
//         }
//     }
//     return arr;
// }

// void PrintArr(double[,] arr)
// {

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(" {0:f2} ", arr[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// Console.WriteLine("Введите номер строки");
// int row = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите номер столбца");
// int column = int.Parse(Console.ReadLine()!);
// int [,] array = GetArray(4,4,0,5);
// PrintArr(array);
// text(array,row,column);

void text(int[,] arr, int r, int c)
{

    if (r >= 0 && r <= arr.GetLength(0) - 1 && c >= 0 && c <= arr.GetLength(1) - 1)
    {
        Console.WriteLine(arr[r, c]);
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}


int[,] GetArray(int n, int m, int min, int max)
{
    int[,] arr = new int[n, m];

    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {

            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArray(5, 4, 0, 5);
PrintArr(array);
Aver(array);

void Aver(int[,] arr)
{
    double[] arr1 = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double a = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            a += arr[j, i];
        }
        arr1[i] = a / arr.GetLength(0);
    }
    Console.WriteLine("Среднее арифметическое каждого столбца: " + String.Join("; ", arr1));

}