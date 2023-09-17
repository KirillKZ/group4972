// Задача №20 
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
double Calc2DDist(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}
void PrintResult(double dub)
{
    Console.WriteLine("Расстояние между точками - " + dub);
}

PrintResult(Calc2DDist(ReadData("Введите координату х точки А"), ReadData("Введите координату y точки А"), ReadData("Введите координату х точки В"), ReadData("Введите координату y точки В")));