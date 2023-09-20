// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

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


int[] array(int arrLength, int fromRange, int toRange)
{
    int[] arr = new int[arrLength];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(fromRange, toRange + 1);
    }
    return arr;

}

int arrLength = ReadData("Введите длину массива:");
int fromRange = ReadData("Задайте начальную цифру диапазона значений:");
int toRange = ReadData("Задайте конечную цифру диапазона значений:");
int[] a = array(arrLength, fromRange, toRange);
PrintResult(a);