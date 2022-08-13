/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Задание №2\nНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите х1 ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите у1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х2 ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите у2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());


double sum = Math.Sqrt((x2-x1)+(y2-y1)(z2-z1));
sum = Math.Round(sum, 2);
Console.WriteLine(sum);
