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
    for(int i=1; i < arr.Length; i++)
            {
                int k = arr[i];
                int j = i - 1;

                while(j>=0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = k;
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