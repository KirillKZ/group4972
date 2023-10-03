// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//--------------------------------------------------------------РЕШЕНИЕ-----------------------------------------------------------------
//метод для получения данных от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод для создания трехмерного массива и заполнения его случайными числами в заданном диапазоне
int[,,] Create3DArray(int rows, int columns, int deep, int downLimit, int upLimit)
{
    int[,,] cube = new int[rows, columns, deep];
    int count = downLimit;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                cube[i, j, k] = count;
                count++;
            }
        }
    }
    return cube;
}
//метод для вывода трехмерного массива на экран построчно (если представлять массив как стопку матриц, то сначала выводится содержимое 1-ой матрицы построчно, затем 2-ой и так далее )
void PrintArray3DLineByLine(int[,,] cube)
{
    for (int k = 0; k < cube.GetLength(2); k++)
    {
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                System.Console.Write($"{cube[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
//метод для проверки того, что объем массива не превышает количество уникальных двузначных чисел
bool isVolumeCubeLessThenTwoDigitNums(int rows, int columns, int deep)
{
    if (rows * columns * deep < 99) return true;
    else return false;
}

//переменная для определения кол-ва строк в массиве (получаем от пользователя)
int rows = ReadData("Введите количество строк:");
//переменная для определения кол-ва столбцов в массиве (получаем от пользователя)
int columns = ReadData("Введите количество столбцов:");
//переменная для определения кол-ва столбцов в массиве (получаем от пользователя)
int deep = ReadData("Введите количество матриц:");
//проверяем достаточно ли двузначных цифр  для заполнения массива и если достаточно, то создаем трехмерный массив в методе с установленными параметрами (если цифр недостаточно - то выводится предупреждение)
if (isVolumeCubeLessThenTwoDigitNums(rows, columns, deep))
{
    int[,,] cube = Create3DArray(rows, columns, deep, 10, 99);
    PrintArray3DLineByLine(cube);
}
else
{
    System.Console.Write("Объем массива превышает количество уникальных двузначных чисел! Задайте другие параметры массива.");
}