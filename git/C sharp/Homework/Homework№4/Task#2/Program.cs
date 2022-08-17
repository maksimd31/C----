/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

//Решение задачи(возведение в степень)
Console.Clear();
Console.WriteLine("Задача 27:\nНапишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.Write("Введите число: ==> ");
int numA = Convert.ToInt32(Console.ReadLine());

int tSumm(int numA)
{
    int s = 0;
    while (numA > 0) //
    {
        s = s + numA % 10;//
        numA = numA /10 ;
    }
    return s;
}
Console.WriteLine($"Сумма цифр {numA}\nРавна = {tSumm(numA)}");


