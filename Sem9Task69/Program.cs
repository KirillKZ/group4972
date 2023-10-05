//Напишите программу которая будет принимать 2 числа А и В. Возведите А в степень В с помощью рекурсии

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

long PowRecursion(int A, int B)
{
    if (B <= 1)
    {
        return A;
    }
    else
    {
        return A * PowRecursion(A, B - 1);
    }
}

long PowRecursion2(int A, int B)
{
    if (B == 2)
    {
        return A * A;
    }
    if (B == 1)
    {
        return A;
    }
    if (B % 2 == 0)
    {
        return PowRecursion2(A, B/2) * PowRecursion2(A, B/2);
    }
    else
    {
        return PowRecursion2(A, B/2) * PowRecursion2(A, B/2 + 1);
    }

}
int A = ReadData("Введите число А: ");
int B = ReadData("Введите степень: ");
System.Console.WriteLine(PowRecursion(A, B));
System.Console.WriteLine(PowRecursion2(A, B));
