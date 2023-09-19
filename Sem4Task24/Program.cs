// Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// Например: 
// 7 -> 28 
// 4 -> 10 
// 8 -> 36

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

string SimpleSum(int N)
{
    int res = 0;
    for (int i = 1; i <= N; i++)
    {
        res = res + i;
    }
    return "Сумма чисел от 1 до " + N + " = " + res;
}

//решение аналитическим способом (по Гауссу)
string GaussSum(int N)
{
    int res = N * (N + 1) / 2;

    return "Сумма чисел от 1 до " + N + " = " + res;
}
int num = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
string res1 = SimpleSum(num);
System.Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
string res2 = GaussSum(num);
System.Console.WriteLine(DateTime.Now - d2);

PrintResult(res1);
PrintResult(res2);