// Задача №57 
// Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается 
// элемент входных данных.


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

int[] FrequencyDict(int[,] matrix, int max)
{
    int[] freq = new int[max + 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            freq[matrix[i, j]] ++;
        }
    }
    return freq;
}

void PrintResult(int[] arr)
{
    System.Console.WriteLine("Частота встречаемости чисел в массиве:");
    System.Console.WriteLine("число\tчастота");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            System.Console.WriteLine($"{i}\t{arr[i]}");
        }
    }
}

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int rows = ReadData("Введите колчество строк:");
int columns = ReadData("Введите колчество столбцов:");
int max = ReadData("Введите максимальное значение элемента в массиве:");

int[,] array2D = Create2DArray(rows, columns, 0, max);
PrintArray2D(array2D);
PrintResult(FrequencyDict(array2D, max));

