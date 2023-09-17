// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        if (number >= 10000 && number < 100000)
        {
            string res = "";
            char[] digitChar = number.ToString().ToCharArray();
            for (int i = digitChar.Length - 1; i >= 0; i--)
            {
                res = res + digitChar[i];
            }
            return (res.Equals(number.ToString())) ? true : false;
        }
        else
        {
            System.Console.WriteLine("Число не пятизначное");
            return false;
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 645455;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}