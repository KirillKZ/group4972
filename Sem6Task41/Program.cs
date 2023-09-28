// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


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
    return $"[{String.Join(", ", arr)}]";
}

int[] InputArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadData("Введите элемент массива:");
    }
    return arr;
}
int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;

}

int length = ReadData("Введите длину массива:");
int[] arr = InputArray(length);
int countPositive = CountPositiveNumbers(arr);
PrintResult($"{ArrayToString(arr)} -> {countPositive}");