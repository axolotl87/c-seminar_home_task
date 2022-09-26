// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

using static System.Console;

Clear();
Write("Введите 5-значное число:");
int number = Convert.ToInt32(ReadLine());
if (number/10000 < 1 || number/10000 > 10) WriteLine("Вы ввели не 5значное число");
else
{
    if(number/10000 == number%10 && (number/1000)%10 == (number%100)/10)
    {
        WriteLine("это палиндром");
    }
    else WriteLine("это не палиндром");
}
