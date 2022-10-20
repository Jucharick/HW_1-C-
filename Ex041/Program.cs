// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// List<T> Класс
// Представляет строго типизированный список объектов, доступных по индексу.


List<double> array = new List<double>(); // в c# нельзя создать динамический массив, поэтому использую List
double n = 0;

FillList(array);
PrintList (array);
Find (array);

void FillList (List<double> array)
{
    while ( n != 111 )
    {
        Console.WriteLine("Введите число. В качестве последнего элемента введите 111");
        n = Convert.ToDouble(Console.ReadLine());
        if (n != 111) array.Add(n);
    }
}

void PrintList (List<double> array)
{
    for (int i = 0; i < array.Count - 1; i++) // array.Count - количество элементов в списке (аналогично как у массива array.Length) 
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Count-1]);
    Console.WriteLine();
}

void Find (List<double> array)
{
    int count = 0;
    for (int i = 0; i < array.Count - 1; i++) // array.Count - количество элементов в списке (аналогично как у массива array.Length) 
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"чисел больше нуля: {count}");
}