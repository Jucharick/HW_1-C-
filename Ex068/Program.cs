// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Задайте неотрицательное число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте неотрицательное число n");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Значение функции Аккермана => {AckermanFunction(m, n)}");

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    else if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    else return AckermanFunction(m, n);
}