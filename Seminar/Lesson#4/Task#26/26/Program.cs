/*
Задание 26
Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5


*/

int HowMuchIsTheDigits(int number) //метод 
{
    int digitCounter = 0; //счетчик 
    while (number != 0) //цикл Сравнивает два операнда и возвращает true, если операнды не равны, и false, если они равны.
    {
        number = number / 10;//вводную цифру делим на 10 
        digitCounter++; // +1 к переменной 
        //Console.WriteLine(number);
        //Console.WriteLine(digitCounter);
    }
    return digitCounter;
}


Console.WriteLine("Введите число");

int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"Количество цифр в числе {number} = {HowMuchIsTheDigits(number)}");
