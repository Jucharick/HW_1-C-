// Задача 29: Напишите программу, которая задаёт массив произвольной длины, заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива (не может быть меньше 2 и больше 20):");
int n = int.Parse(Console.ReadLine());

if (n > 20 | n < 2)
{
    Console.WriteLine("Длина массива не может быть меньше 2 и больше 20");
}
else 
{
    int[] tempMass = new int[n];
    randomMass(tempMass);
    printMass(tempMass);

}

void randomMass(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 31);
    }
}

void printMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length - 1)) Console.Write($", ");
    }
}