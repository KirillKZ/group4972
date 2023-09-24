// Задача №37
// Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат 
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21


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

int[] PairsMult(int[] arr)
{
    int[] arrOutput = new int[arr.Length / 2];
    // for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    // {
    //     arrOutput[i] = arr[i] * arr[j];
    // }
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrOutput[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return arrOutput;
}

int[] arr = CreateArray(7, 2, 8);
PrintResult($"{ArrayToString(arr)} -> {ArrayToString(PairsMult(arr))}");