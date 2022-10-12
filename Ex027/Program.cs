// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое число:");
string n = Console.ReadLine();
int length = n.Length;

int sumOfNumbers (int sum)
{
    sum = 0;
    for (int index = 0; index < length; index++)
    {
        int num = int.Parse(Convert.ToString(n[index]));
        sum = sum + num;
    }
    return sum;
}

Console.WriteLine($"сумма чисел числа {n} равно: {sumOfNumbers(int.Parse(n))}");