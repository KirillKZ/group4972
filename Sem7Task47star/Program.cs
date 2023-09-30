// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9 
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] arr2D = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr2D[i, j] = Math.Round(rnd.Next(minLimitRandom, maxLimitRandom) + rnd.NextDouble(), 1);
        }
    }
    return arr2D;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintRainbowArray(double[,] matrix)
{
    ConsoleColor[] colors = new ConsoleColor[]
        {ConsoleColor.Black,
        ConsoleColor.Blue,
        ConsoleColor.Cyan,
        ConsoleColor.DarkBlue,
        ConsoleColor.DarkMagenta,
        ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow,
        ConsoleColor.Gray,
        ConsoleColor.Green,
        ConsoleColor.Red};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            char[] charArr = matrix[i, j].ToString().ToCharArray();
            foreach (char c in charArr)
            {
                if (Char.IsDigit(c))
                {
                    Console.ForegroundColor = colors[new System.Random().Next(0, 10)];
                    System.Console.Write(c);
                    Console.ResetColor();
                }
                else 
                {
                  System.Console.Write(c);  
                }
            }
            System.Console.Write("\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadData("Введите число строк:");
int columns = ReadData("Введите число столбцов:");
double[,] arr2D = CreateRandomMatrix(rows, columns, 1, 99);
PrintArray(arr2D);
System.Console.WriteLine();
PrintRainbowArray(arr2D);

