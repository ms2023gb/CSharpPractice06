/*
    Задача 41: Пользователь вводит с клавиатуры M чисел.
    Посчитайте, сколько чисел больше 0 ввёл пользователь.**
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int number = ReadNumberIntFromConsole("Введите количество чисел: ");
int[] arrayNumber = ReadArrayIntFromConsole(number);
Console.WriteLine($"Количество чисел больше 0: {CountArrayPositiveNumber(arrayNumber)}");

int ReadNumberIntFromConsole(string message = "")
{
    if (message != "")
        Console.Write(message);
    string input = Console.ReadLine()!;
    return int.Parse(input);
}

int[] ReadArrayIntFromConsole(int lenghtArray)
{
    int[] array = new int[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
    {
        array[i] = ReadNumberIntFromConsole($"Введите {i + 1}-е число: ");
    }
    return array;
}

int CountArrayPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}