// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] matrix = new int[3, 2, 2];

FillMatrixNonRepeatElements(matrix, 10, 100);
PrintMatrix(matrix);
GetElement(matrix);

void FillMatrixNonRepeatElements(int[,,] matr, int from, int to)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(2); i++) // pages
    {
        for (int j = 0; j < matr.GetLength(0); j++) // rows
        {
            for (int k = 0; k < matr.GetLength(1); k++) // columns
            {
                matr[j, k, i] = from + count;
                count +=3;
                if (matr[j, k, i] > to) matr[j, k, i] = matr[j, k, i] / 2;
            }
            count +=2;
        }
    }
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(2); i++) // pages
    {
        Console.WriteLine($"page № {i+1}");
        for (int j = 0; j < matr.GetLength(0); j++) // rows
        {
            for (int k = 0; k < matr.GetLength(1); k++) // columns
            {
                Console.Write($" {matr[j, k, i]} ");
            }
            Console.WriteLine();
        }
    }
}

void GetElement(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(2); i++) // pages
    {
        Console.WriteLine($"page № {i+1}");
        for (int j = 0; j < matr.GetLength(0); j++) // rows
        {
            for (int k = 0; k < matr.GetLength(1); k++) // columns
            {
                Console.Write($"{matr[j, k, i]}  [{j}, {k}, {i}]  ");
            }
            Console.WriteLine();
        }
    }
}