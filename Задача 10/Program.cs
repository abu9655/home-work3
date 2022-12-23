//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите номер плоскости : ");
string input = Console.ReadLine();
char[] inputarray = input.ToCharArray();
Array.Reverse(inputarray);
string output = new string(inputarray);

if (output == input)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}