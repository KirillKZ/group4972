// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int RecSumMN(int m, int n)
{
    if (m >= n)
    {
        return m;
    }
    else
    {
        return m + RecSumMN(m + 1, n);
    }
   
}

int m = ReadData("Введите число M ");
int n = ReadData("Введите число N ");
System.Console.WriteLine((m > n) ? RecSumMN(n, m) : RecSumMN(m, n));