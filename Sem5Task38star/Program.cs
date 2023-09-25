// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. Для задачи со звездочкой использовать заполнение массива целыми числами.

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

//метод для создания массива с заданной длинной и заполнения его случайными числами с заданным диапазоном
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
//находим разницу между первым и последним элементом массива
int DiffMinMax(int[] arr)
{
    return arr[arr.Length - 1] - arr[0];
}
//сортируем массив методом вставки
int[] InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int k = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = k;
    }

    return arr;
}
//обратная сортировка массиа подсчетом для произвольного целочисленного диапазона
int[] CountingSort(int[] arr)
{   //поиск минимального и максимального значения
    int min = arr[0];
    int max = arr[0];
    foreach (int element in arr)
    {
        if (element > max) max = element;
        else if (element < min) min = element;
    }
    //корректировка максимального значения, если минимальное значение отлично от 0
    int correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;
    //создание вспомогательного массива, в котором считается вхождение элементов главного массива
    int[] count = new int[max + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] + correctionFactor]++;

    }
    //восстанавливаем исходный массив в порядке убывания
    int index = 0;
    //for (int i = 0; i < count.Length; i++) - для востановления в порядке возрастания
    for (int i = count.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < count[i]; j++)
        {
            arr[index] = i - correctionFactor;
            index++;
        }
    }
    return arr;
}

//создаем массив в методе и присваиваем его переменной
int[] arr = CreateArray(10, 100, 999);
//выводим на экран исходный массив
PrintResult($"исходный массив {ArrayToString(arr)}");
//сортируем массив методом вставки
int diff = DiffMinMax(InsertionSort(arr));
//выводим на экран сначала массив, затем количество чётных чисел в массиве
PrintResult($"отсортированный массив {ArrayToString(arr)} разница между первым и последним элементом {diff}");
PrintResult($"отсортированный в порядке убывания массив {ArrayToString(CountingSort(arr))}");