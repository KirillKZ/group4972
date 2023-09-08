//№13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//* Сделать вариант для числа длиной до 10 цифр не используя char или string


Console.WriteLine("Enter a number of less than 10 digits: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int length_num = 0;
int[] digits = new int[10];
while (num > 0)
{
    digits[length_num] = num % 10;
    num = num / 10;
    length_num++;
}

if (length_num < 3)
{
    Console.WriteLine("There is no third digit in this number");
}
else
{
    Console.WriteLine(digits[length_num - 3]);
}

