// Задача №18 
// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).

//Получаем номер четверти
int input(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//по номеру четверти определяем диапазон возможных координат
string anser(int x)
{
    switch (x)
    {
        case 1: return "x > 0 && y > 0";
        case 2: return "x < 0 && y > 0";
        case 3: return "x < 0 && y < 0";
        case 4: return "x > 0 && y < 0";
        default: return "";
    }

}

//выводим полученный ответ на экран
void output(string s)
{
    Console.WriteLine(s);
}
output(anser(input("Введите число от 1 до 4:")));