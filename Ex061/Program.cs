// Задача 61 Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

// ......1
// .....1 1
// ....1 2 1
// ...1 3 3 1
// ..1 4 6 4 1


// 1
// 1 1
// 1 2 1
// 1 3 3 1
// 1 4 6 4 1

// Точки в началах строк в примере решения проставлены, так как редактор игнорирует пробелы в начале строки и выравнивает строки по левому краю.
// Треугольник становится не равнобедренным, а прямоугольным.
// В своем варианте решения попробуйте вывести равнобедренный треугольник без дополнительных точек.



int row = 5; // выводим 5 строк треугольника Паскаля
int[,] triangle = new int[row, row];
const int cellWidth = 3; // количество сиволов, используемые для вывода этого треугольника

void FillTriangle(int[,] triangle)
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1; // выводим первую строку
        triangle[i, i] = 1; // выводим крайние элементы
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j]; // triangle[i - 1, j - 1] - элемент над текущим элементом; triangle[i - 1, j] - элемент выше и левее текущего элемента
        }
    }
}

void PrintTriangle(int[,] triangle)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0) // в треугольнике Паскаля нет нулевых элементов
            {
                Console.Write($"{triangle[i, j], cellWidth}");
            }
        }
        Console.WriteLine();
    }
}

// void Magic()
// {
//     int col = cellWidth*row;
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 1; j <= i; j++)
//         {
//             Console.SetCursorPosition(col, i+1);
//             if (triangle[i, j] != 0) // в треугольнике Паскаля нет нулевых элементов
//             {
//                 Console.WriteLine($"{triangle[i, j], cellWidth}");
//             }

//             col = col + cellWidth * 2;
//         }
//         col = cellWidth * row - cellWidth * (i + 1);
//         Console.WriteLine();
//     }
// }

// Console.ReadLine();
FillTriangle(triangle);
PrintTriangle(triangle);
// Console.ReadLine();
// Magic();






// double Fibonacci(int n) // метод, принимающий целое число и возвращающий целое число.
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 7; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }