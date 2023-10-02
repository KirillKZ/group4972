// ------------------------------------------------------------Задача 56---------------------------------------------------------------
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
//метод для нахождения строки с наименьшей суммой элементов
int LeastSummLine(int[,] matrix)
{
    int leastSumm = 0;
    int lineSummNow = 0;
    int leastSummLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                leastSumm += matrix[i, j];
            }
            else
            {
                lineSummNow += matrix[i, j];
            }
        }
        if (i > 0)
        {
            if (leastSumm > lineSummNow)
            {
                leastSummLine = i;
                leastSumm = lineSummNow;
            }
            lineSummNow = 0;
        }   
    }
    return leastSummLine + 1;
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
//выводим номер строки с наименьшей суммой элементов 
System.Console.Write($"Номер строки с наименьшей суммой элементов - {LeastSummLine(matrix)}");

