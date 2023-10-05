// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// ЗАдача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void GenLineRec (int num)
{
    System.Console.Write(num + " ");
    if (num <= 1)
    {
       
    }
    else
    {
        GenLineRec(num-1);
    }
    
}

GenLineRec (ReadData("Введите число N: "));