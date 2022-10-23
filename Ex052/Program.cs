// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите высоту матрицы (количество строк)");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];

FillMatrix(matrix, 0, 11);
PrintMatrix(matrix);
ArithmeticMean(matrix);

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

void ArithmeticMean(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++) // идем по столбцам
    {
        double mean = 0;
        for (int j = 0; j < matr.GetLength(0); j++) // идем по строкам
        {
            mean = mean + matr[j, i];
            if (j == matr.GetLength(0) - 1) mean = Math.Round(mean / matr.GetLength(0), 1);
        }
        Console.Write($"{mean}  ");
    }
}