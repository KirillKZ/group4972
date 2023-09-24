// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

//метод для ввода информации на экран
void PrintResult(string res)
{
    Console.WriteLine(res);
}

//метод для конвертации массива в строковую переменную
string ArrayToString(double[] arr)
{
    return $"[{String.Join("  ", arr)}]";
}

//метод для создания массисва с заданной длинной и заполнения его случайными числами с заданным диапазоном
double[] CreateArray(int arrLength, int downBound, int upBound)
{
    double[] arr = new double[arrLength];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.Next(downBound, upBound) + rnd.NextDouble(), 2);
    }
    return arr;
}
//метод для нахождения разницы между максимальным и минимальным элементами массива
double DiffMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    return max - min;
}
//создаем переменную и инициализируем ее результатом вызова метода для создания массива
double[] arr = CreateArray(10, 0, 78);
//находим разницу между максимальным и минимальным элементами массива
double res = DiffMinMax(arr);
//вывожим на экран результат
PrintResult($"Массив {ArrayToString(arr)} -> разницу между максимальным и минимальным элементами массива = {Math.Round(res, 2)}");