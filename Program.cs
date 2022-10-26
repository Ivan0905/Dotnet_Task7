// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int rows = 3;
int columns = 4;
double[,] array = GetArray(rows, columns, -9.5, 9.5);
PrintArr(array);

double[,] GetArray(int n, int m, double min, double max)
{
    double[,] arr = new double[n, m];

    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {

            arr[i, j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return arr;
}

void PrintArr(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(" {0:f2} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}