// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого элемента в массиве нет


int[,] matrix = new int[3, 4];

FillMatrix(matrix, -2, 11);
PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine("Давайте проверим есть ли искомый элемент в матрице:");
Console.WriteLine("Введите номер строки");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер сттолбца");
int b = int.Parse(Console.ReadLine());

FindElement(matrix);

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

void FindElement(int[,] matr)
{
    if (a < 0 || b < 0) Console.WriteLine("Номер строки или столбца не может быть меньше 0");
    else if (a > matr.GetLength(0) - 1 || b > matr.GetLength(1) - 1)
    {
        Console.WriteLine($"Элемента с позицией [{a}, {b}] в матрице нет");
    }
    else Console.WriteLine($"Элемент с позицией [{a}, {b}] равен {matr[a, b]}");
}