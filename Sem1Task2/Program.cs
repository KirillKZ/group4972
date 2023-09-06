// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");
int max = first > second ? first : second;
Console.WriteLine("max = " + max);
