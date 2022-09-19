//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
// из этих чисел.

using static System.Console;

Clear();
Write("Введеите 3 числa: ");
int num1=Convert.ToInt32(ReadLine());
int num2=int.Parse(ReadLine()!);
int num3=Convert.ToInt32(ReadLine());
int max = 0;
if(num1 > num2)
{
    max = num1;
    if (num3 > max)
    {
        max = num3;
        WriteLine($"Мы сравнили три числа {num1}, {num2} и {num3} и большим оказалось {max}");
    }
    else
    {
        WriteLine($"Мы сравнили три числа {num1}, {num2} и {num3} и большим оказалось {max}");
    }
}
if (num1 == num2)
{
    if (num1 > num3)
    {
        max = num1;
        WriteLine($"Мы сравнили три числа {num1}, {num2} и {num3} и большим оказалось {max}");
    }
    else
    {
        max = num3;
        WriteLine($"Мы сравнили три числа {num1}, {num2} и {num3} и большим оказалось {max}");
    }
}
if (num1 < num2)
{
    max = num2;
    if(max > num3)
    {
        WriteLine($"Мы сравнили три числа {num1}, {num2} и {num3} и большим оказалось {max}");
    }
    else
    {
        max = num3;
        WriteLine($"Мы сравнили три числа {num1}, {num2} и {num3} и большим оказалось {max}");
    }
}
