// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

//решение со звездочкой

//метод для считывания чисел
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//метод для выведения результата на экран
void PrintResult(string strRes)
{
    Console.WriteLine(strRes);
}
//метод для расчеты суммы цифр числа через вещественные числа
int SummDigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}
//метод для расчеты суммы цифр числа через строки
int SummDigitsViaString(int num)
{
    int res = 0;
    char[] digitChar = num.ToString().ToCharArray();
    for (int i = digitChar.Length - 1; i >= 0; i--)
    {
        res += (int)(digitChar[i] - '0');
    }
    return res;
}
//получаем число
int num = ReadData("Введите число: ");
//получаем время до выполнения метода
DateTime d1 = DateTime.Now;
//вызываем метод для расчета суммы
int res = SummDigits(num);
//выводим на экран время, затраченное на выполнение метода
System.Console.WriteLine(DateTime.Now - d1);

//получаем время до выполнения метода
DateTime d2 = DateTime.Now;
//вызываем метод для расчета суммы
int res2 = SummDigitsViaString(num);
//выводим на экран время, затраченное на выполнение метода
System.Console.WriteLine(DateTime.Now - d2);
//пишем на экране результат расчетов
PrintResult($"Сумма цифр числа = {res}");
PrintResult($"Сумма цифр числа = {res2}");
