// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
string n = Console.ReadLine();
int length = n.Length;

if (length % 2 != 0)
{
    int i = 0;
    if (n[i] == n[n.Length - 1 - i])
    {
        i++;
        Console.WriteLine("палиндром!!!");
    }
}
else Console.WriteLine("нет, не палиндром");


// Console.WriteLine("Введите число");
// string n = Console.ReadLine();
// int length = n.Length;

// if (length % 2 != 0)
// {
//     for (int i = 0; i < length / 2; i++)
//     {
//         if (n[i] == n[n.Length - 1 - i]) Console.WriteLine("палиндром!!!");
//         if (n[i] != n[n.Length - 1 - i]) Console.WriteLine("нет");
//     }
// }
// else Console.WriteLine("нет, не палиндром");