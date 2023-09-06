//Задача №1
//Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
System.Console.WriteLine("Введите первое число:");
int numA = int.Parse(Console.ReadLine() ?? "0") ;
System.Console.WriteLine("Введите второе число:");
int numB = int.Parse(Console.ReadLine() ?? "0") ;
if (numB * numB == numA)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}
