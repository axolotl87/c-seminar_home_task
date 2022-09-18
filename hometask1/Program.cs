//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

using static System.Console;

Clear();
Write("Введеите 2 числa: ");
int num1=Convert.ToInt32(ReadLine());
int num2=int.Parse(ReadLine()!);
if(num1 == num2)
{
    WriteLine($"Введенные вами числа равны");
}
if (num1 > num2)
{
    WriteLine($"Мы сравнили два числа {num1} и {num2} и большим оказалось {num1}");
}
else
{
    WriteLine($"Мы сравнили два числа {num1} и {num2} и большим оказалось {num2}");
}
