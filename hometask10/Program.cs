//Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
using static System.Console;
Clear();
WriteLine("Введите 3хзначное число: ");
string num = ReadLine()!;
if (num.Length == 3)
{
    int number = Convert.ToInt32(num);
    int result = 0;
    while(number > 10)
    {
        result=number%10;
        number/=10;
    }
    WriteLine(result);

}
else
{
    WriteLine($"вы ввели не 3хзначное число");
}
