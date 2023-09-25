// Задача №39 
// Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на 
// первом месте, а первый - на последнем и т.д.)
// Например: 
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6] 
// Комментарий: эту задачу можно решить 2 способами: 1) 
// менять числа местами в исходном массиве; 2) создать 
// новый массив и в него записать перевёрнутый исходный 
// массив по элементам.

void PrintResult(string res)
{
    Console.WriteLine(res);
}

//метод для конвертации массива в строковую переменную
string ArrayToString(int[] arr)
{
    return $"[{String.Join(", ", arr)}]";
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
//метод переворачивающий массив в том же массиве
int[] SwapSameArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = temp;
    }
    return arr;
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
    {
       outArr[i] = arr[arr.Length - 1- i];
    }
    return outArr;
}

//создаем массив в методе и присваиваем его переменной
int[] arr = CreateArray(11, 1, 98);
//выводим на экран исходный массив
PrintResult($"исходный массив {ArrayToString(arr)}");
//выводим на экран перевернутый массив
PrintResult($"перевернутый массив {ArrayToString(SwapSameArray(arr))}");
//выводим на экран еще раз перевернутый массив с помощью другого метода
PrintResult($"еще раз перевернутый массив {ArrayToString(SwapNewArray(arr))}");