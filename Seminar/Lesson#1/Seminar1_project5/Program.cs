﻿/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/
int number = new int();
Console.WriteLine("Введите трехзначное число");
number = Convert.ToInt32(Console.ReadLine());
if (number>99 && number < 1000)
{
    Console.WriteLine($"Последняя цифра вашего числа = {number%10}");

}
else
{
   Console.WriteLine("Вы ввели НЕ трехзначное число");  
}
/*
Console.WriteLine("введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1000 && x > 99)
{
int two = x / 10;
int result = two % 10;
Console.Write(result);
}
else
Console.WriteLine("ввели не трехзначное число");
*/
