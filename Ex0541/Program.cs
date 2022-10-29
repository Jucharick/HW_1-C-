// Задача 54.1 : Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).


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
    SortMatrix(matrix);
    Console.WriteLine("Матрица с упорядоченными элементами по возрастанию:");
    PrintMatrix(matrix);
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

void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k <= matr.GetLength(0) - 2; k++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[k,j] > matr[k+1,j])
                {
                    int temp0 = matr[k,j];
                    matr[k,j] = matr[k+1,j];
                    matr[k+1,j] = temp0;
                    for (int l = 0; l <= matr.GetLength(1)-2; l++)
                    {
                        if (matr[i,l] > matr[i,l+1])
                        {
                            int temp1 = matr[i,l];
                            matr[i,l] = matr[i,l+1];
                            matr[i,l+1] = temp1;
                        }
                    }
                }
            }
        }
    }
}






// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
//     Console.WriteLine();
// }

// void SortArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j <= array.Length - 2; j++)
//         {
//             if (array[j] > array[j+1])
//             {
//                 int temp = array[j];
//                 array[j] = array[j+1];
//                 array[j+1] = temp;
//             }
//         } 
//     }
// }

// void SortMatrix(int[,] matr)
// {
//     int[] arrayMatrElements = new int[matr.GetLength(0) * matr.GetLength(1)];
//     int arEl = 0;
//     for (int i = 0; i < matr.GetLength(0); i++) // преобразую матрицу в массив
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             arrayMatrElements[arEl] = matr[i, j];
//             arEl++;
//         }
//     }
//     // PrintArray(arrayMatrElements);
//     SortArray(arrayMatrElements); // сортирую массив с элементами матрицы
//     // PrintArray(arrayMatrElements);
//     int mrEl =0;
//     for (int i = 0; i < matr.GetLength(0); i++) // преобразую отсортированный массив обратно в матрицу
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = arrayMatrElements[mrEl];
//             mrEl++;
//         }
//     }   
// }

