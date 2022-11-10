// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] matrix = new int[4, 4];
int[,] matrixSpiral = SortBySpiral(matrix);
PrintMatrix(matrixSpiral);


void PrintMatrix(int [,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) // идем по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // идем по колонкам
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 2} "); // 2 - для выравнивания вывода матрицы выводим по 2 символа
            else Console.Write($" {matrix[i, j], 2} ");
        }
        Console.WriteLine();
    }
}

int[,] SortBySpiral(int[,] matr)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    matr [i, j] = 1;

    while ( j < matr.GetLength(1) - 1)
    {
        j ++;
        temp ++;
        matr [i, j] = temp;
    }
    while ( i < matr.GetLength(0) - 1 )
    {
        i ++;
        temp ++;
        matr [i, j] = temp;
    }
    while ( j > 0)
    {
        j --;
        temp ++;
        matr [i, j] = temp;
    }
    while ( i > 1)
    {
        i --;
        temp ++;
        matr [i, j] = temp;
    }
    while ( j < matr.GetLength(1) - 2)
    {
        j ++;
        temp ++;
        matr [i, j] = temp;
    }
    while ( i < matr.GetLength(0) - 2)
    {
        i ++;
        temp ++;
        matr [i, j] = temp;
    }
    while ( j > 1)
    {
        j --;
        temp ++;
        matr [i, j] = temp;
    }
    return matr;   
}