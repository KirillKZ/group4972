// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1

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

int EvenCount(int[] arr)
{
    int elementCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) elementCount++;
    }
    return elementCount;
}

int[] arr = CreateArray(10, 100, 999);

int elementCount = EvenCount(arr);

PrintResult($"массив {ArrayToString(arr)} -> {elementCount}");