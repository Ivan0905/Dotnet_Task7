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

// int[,] array = GetArray(5, 4, 0, 5);
// PrintArr(array);
// Aver(array);

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

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int xRow = 2;
int yRow = 2;
int zColumn = 2;
int[] larray = new int[xRow * yRow * zColumn];  //Задаем одномерный массив
int[,,] myArray = GetArrayTd(xRow, yRow, zColumn, LineArray(xRow, yRow, zColumn));
PrintArrTd(myArray);

int[,,] GetArrayTd(int n, int m, int k, int[] arr1)
{
    int[,,] arr = new int[n, m, k];
    int count = 0;
    for (int x = 0; x < n; x++)
    {

        for (int y = 0; y < m; y++)
        {
            for (int z = 0; z < k; z++)
            {

                arr[x, y, z] = arr1[count];
                count++;
            }
        }

    }
    return arr;
}

int[] LineArray(int StrX, int StrY, int StrZ) // Метод линейного создания массива  с неповторяющимися рандомными числами
{
    Random rnd = new Random();
    int[] a = new int[StrX * StrY * StrZ];
    a[0] = rnd.Next(10, 100);
    for (int i = 1; i < a.Length;)
    {
        int num = rnd.Next(10, 100); // генерируем элемент
        int j;
        // поиск совпадения среди заполненных элементов
        for (j = 0; j < i; j++)
        {
            if (num == a[j])
                break; // совпадение найдено, элемент не подходит
        }
        if (j == i)
        { // совпадение не найдено
            a[i] = num; // сохраняем элемент
            i++; // переходим к следующему элементу
        }
    }
    return a;
}

void PrintArrTd(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }

    }
}