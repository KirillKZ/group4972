// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
void PrintResult(string strRes)
{
    Console.WriteLine(strRes);
}

int Exponentiation(int baza, int pow)
{
    int res = baza;
    for (int i = 1; i < pow; i++)
    {
        res *= baza;
    }
    return res;
}

int baza = ReadData("Введите основание степени:");
int pow = ReadData("Введите показатель степени:");
int result = Exponentiation(baza, pow);
PrintResult($"{baza} в степени {pow} = {result}");