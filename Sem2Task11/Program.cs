// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
void Variant1()
{
    int ran = new System.Random().Next(100, 1000);
    System.Console.WriteLine(ran);
    char[] digitChar = ran.ToString().ToCharArray();
    System.Console.Write(digitChar[0]);
    System.Console.Write(digitChar[2]);
}

void Variant2()
{
int ran = new System.Random().Next(100, 1000);
    System.Console.WriteLine(ran);
    int firstDigit = ran /100;
    int secondDigit = ran % 10;
    System.Console.WriteLine(firstDigit * 10 + secondDigit);
}

Variant2();