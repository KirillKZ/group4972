// Задача №42 
// Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101 
// 3 -> 11 
// 2 -> 10

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

string DecToBin(int num)
{
    string res = "";

    while (num > 0)
    {
        res = (num % 2) + res;
        num = num / 2;
    }

    return res;
}

int num = ReadData("Введите число: ");
PrintResult(DecToBin(num));

