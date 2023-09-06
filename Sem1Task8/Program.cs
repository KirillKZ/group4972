// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
string str = "";
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        str = str + i + ", ";
    }
}
Console.Write(str.TrimEnd(new Char[] { ' ', ',' }));