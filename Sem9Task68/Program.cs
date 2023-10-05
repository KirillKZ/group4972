// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
long RecAkkerman(long n, long m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return RecAkkerman(n - 1, 1);
    else
        return RecAkkerman(n - 1, RecAkkerman(n, m - 1));
}

long m = ReadData("Введите число M ");
long n = ReadData("Введите число N ");
System.Console.WriteLine(RecAkkerman(m, n));