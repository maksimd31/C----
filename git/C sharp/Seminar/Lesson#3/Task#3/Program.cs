/*Задача 18: Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат точек в этой четверти (x и y)*/
Console.WriteLine("Введите номер четверти");
int chetvert = Convert.ToInt32(Console.ReadLine());
switch (chetvert)
{
case 1:
{
Console.WriteLine("X+, Y+");
break;
}
case 2:
{
Console.WriteLine("-X, Y+");
break;
}
case 3:
{
Console.WriteLine("-X, -Y");
break;
}
case 4:
{
Console.WriteLine("X+, -Y");
break;
}
default:
{
Console.WriteLine("Таких значений нет");
break;
}
}
//Решение супер понятное