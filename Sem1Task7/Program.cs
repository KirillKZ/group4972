// Задача №7
//Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.
System.Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num >= 100 && num < 1000)
{
int lastDigit = num % 10;
System.Console.WriteLine("Последняя цифра числа: " + lastDigit);
}
else
{
System.Console.WriteLine("Число не трехзначное");
}

