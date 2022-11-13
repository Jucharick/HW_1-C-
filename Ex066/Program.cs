// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Задайте start");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте stop");
int stop = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от start до stop => {SumNaturalNumbers(start)}");

int SumNaturalNumbers(int start)
{
    if (start < stop) return SumNaturalNumbers(start + 1) + start;
    else return stop;
}