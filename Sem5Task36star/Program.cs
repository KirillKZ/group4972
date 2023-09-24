// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// (со звездочкой) Найдите все пары в массиве и выведите пользователю


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
//метод для конвертации словаря в строковую переменную
string DictToString(Dictionary<string, string> pairs)
{
    string str = "";
    foreach (var pair in pairs)
    {
        str += $"пара: {pair.Value}  индексы: {pair.Key} \n";
    }
    return str;

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

//метод для нахождения всех пар в массиве 
Dictionary<string, string> PairsDict(int[] arr)
{
    Dictionary<string, string> pairs = new Dictionary<string, string>();
    List<int> index = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                if (!index.Contains(i))
                {
                    pairs.Add($"{i}, {j}", $"{arr[i]} - {arr[j]}");
                    index.Add(i);
                    index.Add(j);
                    break;
                }

            }

        }

    }
    return pairs;
}
//создаем массив в методе и присваиваем его переменной
int[] arr = CreateArray(20, 1, 6);
//создаем переменную типа словарь и присваиваем ей результат метода
Dictionary<string, string> pairs = PairsDict(arr);
//выводим на экран результат
PrintResult($"массив {ArrayToString(arr)} \nнайденные пары:\n{DictToString(pairs)}");