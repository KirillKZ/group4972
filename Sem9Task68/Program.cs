// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
long RecAkkerman(long m, long n)
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return RecAkkerman(m - 1, 1);
    else
        return RecAkkerman(m - 1, RecAkkerman(m, n - 1));
}

long m = ReadData("Введите число M ");
long n = ReadData("Введите число N ");
System.Console.WriteLine(RecAkkerman(m, n));