// Задача №35
// Задайте одномерный массив из 123 случайных 
// чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В 
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5


void PrintResult(string res)
{
    Console.WriteLine(res);
}

string ArrayToString(int[] arr)
{
    return $"[{String.Join(",", arr)}]";
}
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

int ElmCount(int[] arr, int downBound, int upBound)
{
    int elementCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) elementCount++;
    }
    return elementCount;
}

int[] arr = CreateArray(123, 1, 123);

int elementCount = ElmCount(arr, 10, 99);

PrintResult($"массив {ArrayToString(arr)} -> {elementCount}");