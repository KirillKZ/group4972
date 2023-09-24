// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0


//метод для ввода информации на экран
void PrintResult(string res)
{
    Console.WriteLine(res);
}

//метод для конвертации массива в строковую переменную
string ArrayToString(int[] arr)
{
    return $"[{String.Join(",", arr)}]";
}

//метод для создания массисва с заданной длинной и заполнения его случайными числами с заданным диапазоном
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

//метод для подсчета суммы элементов, стоящих на нечётных позициях
int OddElementSum(int[] arr)
{
    int oddElementSum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        oddElementSum += arr[i];
    }
    return oddElementSum;
}
//создаем массив в методе и присваиваем его переменной
int[] arr = CreateArray(6, 1, 6);
//находим количество чётных чисел в найденном массиве и присваиваем его переменной
int oddElementSum = OddElementSum(arr);
//выводим на экран сначала массив, затем сумму элементов, стоящих на нечётных позициях
PrintResult($"массив {ArrayToString(arr)} сумма элементов, стоящих на нечётных позициях  = {oddElementSum}");