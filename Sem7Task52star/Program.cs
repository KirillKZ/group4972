// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом

//--------------------------------------------------------------------Тело программы-------------------------------------------------------------
//вводим размерность массива
int rows = ReadData("Введите колчество строк:");
int columns = ReadData("Введите колчество столбцов:");
//создаем переменную типа двумерный массив и присваиваем ей ссылку на созданный в методе массив
int[,] matrix = Create2DArray(rows, columns, 10, 99);
//выводим на экран массив и результаты вычисления средней арифметической по диагоналям
FindDiagonalAvrgAndPrinResult(PrintColorDiagonals(matrix));

//------------------------------------------------------------------Методы-----------------------------------------------------------------------

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//создаем и заполняем двумерный массив случайными числами из назначенного диапазаона (для красоты все двухзначные)
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
//Находим значения диагоналей, раскрашиваем и выводим на экран, одновременно с этим создаем двумерный массив со значениями диагоналей.
//тут происходит поворот двумерного массива на 90 градусов протиы часовой стрелки (сама по себе интересная задачка).
//Это делается для того, чтобы потом вывести в ряд значение диагоналей, так как при большой матрице цвета диагоналей повторяются 
//и не совсем ясно к какой диагонале относится средняя арифметическая окрашенная в цвет диагонали
int[,] PrintColorDiagonals(int[,] matrix)
{
    int[,] diagNums = new int[matrix.GetLength(0) + (matrix.GetLength(1) - 1), matrix.GetLength(1)];

    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (x - y >= 0) diagNums[x - y, y] = matrix[x, y];
            else diagNums[diagNums.GetLength(0) + (x - y), y] = matrix[x, y];

            SetColor(matrix, x, y);
        }
        System.Console.WriteLine();
    }

    return diagNums;
}
//находим среднюю арифметическую по диагоналям
void FindDiagonalAvrgAndPrinResult(int[,] matrix)
{

    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        string str = "";
        int sum = 0;
        int count = 0;
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            if (matrix[x, y] > 0)
            {
                str += " - " + matrix[x, y];
                sum += matrix[x, y];
                count++;
            }

        }
        System.Console.WriteLine($"The average in diagonal{str} are: {Math.Round((double)sum / (double)count, 2)}");


    }
}
//метод для выбора цвета и печати цифры из массива в выбраном цвете. 
//Выбор цвета зависит от того, на сколько и в какую сторону от нуля отклоняются разница индексов опеределенной ячейки.
void SetColor(int[,] matrix, int x, int y)
{
    int i = 0;
    int d = 0;
    ConsoleColor[] colors = new ConsoleColor[]
       {ConsoleColor.White,
         ConsoleColor.DarkGreen,
         ConsoleColor.Blue,
         ConsoleColor.Cyan,
         ConsoleColor.DarkBlue,
         ConsoleColor.DarkMagenta,
         ConsoleColor.DarkRed,
         ConsoleColor.DarkYellow,
         ConsoleColor.Gray,
         ConsoleColor.Green,
         ConsoleColor.Red};
    if ((11 + i) + (x - y) <= 0) i += 10;
    if (x - y < 0) Console.ForegroundColor = colors[(11 + i) + (x - y)];

    if ((x - y) - d >= 10) d += 10;
    if (x - y >= 0) Console.ForegroundColor = colors[(x - y) - d];

    System.Console.Write(matrix[x, y] + " ");
    Console.ResetColor();

}


