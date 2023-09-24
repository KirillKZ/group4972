// Задача №31 
// Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных 
// элементов массива.
// Например: 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма 
// отрицательных равна -20

void PrintResult(string res)
{
    Console.WriteLine(res);
}

string ArrayToString(int[] arr)
{
    return String.Join(",", arr);
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

(int, int) Summ(int[] arr)
{
    int posSum = 0;
    int negSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            posSum += arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
    return (posSum, negSum);
}
int[] arr = CreateArray(12, -9, 9);
(int pos, int neg) sum = Summ(arr);
PrintResult($"В массиве [{ArrayToString(arr)}] сумма положительных чисел равна {sum.pos}, сумма отрицательных равна  {sum.neg}");