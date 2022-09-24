// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

using static System.Console;
Clear();
WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
int result = 0;
int count = 0;
while(number > 0 && count < 3)
{
    result=number%10;
    number/=10;
    count ++;
}
if(count>2)
{
    WriteLine(result);
}
else
{
    WriteLine("третьей цифры в числе нет");
}

