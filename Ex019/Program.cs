// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Давайте проверим является ли число палиндромом. Введите целое число: ");
string n = Console.ReadLine();
if ( int.TryParse(n, out int result) ) // проверя, что ввели число
{
    int length = n.Length;
    if (length % 2 != 0)
    {
        int i = 0;
        bool check = false;
        while (i < length/2)
        {
            if (n[i] == n[n.Length - 1 - i]) 
            {
                check = true;
            }
            else 
            {
                check = false;
                break;
            }
            i++;
        }   
        if (check == true) Console.WriteLine("палиндром!!!");
        else Console.WriteLine("нет, не палиндром");
    }
    else Console.WriteLine("У палиндрома должно быть нечетное количество цифр");
}
else Console.WriteLine("вы ввели некорректное значение");






// Console.WriteLine("Введите пятизначное число");
// string n = Console.ReadLine();
// int length = n.Length;
// if (length == 5)
// {
//     if (n[0] == n[n.Length - 1])
//     {
//         if (n[1] == n[n.Length - 2])
//         {
//             Console.WriteLine("палиндром!!!");
//         }
//         else Console.WriteLine("нет, не палиндром");
//     }
//     else Console.WriteLine("нет, не палиндром");
// }
// else Console.WriteLine("это не пятизначное число");