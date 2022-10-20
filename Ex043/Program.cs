// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Для нахождения точки пересечения двух прямых задайте следующие значения:");
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1;
// y = k2 * x + b2

// y - y = k1 * x + b1 - k2 * x - b2 ;
// y = k2 * x + b2

// 0 = k1 * x + b1 - k2 * x - b2 ;
// y = k2 * x + b2

// b2 - b1 = k1 * x - k2 * x;
// y = k2 * x + b2

// x = (b2 - b1)/(k1-k2)
// y = k2 * x + b2

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"Координаты точки пересечения двух прямых: ({Math.Round(x, 1)}, {Math.Round(y, 1)})");