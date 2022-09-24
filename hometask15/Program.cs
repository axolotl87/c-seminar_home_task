// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

using static System.Console;

Clear();
Write("Введеите порядковый номер дня недели: ");
int number = Convert.ToInt32(ReadLine());
if(number > 7 || number < 1)
{
    WriteLine("Нет такого дня недели((");
}
else
{
    if(number < 6)
    {
        WriteLine("Нет");
    }
    else
    {
        WriteLine("Да");
    }
}