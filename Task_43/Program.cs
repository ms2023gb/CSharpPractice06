/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
Console.WriteLine("Введите коэфициенты первой прямой ( x * k1 + b1 ) :");
double k1 = ReadNumberDoubleFromConsole("k1: ");
double b1 = ReadNumberDoubleFromConsole("b1: ");

Console.WriteLine("Введите коэфициенты второй прямой ( x * k2 + b2 ) :");
double k2 = ReadNumberDoubleFromConsole("k2: ");
double b2 = ReadNumberDoubleFromConsole("b2: ");

Console.WriteLine($"Две прямые {k1}x+{b1} и {k2}x+{b2}: ");

if (k1 != k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.WriteLine($"Пересекаются в точке: A ({x}, {y})");
}
else
{
    if (b1 != b2) Console.WriteLine("Не пересекаются, т.к параллельны");
    else Console.WriteLine("Не пересекаются, т.к равны");
}

double ReadNumberDoubleFromConsole(string message = "")
{
    if (message != "")
        Console.Write(message);
    string input = Console.ReadLine()!;
    return double.Parse(input);
}
