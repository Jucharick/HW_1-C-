// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.WriteLine("Введите целое число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите введите степень:");
int B = int.Parse(Console.ReadLine());

double degreeOf(double degree)
{
    degree = 1;
    if (B >= 0)
    {
        for (int i = 0; i < B; i++)
        {
            degree = degree * A;
        }
    }
    else // if (B < 0)
    {
        for (int i = 0; i > B; i--)
        {
            degree = (degree * A);
        }
        degree = 1/degree;
    }
    return degree;
}

Console.WriteLine($"число {A} в степени {B} равно: {degreeOf(A)}");