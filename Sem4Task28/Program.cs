// Задача №28 
// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24 
// 5 -> 120
using System.Numerics;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string res)
{
    Console.WriteLine(res);
}

long FactorialN(int N)
{
    if (N == 1)
    {
        return 1;
    }
    else
    {
        return N * FactorialN(N - 1);
    }

}

BigInteger FactorialN2(int N)
{
    BigInteger res = 1;
    for (int i = 2; i <= N; i++)
    {
        res *= i;
    }
    return res;

}

int num = ReadData("Введите число:");

DateTime d1 = DateTime.Now;
long res = FactorialN(num);
System.Console.WriteLine(DateTime.Now - d1);


DateTime d2 = DateTime.Now;
BigInteger res2 = FactorialN2(num);
System.Console.WriteLine(DateTime.Now - d2);

PrintResult($"Факториал числа {num} = {res}");
PrintResult($"Факториал числа {num} = {res2}");