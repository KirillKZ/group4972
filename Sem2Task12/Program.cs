// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
System.Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");
String result = (second%first == 0) ? "Второе кратно первому" : "Второе не кратно первому" + ". Остаток от деления: " + second%first;
System.Console.WriteLine(result);