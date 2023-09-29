// Задача №46
// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// Например: 
// m = 3, n = 4. 
// -1 4 8 19 
// 5 -2 33 -2 
// -77 3 8 1


// Метод считывания введенных данных.
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод для вывода на экран
// void PrintResult(string res)
// {
//     Console.WriteLine(res);
// }
//Метод для преобразования двумерного массива в строку
// string Array2DToString(int[,] arr2D)
// {
//     string str = "";
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             str += arr2D[i, j] + " ";
//         }
//         str += "\n";

//     }
//     return str;   
// }

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
            System.Console.Write(matrix[i, j] + " ");
            Console.ResetColor();
        }
        System.Console.WriteLine();

    }

}

int[,] Create2DArray(int numRows, int numColumns, int downBound, int upBound)
{
    int[,] arr2D = new int[numRows, numColumns];
    Random rnd = new Random();
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numColumns; j++)
        {
            arr2D[i, j] = rnd.Next(downBound, upBound + 1);
        }

    }
    return arr2D;
}

int rows = ReadData("Введите число строк:");
int columns = ReadData("Введите число столбцов:");

int[,] arr2D = Create2DArray(rows, columns, 10, 99);

//PrintResult(Array2DToString(arr2D));
PrintArray2D(arr2D);