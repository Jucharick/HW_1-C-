// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// А В
// 1 4 | 3 5
// 3 5 | 1 2

// Результирующая матрица будет:
// С
// 7 13
// 14 25

// Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i-й строки и j-го столбца, равен сумме произведений 
// элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.

// С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
// С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
// С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
// С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25

// Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.

// В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В.


int[,] matrixA = new int[2, 2];

int[,] matrixB = new int[3, 4];


FillMatrix(matrixA, 0, 3);
Console.WriteLine("matrixA");
PrintMatrix(matrixA);
Console.WriteLine();
FillMatrix(matrixB, 1, 4);
Console.WriteLine("matrixB");
PrintMatrix(matrixB);
Console.WriteLine("matrixA * matrixB");
MatrixMultiplication(matrixA, matrixB);

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

void MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(0) == matrixB.GetLength(1)) // число строк матрицы A равно числу столбцов матрицы B 
    {
        int[,] matrixC = new int[matrixB.GetLength(0), matrixA.GetLength(1)]; // матрица C - число строк равно числу строк матрицы В, а число столбцов равно числу столбцов матрицы A
        for (int i = 0; i < matrixB.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
                for (int k = 0; k < matrixB.GetLength(1); k++)
                {
                    matrixC[i, j] = matrixC[i, j] +  matrixB[i, k] *  matrixA[k, j];
                }
            }
        }
        PrintMatrix(matrixC);
    }
    else if (matrixA.GetLength(1) == matrixB.GetLength(0)) // число столбцов матрицы A равно числу строк B
    {
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)]; // матрица C - число строк равно числу строк матрицы А, а число столбцов равно числу столбцов матрицы В
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] = matrixC[i, j] +  matrixA[i, k] *  matrixB[k, j];
                }
            }
        }
        PrintMatrix(matrixC);
    }
    else 
    {
        Console.WriteLine("matrixA нельзя умножить на matrixB");
    }  
}


// int[,] matrixA = new int[,]
// {
//     {1, 4},
//     {3, 5},
// };

// int[,] matrixB = new int[,]
// {
//     {3, 5},
//     {1, 2},
// };

// int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)]; // число столбцов матрицы А совпадает с числом строк матрицы В

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB, int[,] matrixC)
// {
//     matrixC[0, 0] = matrixA[0, 0] * matrixB[0, 0] + matrixA[0, 1] * matrixB[1, 0];
//     matrixC[0, 1] = matrixA[0, 0] * matrixB[0, 1] + matrixA[0, 1] * matrixB[1, 1];
//     matrixC[1, 0] = matrixA[1, 0] * matrixB[0, 0] + matrixA[1, 1] * matrixB[1, 0];
//     matrixC[1, 1] = matrixA[1, 0] * matrixB[0, 1] + matrixA[1, 1] * matrixB[1, 1];
//     return matrixC;
// }
// MatrixMultiplication(matrixA, matrixB, matrixC);
// PrintMatrix(matrixC);
