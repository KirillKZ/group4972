// Задача №0
//Напишите программу, которая на входе принимает число и выдает его квадрат (число умноженное на само себе)
Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();//??"0";
//Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
    //Парсим введеное число
    //int num = int.Parse(inputNum);
    //Находим квадрат числа
    //int res = num * num;
    //Выводим данные в консоль
    //Console.WriteLine(res);
Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));
}
