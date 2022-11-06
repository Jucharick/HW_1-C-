// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int [,] matrix  = CreateMatrixRndInt(rows, columns, 0, 6);
double[] mean = ArithmeticMean(matrix);

PrintMatrix(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(mean);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) // идем по строкам
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) // идем по колонкам
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 4} | "); // 4 - для выравнивания вывода матрицы выводим по 4 символа
            else Console.Write($" {matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

double[] ArithmeticMean(int[,] matr)
{
    double[] arrayMean = new double [matr.GetLength(1)]; // массив, содержащий значения mean и имеющий количество элементов, равное количеству столбцов в матрице
    for (int i = 0; i < matr.GetLength(1); i++) // идем по столбцам
    {
        double mean = 0;
        for (int j = 0; j < matr.GetLength(0); j++) // идем по строкам
        {
            mean = mean + matr[j, i];
            if (j == matr.GetLength(0) - 1) mean = Math.Round(mean / matr.GetLength(0), 1);
        }
        arrayMean[i] = mean;
    }
    return arrayMean;
}