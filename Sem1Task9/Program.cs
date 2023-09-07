// Задача №9
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
void Variant1()
{
    int ran = new System.Random().Next(10, 100);
    System.Console.WriteLine(ran);

    int firstDigit = ran / 10;
    int secondDigit = ran % 10;
    if (firstDigit > secondDigit)
    {
        System.Console.WriteLine(firstDigit);
    }
    else
    {
        System.Console.WriteLine(secondDigit);
    }
}

void Variant2()
{
    int ran = new System.Random().Next(10, 100);
    System.Console.WriteLine(ran);
    System.Console.WriteLine((ran / 10 > ran % 10) ? ran / 10 : ran % 10);
}

void Variant3()
{
    int ran = new System.Random().Next(10, 100);
    System.Console.WriteLine(ran);
    char[] digitChar = ran.ToString().ToCharArray();
    System.Console.WriteLine((int)digitChar[0] > (int)digitChar[1] ? digitChar[0]  : digitChar[1] );
}

//Variant1();
//Variant2();
Variant3();