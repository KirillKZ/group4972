﻿//№10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


//Выводим на экран строку с пояснением задачи
Console.WriteLine("Enter a three-digit number: ");
//считываем и парсим введеное пользователем число
int num = int.Parse(Console.ReadLine() ?? "0");
//получаем первые 2 цифры введеного числа
num = num / 10;
//получаем вторую цифру
num = num % 10;
//Выводим на экран вторую цифру с пояснением
Console.WriteLine("Second digit is - " + num);

