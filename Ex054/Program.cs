// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите высоту матрицы (количество строк)");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int n = int.Parse(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Количество строк и/или количество столбцов матрицы не может быть меньше или равно 0");
}
else
{
    int[,] matrix = new int[m, n];

    FillMatrix(matrix, 0, 11);
    PrintMatrix(matrix);
    Console.WriteLine();
    SortByLines(matrix);
    PrintMatrix(matrix);
}


void FillMatrix(int[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortByLines(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k <= matr.GetLength(1) - 2; k++) 
            {
                if (matr[i, k] < matr[i, k+1]) 
                {
                    int temp = matr[i, k];
                    matr[i, k] = matr[i, k+1];
                    matr[i, k+1] = temp;
                }
            }
        }
    }
}
