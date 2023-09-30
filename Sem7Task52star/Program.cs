// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом


//создаем и заполняем двумерный массив
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] arr2D = new int[n, m];
    int sum = 1;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr2D[i, j] += sum;
            sum += k;
        }

    }
    arr2D[0, 0] = 1;
    return arr2D;
}
//находим значения диагоналей, раскрашиваем и выводим на экран, одновременно с этим создаем двумерный массив со значениями диагоналей
int[,] PrintColorDiagonals(int[,] matrix)
{
    int[,] diagNums = new int[matrix.GetLength(0) + (matrix.GetLength(1) - 1), matrix.GetLength(1)];

    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (x - y >= 0) diagNums[x - y, y] = matrix[x, y];
            else diagNums[diagNums.GetLength(0) + (x - y), y] = matrix[x, y];

            SetColor(matrix, x, y);
        }
        System.Console.WriteLine();
    }

    return diagNums;
}
//находим среднюю арифметическую по диагоналям
void FindDiagonalAvrgAndPrinResult(int[,] matrix)
{

    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        string str = "";
        int sum = 0;
        int count = 0;
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (matrix[x, y] > 0)
            {
                str += " - " + matrix[x, y];
                sum += matrix[x, y];
                count++;
            }

        }
        System.Console.WriteLine($"The average in diagonal{str} are: {((double)sum / (double)count)}");


    }
}

void SetColor(int[,] matrix, int x, int y)
{
    ConsoleColor[] colors = new ConsoleColor[]
       {ConsoleColor.White,
         ConsoleColor.Blue,
         ConsoleColor.Cyan,
         ConsoleColor.DarkBlue,
         ConsoleColor.DarkMagenta,
         ConsoleColor.DarkRed,
         ConsoleColor.DarkYellow,
         ConsoleColor.Gray,
         ConsoleColor.Green,
         ConsoleColor.Red};
    Console.ForegroundColor = colors[5 + (x - y)];
    System.Console.Write(matrix[x, y] + "\t");
    Console.ResetColor();

}

//определяем размерность массива и шаг для заполнения значениями (размерность массива ограничена количеством цветов в палитре)
int n = 5;
int m = 5;
int k = 1;

int[,] matrix = CreateIncreasingMatrix(n, m, k);

FindDiagonalAvrgAndPrinResult(PrintColorDiagonals(matrix));


