// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

using static System.Console;

Clear();
Write("Введеите число: ");
int num=Convert.ToInt32(ReadLine());

int count = 1;
while(count < num)
{
    if (count%2 == 0)
    {
        WriteLine($"{count}");
    }
    count++;
}
