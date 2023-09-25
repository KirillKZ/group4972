// Задача №40 
// Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(bool res)
{
    Console.WriteLine(res);
}

bool TriangleTest(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}

int a = ReadData("Введите число: ");
int b = ReadData("Введите число: ");
int c = ReadData("Введите число: ");
PrintResult(TriangleTest(a, b, c));
