/*
Задание № 26
Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(num);

for (int i = 0; i < gg.Length; i++)
{
    Console.WriteLine(i);
}