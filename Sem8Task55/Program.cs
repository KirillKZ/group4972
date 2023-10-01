// Задача №55 
// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести 
// сообщение для пользователя

int[,] Create2DArray(int rows, int columns, int downLimit, int upLimit)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(downLimit, upLimit + 1);
        }
    }
    return matrix;
}

void PrintArray2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void turnArray90(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1 + i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }

    }

}

bool TestArrRot(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
    else return false;

}

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int rows = ReadData("Введите колчество строк:");
int columns = ReadData("Введите колчество столбцов:");

int[,] array2D = Create2DArray(rows, columns, 10, 99);
PrintArray2D(array2D);
System.Console.WriteLine();
if (TestArrRot(array2D))
{
    turnArray90(array2D);
    PrintArray2D(array2D);
}
else
{
    System.Console.WriteLine("переворот невозможен");
}

