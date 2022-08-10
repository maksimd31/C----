//я считаю это решение не правельным 
Console.WriteLine("Задание №1 v 2");
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывакет вторую цифру этого числа.");
int number = new Random().Next(100,999);
Console.WriteLine($"===> {number}");
int itogo = number % 100;
Console.WriteLine($"===> {itogo}");
int itogo2 = itogo/10;
Console.WriteLine($"Вторая цыфра числа ==> {itogo2}");
