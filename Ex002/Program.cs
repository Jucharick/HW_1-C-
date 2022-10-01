Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое число");
int m = Convert.ToInt32(Console.ReadLine());
if (n < m) 
{
    Console.WriteLine("Максимальное число = " + m);
    Console.WriteLine("Минимальное число = " + n);
}
else if (m == n) Console.WriteLine("Введенные числа равны");
else 
{
    Console.WriteLine("Максимальное число = " + n);
    Console.WriteLine("Минимальное число = " + m);
}