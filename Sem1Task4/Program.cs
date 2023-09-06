// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int[] array = new int[3];
System.Console.WriteLine("Введите первое число: ");
array[0] = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите второе число: ");
array[1] = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите третье число: ");
array[2] = int.Parse(Console.ReadLine() ?? "0");
int max = array[0];
for (int i = 1; i < array.Length; i++) if (array[i] > max) max = array[i];
System.Console.WriteLine(max);