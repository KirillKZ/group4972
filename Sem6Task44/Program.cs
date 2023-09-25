// Задача №44
// Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3 
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8


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

string FibNum(int num)

{
    string res = "0 1 ";
    int temp1 = 0;
    int temp2 = 1;
    int sum = 0;
    if (num >= 3)
    {
        for (int i = 2; i < num; i++)
        {
            sum = temp1 + temp2;
            res += sum + " ";
            temp1 = temp2;
            temp2 = sum;
        }
        return res;
    }
    else if (num == 1) return "0";
    else if (num == 2) return res;
    else return "введите другое число";

}

int num = ReadData("Введите цифру: ");
PrintResult(FibNum(num));
