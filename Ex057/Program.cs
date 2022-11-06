// Задача 57 Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());


if (rows <= 0 || columns <= 0)
{
    Console.WriteLine("Количество строк и/или количество столбцов матрицы не может быть меньше или равно 0");
}
else
{
    int [,] matrix  = CreateMatrixRndInt(rows, columns, 0, 6);
    PrintMatrix(matrix);
    Console.WriteLine();

    int[] arrayFromMtrix= GetArrayFromMtrix(matrix);
    Array.Sort(arrayFromMtrix);
    PrintArray(arrayFromMtrix);
    CountPrintArrayGlossary(arrayFromMtrix);
}





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
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 2} | "); // 2 - для выравнивания вывода матрицы выводим по 2 символа
            else Console.Write($" {matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
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

int[] GetArrayFromMtrix(int[,] matrix)
{
    int[] result = new int[matrix.Length]; // matrix.Length - показывает количество элементов в двумерном массиве
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            result[index] = matrix[i, j];
            index++;
        }
    }
    return result;
}

void CountPrintArrayGlossary(int[] array)
{
    int num = array[0];
    int counter = 1; // 1 потому что значение array[0] уже +1
    for (int i = 1; i < array.Length; i++) // начинаем с 1 для того, чтобы не посчитать первый элемент (он у нас уже посчитан counter = 1)
    {
        if (num == array[i])
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"{num} встречается {counter} раз(а)");
            num = array[i];
            counter = 1;
        }
    }
    Console.WriteLine($"{num} встречается {counter} раз(а)"); // еще раз вывожу, потому что последнее число не попадает в else
}