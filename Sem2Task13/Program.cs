//№13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//* Сделать вариант для числа длиной до 10 цифр не используя char или string

void variant1()
{
    //Выводим на экран строку с пояснением задачи
    Console.WriteLine("Enter a number of less than 10 digits: ");
    //считываем и парсим введеное пользователем число
    int num = int.Parse(Console.ReadLine() ?? "0");
    //объявляем массив типа char, преобразуем введенное число в строку, а затем символами строки заполняем массив
    char[] digitChar = num.ToString().ToCharArray();
    //еслии длина массива меньше трех выводим соответствующее сообщение, в ином случае выводим 3 значение массива
    if (digitChar.Length < 3)
    {
        Console.WriteLine("There is no third digit in this number");
    }
    else
    {
        Console.WriteLine(digitChar[2]);
    }
}

void variant2()
{
    //Выводим на экран строку с пояснением задачи
    Console.WriteLine("Enter a number of less than 10 digits: ");
    //считываем и парсим введеное пользователем число
    int num = int.Parse(Console.ReadLine() ?? "0");
    //объявляем переменную для длины числа num
    int length_num = 0;
    //объявляем массив типа int длиной 10 для хранения цифр из числа num
    int[] digits = new int[10];
    //в цикле заполняем массив цифрами и подсчитываем их число
    while (num > 0)
    {
        digits[length_num] = num % 10;
        num = num / 10;
        length_num++;
    }
    //если количество цифр в числе меньше трех выводим соответствующее сообщение, в ином случае выводим 3 цифру числа, индекс в массиве которой расчитываем вычитая из длины числа 3
    if (length_num < 3)
    {
        Console.WriteLine("There is no third digit in this number");
    }
    else
    {
        Console.WriteLine(digits[length_num - 3]);
    }
}

variant1();
variant2();
