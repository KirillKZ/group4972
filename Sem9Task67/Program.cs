// Задача 67
// Программа принимает на вход число N и возвращает сумму цифр в числе


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int summOfNumber(int N)
{
    if (N == 0)
    {
        return 0;
    }
    else
    {
        return N % 10 + summOfNumber(N / 10);
    }
}


System.Console.WriteLine(summOfNumber(ReadData("Введите число: ")));

