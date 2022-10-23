// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите высоту матрицы (количество строк)");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m, n];

FillMatrix(matrix, -10, 11);
PrintMatrix(matrix);

void FillMatrix(double[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to) + new Random().NextDouble(); // Random.NextDouble() Возвращает случайное число с плавающей запятой, которое больше или равно 0,0 и меньше 1,0.
        }
    }
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(matr[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}