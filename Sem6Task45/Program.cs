// Задача №45
// Напишите программу, которая будет создавать 
// копию заданного одномерного массива с помощью 
// поэлементного копирования.


void PrintResult(string res)
{
    Console.WriteLine(res);
}

//метод для конвертации массива в строковую переменную
string ArrayToString(int[] arr)
{
    return $"[{String.Join(", ", arr)}]";
}

//метод для создания массива с заданной длинной и заполнения его случайными числами с заданным диапазоном
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

int[] CopyArr(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

//создаем массив в методе и присваиваем его переменной
int[] arr = CreateArray(11, 1, 98);
//выводим на экран исходный массив
PrintResult($"исходный массив {ArrayToString(arr)}");
//выводим на экран копию массива
PrintResult($"копия массива {ArrayToString(CopyArr(arr))}");