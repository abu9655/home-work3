//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Введи цифру, что-бы узнать какие дни нидели выходные:");
int dayNumber = Convert.ToInt32(Console.ReadLine());


if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("да этот ден нидели выходной");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("это вообще не день недели");
}
else Console.WriteLine("нет этот ден нидели не выходной");