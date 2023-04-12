// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями у = kl * х + b1, у = k2 * х + Ь2; значения b1, kl, b2 и k2 задаются пользователем.
// b1 =2, kl = 5, b2 = 4, k2 = 9 -> (-0,5;-0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineDatal = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineDatal, lineData2))
{
    double[] coord = FindCoords(lineDatal, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineDatal[COEFFICIENT]}*x+{lineDatal[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}

// Ввод числа
double Promt(string message)
{
    Console.WriteLine(message); // вывести сообщение
    string value = Console.ReadLine(); // считывает с консоли строку
    double result = Convert.ToDouble(value); // преобразует строку в целое число
    return result; // возвращает результат
}

// Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Promt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONSTANT] = Promt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

// Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y_COORD] = lineData1[COEFFICIENT] * coord[X_COORD] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}