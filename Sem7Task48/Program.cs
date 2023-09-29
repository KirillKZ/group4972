// Задача №48
// Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится по формуле: Aₘₙ = 
// m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4 
// 2 3 4 5

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Create2DArray(int numRows, int numColumns)
{
    int[,] arr2D = new int[numRows, numColumns];
   
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numColumns; j++)
        {
            arr2D[i, j] = i + j;
        }

    }
    return arr2D;
}

void PrintArray2D(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[new System.Random().Next(0,10)];
            System.Console.Write(matrix[i, j] + "\t");
            Console.ResetColor();
        }
        System.Console.WriteLine();

    }

}

int rows = ReadData("Введите число строк:");
int columns = ReadData("Введите число столбцов:");
int[,] arr2D = Create2DArray(rows, columns);
PrintArray2D(arr2D);