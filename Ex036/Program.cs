// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [0 1 2 3 4 5] => 1, 3, 5
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



Console.WriteLine("Введите длину массива:");
int n = int.Parse(Console.ReadLine());
int[] array = new Int32[n];

void FillArray(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

void sumOdd(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sumOdd = sumOdd + array[i];
    }
    if (sumOdd!= 0) Console.WriteLine($"Сумма чисел стоящих на нечётных позициях: {sumOdd}");
    else Console.WriteLine("Чисел, стоящих на нечётных позициях, в массиве нет");
}


FillArray(array, -9, 10);
PrintArray(array);
sumOdd(array);