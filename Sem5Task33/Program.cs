// Задача №33 
// Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в 
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет 
// -3; массив [6, 7, 19, 345, 3] -> да

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
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

int FindElm(int[] arr, int num)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return i;
    }
    return -1;
}

int[] arr = CreateArray(12, 1, 6);
int element = ReadData("Введите число:");
int index = FindElm(arr, element);
string isExist = (index >= 0) ? "да" : "нет";
PrintResult($"{element}; массив {ArrayToString(arr)} -> {isExist}");
