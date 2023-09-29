// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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
            System.Console.Write(matrix[i, j] + " ");

        }
        System.Console.WriteLine();

    }

}

int rows = ReadData("Введите число строк:");
int columns = ReadData("Введите число столбцов:");
double[,] arr2D = CreateRandomMatrix(rows, columns, -10, 10);
PrintArray(arr2D);
