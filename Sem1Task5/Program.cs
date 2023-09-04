// Задача №5
//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
System.Console.WriteLine("Введите число:");
int numN = int.Parse(Console.ReadLine() ?? "0");
for (int i = numN * -1; i <= numN; i++)
{
    Console.Write(i + " ");
}
