// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите целое трехзачное число");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (n < 100 | n > 999)
{
    Console.WriteLine("Вы ввели некорректное значение");
}
else
{
    int second = n / 10 % 10;
    Console.WriteLine("вторая цифра = " + second);
}



// int[] arr = new int[3];
// Console.WriteLine("Введите целое трехзачное число");
// for (int i = 0; i < arr.Length; i ++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine();
// Console.WriteLine("вторая цифра = " + arr[1]);



// Console.WriteLine("Введите целое трехзачное число");
// string n = Console.ReadLine();
// if (n.Length > 3 | n.Length < 3) Console.WriteLine("это не трехзачное число");
// else if (n[0] == '-') Console.WriteLine(n[2]);
// else {Console.WriteLine($"вторая цифра = {n[1]}");}