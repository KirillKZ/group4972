// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//метод для вывода двумерного массива на экран
void PrintArray2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.Write("{");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.Write(matrix[i, matrix.GetLength(1) - 1] + "");
        System.Console.Write("}");
        System.Console.WriteLine();
    }
}
//метод для заполнения массива спиралью
void CurlInMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int value = 1;
    int startX = 0;
    int startY = 0;
    int endX = n - 1;
    int endY = m - 1;
    while (startX <= endX && startY <= endY)
    {
        for (int i = startY; i <= endY; i++)
        {
            matrix[startX, i] = value++;
        }
        startX++;

        for (int i = startX; i <= endX; i++)
        {
            matrix[i, endY] = value++;
        }
        endY--;

        for (int i = endY; i >= startY; i--)
        {
            matrix[endX, i] = value++;
        }
        endX--;

        for (int i = endX; i >= startX; i--)
        {
            matrix[i, startY] = value++;
        }
        startY++;

    }
}

//создаем массив 4х4
int[,] Curl = new int[10, 10];
//заполняем массив значениями по спирали
CurlInMatrix(Curl);
//выводим массив в терминал
PrintArray2D(Curl);




