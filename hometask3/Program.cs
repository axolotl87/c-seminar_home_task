//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

using static System.Console;

Clear();
Write("Введеите число: ");
int num=Convert.ToInt32(ReadLine());
if (num == 0)
{
    WriteLine($"Вы ввели {num}");
}
else
{
    int result = num%2;
    if (result == 0)
    {
        WriteLine($"Это четное число");
    }
    else
    {
        WriteLine($"Это нечетное число"); 
    }
}
