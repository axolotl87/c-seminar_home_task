// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;

Clear();
WriteLine("Введите координату Х первой точки:");
int ax = Convert.ToInt32(ReadLine());
WriteLine("Введите координату Y первой точки:");
int ay = Convert.ToInt32(ReadLine());
WriteLine("Введите координату Z первой точки:");
int az = Convert.ToInt32(ReadLine());
WriteLine("Введите координату Х второй точки:");
int bx = Convert.ToInt32(ReadLine());
WriteLine("Введите координату Y второй точки:");
int by = Convert.ToInt32(ReadLine());
WriteLine("Введите координату Z второй точки:");
int bz = Convert.ToInt32(ReadLine()); 

double distance = Math.Sqrt(Math.Pow((ax-bx), 2)+Math.Pow((ay-by), 2)+Math.Pow((az-bz), 2));

WriteLine($"Расстояние между точками А ({ax},{ay},{az}) и B ({bx},{by},{bz}) составялет: {distance}");