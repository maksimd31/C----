/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
//Решение задачи(возведение в степень)
Console.Clear();
Console.WriteLine("Задача 25:\nНапишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int sum = Convert.ToInt32(Math.Pow(numA, numB)); 

Console.WriteLine($"Число А = {numA} в натуральной степени B = {numB}\nРавняется = {sum} ");
//Math.Pow - функция возведение в степень работает изначально только с значениями double!
//Что бы сработало нужно Convert.ToInt32 в int


