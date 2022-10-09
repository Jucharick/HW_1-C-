// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
string n = Console.ReadLine();
if (n.Length < 3) Console.WriteLine("третьей цифры нет");
else if (n[0] == '-') Console.WriteLine(n[3]);
else { Console.WriteLine($"третья цифра = {n[2]}"); }


// Console.WriteLine("Введите целое число");
// int n =  Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if (n > 99)
// {
//     if (n < 1000)
//     {
//         Console.WriteLine($"третья цифра = {n % 10}");
//     }
//     else 
//     {
//         int i = 10;
//         while (n/i > 1000)
//         {
//             i = i*10;
//         }
//         Console.WriteLine($"третья цифра = {n / i % 10}");
//     }
// }
// else 
// {
//     Console.WriteLine("третьей цифры нет");
// }