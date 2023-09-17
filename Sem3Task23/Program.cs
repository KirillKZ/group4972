// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.1
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом
void ShowCube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        System.Console.WriteLine(Math.Pow(i, 3));
    }

}

string BuildLine(int num, int pow)
{
    string strResult = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        strResult = strResult + Math.Pow(i, pow) + "\t|";
    }
    return strResult;
}
ShowCube(5);
System.Console.WriteLine(BuildLine(15, 1));
System.Console.WriteLine(BuildLine(15, 2));
System.Console.WriteLine(BuildLine(15, 3));
//System.Console.WriteLine("1" +"\t" + "|" + "2");

//System.Console.WriteLine("12434" +"\t" + "|" + "23455");