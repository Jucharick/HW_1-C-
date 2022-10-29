// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
    SumByLines(matrix);
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

void MinElementInLine(int[] array)
{
    int min = array[0];
    int line = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            line = i;
        }
    }
    Console.Write(line + 1);
}

void SumByLines(int[,] matr)
{
    int[] arraySum = new int[matr.GetLength(0)]; // массив с количеством элементов, равным количеству строк
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0; // объявляю переменную sum и обнуляю при следующей итерации
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        arraySum[i] = sum;
    }
    Console.Write("Сумма элементов построчно: ");
    PrintArray(arraySum);
    Console.WriteLine();
    Console.Write("Строка с наименьшей суммой элементов: ");
    MinElementInLine(arraySum);
}