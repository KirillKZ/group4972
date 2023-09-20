// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
void PrintResult(string strRes)
{
    Console.WriteLine(strRes);
}

int SummDigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;        
    }
    return res;
}

int num = ReadData("Введите число: ");
int res = SummDigits(num);
PrintResult($"Сумма цифр числа = {res}");
