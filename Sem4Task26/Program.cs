// Задача №26 
// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3 
// 78 -> 2 
// 89126 -> 5

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

int CountDigits(int N)
{
    int length_num = (int)Math.Log10(N) + 1;
    return length_num;
}

int num = ReadData("Введите число:");

int res = CountDigits(num);

PrintResult("Количество чисел в цифре " + num + " = " + res);
