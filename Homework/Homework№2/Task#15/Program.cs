
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Задача №3\nНапишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
//for (int i = 0; i<7; i++); Не понимаю как запустить 7 раз ?
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("Будний день - Понедельник");
        break;
    case 2:
        Console.WriteLine("Будний день - Вторник");
        break;
    case 3:
        Console.WriteLine("Будний день - Среда");
        break;
    case 4:
        Console.WriteLine("Будний день - Четверг");
        break;
    case 5:
        Console.WriteLine("Будний день - Пятница");
        break;
    case 6:
        Console.WriteLine("Ура выходной - Суббота");
        break;
    case 7:
        Console.WriteLine("Ура выходной - Воскресенье");
        break;
}
