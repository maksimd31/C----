﻿//Напишите программу которя 
//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите число: ");
int userNamber = Convert.ToInt32(Console.ReadLine());
if (userNamber == 1)//Сравниваем является введеное число 1=1 если является то условие будет выполнено. 
{
Console.WriteLine("Дипазон значений х (0 , +бесконечности), а y (0 , +бесконечности)");
}
else if (userNamber == 2) //else if или сравниваем является введеное число 1=1 если является то условие будет выполнено.
{
Console.WriteLine("Дипазон значений х (0 , +бесконечности), а y (0 , -бесконечности)");
}
else if (userNamber == 3) //else if или сравниваем является введеное число 1=1 если является то условие будет выполнено.
{
Console.WriteLine("Дипазон значений х (0 , -бесконечности), а y (0 , -бесконечности)");
}
else if (userNamber == 4) //else if или сравниваем является введеное число 1=1 если является то условие будет выполнено.
{
Console.WriteLine("Дипазон значений х (0 , -бесконечности), а y (0 , +бесконечности)");
}
else //Если условие if не выполняется то выполнится else 
{ //Условие будет выполнятся если ввод цифр выйдет за 1-4 
Console.WriteLine("Такой четверти не существует");
}
