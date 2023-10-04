// Задача 65.
// Задайте значения М и N.
// Напишите программу, которая найдет все натуральные элементы в промежутке от M до N.




int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string RecMN(int m, int n)
{
    string res = String.Empty;
    
    if (m >= n)
    {
        return res + m;
    }
    else
    {
      return res+=  m + " " + RecMN(m + 1, n) ;
    }



}

int m = ReadData("Введите число M ");
int n = ReadData("Введите число N ");
System.Console.WriteLine(RecMN(m, n));