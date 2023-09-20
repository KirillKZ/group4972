// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов


//решение со звездочкой

//метод для считывания чисел
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//метод для выведения результата на экран
void PrintResult(int[] a)
{
    Console.WriteLine($"[{String.Join(",", a)}]");
}

//метод для созание массива требуемого размера и заполнения его цифрами из указанного диапазона
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
//получаем размер массива
int arrLength = ReadData("Введите длину массива:");
//получаем минимальное значение диапазона
int fromRange = ReadData("Задайте начальную цифру диапазона значений (включительно):");
//получаем максимально значение диапазона
int toRange = ReadData("Задайте конечную цифру диапазона значений (включительно):");
//вызываем метод для создания и заполнения массива
int[] a = array(arrLength, fromRange, toRange);
//выводим результа на экран
PrintResult(a);