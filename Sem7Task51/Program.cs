// Задача №51
// Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с 
// индексами (0,0); (1;1) и т.д.
// Например:
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Сумма элементов главной диагонали: 1+9+2 = 12


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

string CountDiagonalSum(int[,] matrix)
{
    string str = "";
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        str += matrix[i, i] + " + ";
        sum += matrix[i, i];
    }
    return "Сумма элементов главной диагонали: " + str.Remove(str.Length - 3) + " = " + sum;
}

void PrintArray2D(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {


        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write(matrix[i, j] + "\t");
            Console.ResetColor();
        }
        System.Console.WriteLine();

    }

}

int rows = ReadData("Введите число строк:");
int columns = ReadData("Введите число столбцов:");
int[,] arr2D = Create2DArray(rows, columns, 1, 5);
PrintArray2D(arr2D);

System.Console.WriteLine(CountDiagonalSum(arr2D));