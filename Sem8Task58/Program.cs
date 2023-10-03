// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
//метод для проверки условия умножаемости матриц (количество столбцов первой матрицы должно быть равно количеству строк второй матрицы)
bool IsMatrixesFit(int[,] mtr1, int[,] mtr2)
{
    if (mtr1.GetLength(1) == mtr2.GetLength(0)) return true;
    else return false;
}
//метод для умножения матриц
int[,] MultiplyMatrixes(int[,] mtr1, int[,] mtr2)
{
    int[,] multMatrix = new int[mtr1.GetLength(0), mtr2.GetLength(1)];
    
    for (int i = 0; i < mtr1.GetLength(0); i++)
    {
        for (int j = 0; j < mtr2.GetLength(1); j++)
        {
            multMatrix[i, j] = 0;

            for (var k = 0; k < mtr1.GetLength(1); k++)
            {
                multMatrix[i, j] += mtr1[i, k] * mtr2[k, j];
            }
        }
    }
    return multMatrix;
}
//выводим напоминание о необходимых параметрах матриц
System.Console.WriteLine("Внимание! Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
//вводим размерность матриц
int rowsMtr1 = ReadData("Введите количество строк для первой матрицы: ");
int colMtr1 = ReadData("Введите количество колонок для первой матрицы: ");
int rowsMtr2 = ReadData("Введите количество строк для второй матрицы: ");
int colMtr2 = ReadData("Введите количество колонок для второй матрицы: ");
//создаем матрицы по введенным параметрам
int[,] mtr1 = Create2DArray(rowsMtr1, colMtr1, 1, 9);
int[,] mtr2 = Create2DArray(rowsMtr2, colMtr2, 1, 9);
//выводим в консоль умножаемые матрицы
System.Console.WriteLine("Матрица 1:");
PrintArray2D(mtr1);
System.Console.WriteLine("Матрица 2:");
PrintArray2D(mtr2);

System.Console.WriteLine("Результирующая матрица:");
//проверяем соответствуют ли матрицы критерию умножаемости, если да, то умножаем матрицы и выводим в консоль резутат умножения, если нет - то пишем что умножение невозможно
if (IsMatrixesFit(mtr1, mtr2))
{
    int[,] resMatrix = MultiplyMatrixes(mtr1, mtr2);
    PrintArray2D(resMatrix);
}
else
{
    System.Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы. Умножение матриц невозможно! Введите другие параметры матриц.");
}
