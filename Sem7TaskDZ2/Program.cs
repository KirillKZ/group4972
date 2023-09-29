// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся 
// на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - позиции элемента в матрице. 
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной 
// позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в 
// матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя 
// результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] arr2D = new int[n, m];
    int sum = 1;
    arr2D[0, 0] = sum;
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


        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");

        }
        System.Console.WriteLine();

    }

}

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int[] arr = new int[2];
    if (rowPosition < matrix.GetLength(0) && columnPosition < matrix.GetLength(1))
    {
        arr[0] = matrix[rowPosition - 1, columnPosition - 1];
        arr[1] = 0;
    }
    else
    {
        arr[0] = 0;
        arr[1] = 0;
    }
    return arr;
}

void PrintCheckIfError(int[] results, int X, int Y)
{
    if (results[0] > 0)
    {
        System.Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }
    else
    {
        System.Console.WriteLine("There is no such index");
    }
}

int n = 3;
int m = 4;
int k = 2;
int x = 8;
int y = 3;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

n = 4;
m = 5;
k = 3;
x = 2;
y = 2;

result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);


