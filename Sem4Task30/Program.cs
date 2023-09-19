// Задача №30
// Напишите программу, которая выводит массив из 8 
// элементов, заполненный нулями и единицами в 
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
void PrintResult(int[] a)
{
    Console.WriteLine($"[{String.Join(",", a)}]");
}


int[] arr(int N)
{
    int[] arr = new int[N];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(2);
    }
    return arr;

}

int num = ReadData("Введите число:");
int[] a = arr(num);
PrintResult(a);