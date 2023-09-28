// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//k - коэффициент наклона
//b - коэффициент смещения
// Коэффициент наклона k определяет, как быстро прямая растет или убывает по оси абсцисс. 

// Коэффициент смещения b определяет точку пересечения прямой с осью ординат. 



double ReadData(string msg)
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string res)
{
    Console.WriteLine(res);
}

(double, double) findeCrossPoint(double k1, double k2, double b1, double b2)
{

    double x = (b2 - b1) / (k1 - k2);
    return (x, k2 * x + b2);

}
// Если угловой коэффициент прямых равен, но их коэффициенты смещения различны, прямые параллельны.
// Если коэффициенты прямых равны, прямые совпадают.
bool checkCoords(double k1, double k2, double b1, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        System.Console.WriteLine("Прямые совпадают");
        return false;
    }
    else if (k1 == k2 && b1 != b2)
    {
        System.Console.WriteLine("Прямые параллельны");
        return false;
    }
    else return true;
}
double b1 = ReadData("коэффициент смещения линии №1");
double k1 = ReadData("коэффициент наклона линии №1");
double b2 = ReadData("коэффициент смещения линии №2");
double k2 = ReadData("коэффициент наклона линии №2");

if (checkCoords(k1, k2, b1, b2))
{
    (double x, double y) pointCoord = findeCrossPoint(k1, k2, b1, b2);
    PrintResult($"Точка пересечения линий y = {k1} * x + {b1} и y = {k2} * x + {b2} - ({pointCoord.x}, {pointCoord.y})");
}






