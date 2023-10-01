// Задача №59
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и 
// столбец, на пересечении которых расположен 
// наименьший элемент массива

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

void FindMin(int[,] matrix, ref int rowIndex, ref int columnIndex)
{

    int min = matrix[0, 0];
    rowIndex = 0;
    columnIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                rowIndex = i;
                columnIndex = j;
            }
        }
    }
    System.Console.WriteLine("Индексы минимального элемента - " + rowIndex + ", " +  columnIndex);

}

int[,] DeletRowAndColumn(int[,] matrix, int rowIndex, int columnIndex)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != rowIndex)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != columnIndex)
                {
                    result[m, n] = matrix[i, j];
                    n++;
                }
            }
            m++;
            n = 0;
        }

    }

    return result;

}

int rowIndex = 0;
int columnIndex = 0;

int[,] matrix = Create2DArray(4, 4, 1, 9);
PrintArray2D(matrix);
FindMin(matrix, ref rowIndex, ref columnIndex);

PrintArray2D(DeletRowAndColumn(matrix, rowIndex, columnIndex));
