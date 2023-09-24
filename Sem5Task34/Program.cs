// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1

//метод для ввода информации на экран
void PrintResult(string res)
{
    Console.WriteLine(res);
}

//метод для конвертации массива в строковую переменную
string ArrayToString(int[] arr)
{
    return $"[{String.Join(",", arr)}]";
}

//метод для создания массисва с заданной длинной и заполнения его случайными числами с заданным диапазоном
int[] CreateArray(int arrLength, int downBound, int upBound)
{
    int[] arr = new int[arrLength];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(downBound, upBound + 1);
    }
    return arr;
}

//метод для подсчета количество чётных чисел в массиве
int EvenCount(int[] arr)
{
    int elementCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) elementCount++;
    }
    return elementCount;
}
//создаем массив в методе и присваиваем его переменной
int[] arr = CreateArray(10, 100, 999);
//находим количество чётных чисел в найденном массиве и присваиваем его переменной
int elementCount = EvenCount(arr);
//выводим на экран сначала массив, затем количество чётных чисел в массиве
PrintResult($"массив {ArrayToString(arr)} -> {elementCount}");