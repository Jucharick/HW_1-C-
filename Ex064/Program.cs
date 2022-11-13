// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Задайте значение N");
int n = int.Parse(Console.ReadLine());

PrintNaturalNumbers(n);
Console.WriteLine();
PrintNaturalNumbers1(1);

void PrintNaturalNumbers(int n) // способ 1
{
    int number = 1;
    if (number <= n)
    {
        Console.Write($"{n} "); // достаточно поменять местами вывод и рекурсионный вызов и вывод будет от N до 1
        PrintNaturalNumbers(n - 1);
    }
}


void PrintNaturalNumbers1(int number) // способ 2
{

    if (n == number) Console.Write(number);
    else
    {
        PrintNaturalNumbers1(number + 1); // достаточно поменять местами вывод и рекурсионный вызов и вывод будет от N до 1
        Console.Write($" {number}");
    }
}