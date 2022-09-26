// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

using static System.Console;

Clear();
WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);
if(number<1) WriteLine("вы ввели некорректное число");
WriteLine();
for (int i = 1; i <= number; i++)
{
    double cube = Math.Pow(i, 3);
    Write($"{cube}, ");
}