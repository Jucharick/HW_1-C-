// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



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

void numEven(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even ++;
        }
    }
    if (even == 0) Console.WriteLine("Четных чисел в массиве нет");
    else Console.WriteLine($"Четных чисел в массиве: {even}");
}


FillArray(array, 100, 1000);
PrintArray(array);
numEven(array);