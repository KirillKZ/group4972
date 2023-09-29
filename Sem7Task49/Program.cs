// Задача №49
// Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти 
// элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Новый массив будет выглядеть вот так: 
// 1 4 7 2 
// 5 81 2 9 
// 8 4 2 4

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintArray2D(int[,] matrix)
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

int[,] PowIsEvenIndexes(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
    return matrix;
}

int rows = ReadData("Введите число строк:");
int columns = ReadData("Введите число столбцов:");
int[,] arr2D = Create2DArray(rows, columns, 1, 10);
PrintArray2D(arr2D);
System.Console.WriteLine();
PrintArray2D(PowIsEvenIndexes(arr2D));


