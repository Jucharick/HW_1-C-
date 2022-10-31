// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] matrix = new int[4, 4];

SortBySpiral(matrix);
PrintMatrix(matrix);


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

void SortBySpiral(int[,] matr)
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
    while ( i < matr.GetLength(0) - 1)
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
   
}