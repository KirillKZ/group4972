// Среднее арифметическое каждого столбца


// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся 
// на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список н
// а экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, 
// округленные до двух знаков после запятой, разделенные знаком табуляции.


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

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        string str = "";

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str += matrix[i, j] + "\t";
            

        }
        System.Console.Write(str.Remove(str.Length - 1));
        System.Console.WriteLine();

    }

}

double[] FindAverageInColumns(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int colSum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            colSum += matrix[j, i];
        }
        arr[i] = (double)colSum / matrix.GetLength(0);
    }
    return arr;

}

void PrintListAvr(double[] list)
{
    string str = "";
    foreach (double l in list)
    {
        str += String.Format("{0:0.00}", l) + "\t";

    }
    System.Console.WriteLine($"The averages in columns are:\n{str.Remove(str.Length - 1)}");


}

int n = 4;
int m = 5;
int k = 3;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));
