// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




Console.WriteLine("Введите длину массива:");
int n = int.Parse(Console.ReadLine());
double [] array = new Double[n];

void FillArrayDouble(double[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to);
        double rand = new Random().NextDouble(); // Random.NextDouble() Возвращает случайное число с плавающей запятой, которое больше или равно 0,0 и меньше 1,0.
        array[i] = array[i] + Math.Round(rand, 1);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

void sumOdd(double[] array)
{
    double sumOdd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOdd = sumOdd + array[i];
    }
    if (sumOdd != 0) Console.WriteLine($"Сумма нечетных чисел в массиве: {sumOdd}");
    else Console.WriteLine("Нечетных чисел в массиве нет");
}


FillArrayDouble(array, -5, 10);
PrintArray(array);
sumOdd(array);