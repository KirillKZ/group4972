// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

int[,] Fibonachi2D(int rows, int columns)
{
    int[] arr = new int[rows * columns];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    int[,] mtrx = new int[rows, columns];
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            mtrx[i, j] = arr[count];
            count++;
        }
    }
    return mtrx;
}

void PrintMatrixColor(int[,] matrix, int[] indexes)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == indexes[0] && j == indexes[1])
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.Write(matrix[i, j] + "\t");
                Console.ResetColor();
            }
            else
            {
                System.Console.Write(matrix[i, j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

void CheckAndPrint(int[,] matrix, int number)
{
    if (IfMatrixContainsNumber(matrix, number))
    {
        int[] indexes = IndexOfMatrixElement(matrix, number);
        System.Console.WriteLine($"The index of number in {number} is {ArrayToString(indexes)}");
        PrintMatrixColor(matrix, indexes);
    }
    else
    {
        System.Console.WriteLine("There is no such number in matrix");
    }

}
bool IfMatrixContainsNumber(int[,] matrix, int number)
{
    foreach (int m in matrix)
    {
        if (m == number) return true;
    }
    return false;
}
int[] IndexOfMatrixElement(int[,] matrix, int number)
{
    int[] indexes = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                indexes[0] = i;
                indexes[1] = j;
                return indexes;
            }

        }

    }

    return indexes;
}

string ArrayToString(int[] arr)
{
    return $"[{String.Join(", ", arr)}]";
}


int[,] mtrx = Fibonachi2D(4, 5);
CheckAndPrint(mtrx, 1597);
