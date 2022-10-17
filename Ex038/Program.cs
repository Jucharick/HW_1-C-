// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




FillArrayDouble(array, -5, 10);
PrintArray(array);
sort(array);
PrintArray(array);


Console.WriteLine("Введите длину массива:");
int n = int.Parse(Console.ReadLine());
double[] array = new Double[n];

void FillArrayDouble(double[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to);
        double rand = new Random().NextDouble(); // Random.NextDouble() Возвращает случайное число с плавающей запятой, которое больше или равно 0,0 и меньше 1,0.
        array[i] = array[i] + rand;
        array[i] = Math.Round(array[i], 1);
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

void sort(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j <= array.Length - 2; j++) // идем до предпоследнего значения для того, чтобы было место для замены последнего и предпоследнего
        {
            if (array[j] > array[j + 1]) 
            {
                double temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
}