//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int i= Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 0;
int c = 1;
while (a<=i)
{
    b=c*c*c;
    Console.WriteLine(b);
    c++;
    a++;
}