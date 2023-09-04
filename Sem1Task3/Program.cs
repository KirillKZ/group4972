//Задача №3
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
System.Console.WriteLine("Введите день недели:");
int day = int.Parse(Console.ReadLine() ?? "0");
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Четверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "Суббота";
dayOfWeek[6] = "Воскресенье";
if (day >= 0 && day <= 6){
    System.Console.WriteLine(dayOfWeek[day - 1]);
}
else
{
    System.Console.WriteLine("это не день недели");
}

//string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));