// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

//решение основной задачи

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// void PrintResult(string strRes)
// {
//     Console.WriteLine(strRes);
// }

// int Exponentiation(int baza, int pow)
// {
//     int res = baza;
//     for (int i = 1; i < pow; i++)
//     {
//         res *= baza;
//     }
//     return res;
// }

// int baza = ReadData("Введите основание степени:");
// int pow = ReadData("Введите показатель степени:");
// int result = Exponentiation(baza, pow);
// PrintResult($"{baza} в степени {pow} = {result}");



//решение со звездочкой

//метод для считывания чисел
double ReadDataNum(string msg)
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}
//метод для считывания оператора
string ReadDataSign(string msg)
{
    Console.WriteLine(msg);
    string str = Console.ReadLine() ?? "0";
    return str;
}
//метод для выведения результата на экран
void PrintResult(string strRes)
{
    Console.WriteLine(strRes);
}
//метод для возведения числа в степень
double Exponentiation(double baza, double pow)
{
    return Math.Pow(baza, pow);
}
//метод для умножения чисел
double Multiplication(double A, double B)
{
    return A * B;
}
//метод для деления чисел
double Division(double A, double B)
{
    return A / B;
}
//метод для сложения чисел
double Addition(double A, double B)
{
    return A + B;
}
//метод для вычитания чисел
double Subtraction(double A, double B)
{
    return A - B;
}
//метод для выбора действия в зависимости от введенного знака
double Operating(double A, string sign, double B)
{
    switch (sign)
    {
        case "^":
            return Exponentiation(A, B);

        case "*":
            return Multiplication(A, B);

        case "/":
            return Division(A, B);

        case "+":
            return Addition(A, B);

        case "-":
            return Subtraction(A, B);
        default: return -1;


    }
}


//получаем первое число
double numA = ReadDataNum("Введите первое число: ");
//получаем знак оператора
string sign = ReadDataSign("Введите '+' для сложения, '-' для вычитания, '*' для умножения, '/' для деления, '^' для возведения в степень");
//получаем второе число
double numB = ReadDataNum("Введите второе число: ");
//производим необходимое вычисление
double result = Operating(numA, sign, numB);
//пишем результат на экране
PrintResult($"{numA} {sign} {numB} = {result}");