Console.WriteLine("введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (n > i)
{
    while (i <= n)
    {
        if (i%2 == 0) Console.Write(i + " ");
        i++;
    }
}
else if (n == 0 | n == i) Console.WriteLine("Четных чисел нет");
else // n < 0
{
    while (n < i)
    {
        if (n%2 == 0 & n!=0) Console.Write(n + " ");
        n++;
    }    
}


// Console.WriteLine("введите целое число");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= n)
// {
//     if (i%2 == 0) Console.Write(i + " ");
//     i++;
// }