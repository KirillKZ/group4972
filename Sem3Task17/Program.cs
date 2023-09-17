// Задача 17. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта 
// точка
// Например: 
// x=34; y=-30 -> 4
// x=2; y=4-> 1 
// x=-34; y=-30 -> 3

//вводим данные
int input(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//по координатам точки определяем неомер четверти
int anser(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;

}
//печатаем результат
void output(int num)
{
    Console.WriteLine("Точка находится в четверти №" + num);
}
output(anser(input("Введите число не равное нулю (координата Х):"), input("Введите число не равное нулю (координата Y): ")));
