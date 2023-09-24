// Задача №32 
// Напишите программу замена элементов массива: 
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int [] arr = CreateArray(12, -9, 9);
PrintResult($"{ArrayToString(arr)} -> {ArrayToString(InverseArray(arr))}" );
