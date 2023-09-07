// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
System.Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");
bool test1 = (first == second*second);
bool test2 = (first*first == second);
if (test1)System.Console.WriteLine("первое квадрат второго");
if (test2)System.Console.WriteLine("второе квадрат первого");
if (!(test1||test2))System.Console.WriteLine("числа не квадрат друг друга");