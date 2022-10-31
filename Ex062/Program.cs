// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] matrix = new int[4, 4]
                {
                    {16,  02, 10,  4},
                    {5,  6,  11,  8},
                    {9,  3,  7,  12}, 
                    {13, 14, 15,  1},
                };


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
    int temp = 0;
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matrix[i, j] > matrix[i, j+1] && j <= matrix.GetLength(1) - 2)
            {
                matrix[i, j] = temp;
                matrix[i, j] = matrix[i, j+1];
                matrix[i, j+1] = temp;
            }
            else if (matrix[i, j] > matrix[i+1, j] && i <= matrix.GetLength(0) - 2)
            {
                matrix[i, j] = temp;
                matrix[i, j] = matrix[i+1, j];
                matrix[i+1, j] = temp;
            }
            else if (matrix[i, j] >= matrix[i, j-1] && j <= matrix.GetLength(1) - 2)
            {
                matrix[i, j] = temp;
                matrix[i, j] = matrix[i, j-1];
                matrix[i, j-1] = temp;
            }
            else if (matrix[i, j] > matrix[i-1, j] && i <= matrix.GetLength(0) - 2)
            {
                matrix[i, j] = temp;
                matrix[i, j] = matrix[i-1, j];
                matrix[i-1, j] = temp;
            }                     
        }
    }
}


// void SortBySpiral(int[,] matr)
// {
//     int i = 0;
//     int j = 0;
//     int temp = 1;
//     while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
//     {
//         matrix[i, j] = temp;
//         temp++;
//         if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
//             j++;
//         else if (i < j && i + j >= matrix.GetLength(0) - 1)
//             i++;
//         else if (i >= j && i + j > matrix.GetLength(1) - 1)
//             j--;
//         else
//             i--;
//     }
// }