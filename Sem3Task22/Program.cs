// Задача №22
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25. 
// 2 -> 1,4

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string BuildLine(int num, int pow)
{
    string strResult = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        strResult = strResult + Math.Pow(i, pow) + " ";
    }
    return strResult;
}

void PrintResult(string str)
{
    Console.WriteLine(str);
}
int n = ReadData("Введите число: ");
PrintResult(BuildLine(n, 1));
PrintResult(BuildLine(n, 2));