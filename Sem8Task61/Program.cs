// Задача №61
// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного 
// треугольника


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintPaskalTriangle (int n)
{
    for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    System.Console.Write("   ");
                }
 
                for (int x = 0; x <= y; x++)
                {
                    System.Console.Write($"   {c} ");
                    c = c * (y - x) / (x + 1);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
}

int length = ReadData("Введите количество первых строк треугольника Паскаля:");

PrintPaskalTriangle (length);