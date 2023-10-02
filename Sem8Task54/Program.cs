// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//--------------------------------------------------------------РЕШЕНИЕ-----------------------------------------------------------------
//метод для получения данных от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод для создания двумерного массива и заполнения его случайными числами в заданном диапазоне
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
//метод для вывода двумерного массива на экран
void PrintArray2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.Write("{");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            System.Console.Write(matrix[i, j] + ", ");
        }
        System.Console.Write(matrix[i, matrix.GetLength(1) - 1] + "");
        System.Console.Write("}");
        System.Console.WriteLine();
    }
}

//метод для сортировки строк двумерного массиа в порядке убывания с использованием сортировки пузырьком 
void SortLineInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1) - 2; j >= 0; j--)
        {
            for (int k = matrix.GetLength(1) - j - 2; k >= 0; k--)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}
//переменная для заданиия нижнего лимита значений в массиве
int downLimit = 1;
//переменная для заданиия верхнего лимита значений в массиве
int upLimit = 9;
//переменная для определения кол-ва строк в массиве (получаем от пользователя)
int rows = ReadData("Введите количество строк:");
//переменная для определения кол-ва столбцов в массиве (получаем от пользователя)
int columns = ReadData("Введите количество столбцов:");
//создаем переменную для двумерного массива и присваиваем ей ссылку на созданный в методе массив
int[,] matrix = Create2DArray(rows, columns, downLimit, upLimit);
//выводим на экран исходный массив
PrintArray2D(matrix);
//сортируем линии массива в методе
SortLineInMatrix(matrix);
//выводим пустую строку
System.Console.WriteLine();
//выводим отсортированный массив
PrintArray2D(matrix);

