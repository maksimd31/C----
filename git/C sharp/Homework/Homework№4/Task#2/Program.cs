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
/*
int Summma(int numA)
{
    //int summ = numA;
    for(int i = 0; i<numA; i++)
    {
        Console.WriteLine(i);
        numA += numA;
        Console.WriteLine(numA);
    }
    return numA;
}
Console.WriteLine($"Введенное число  = {numA}\nсумма его цифр равняется  = {Summma(numA)}");
*/
/*
foreach (var i in Convert.ToString(numA))
{
    if (i<numA)
    {
        numA += numA;
        i++;
        Console.WriteLine(numA);
        Console.WriteLine(i);
    }
    //Console.Write(c);
    //int i = Convert.ToInt32(c);
    //Console.WriteLine(i);
    //for(i = 1; i<numA; i++)
    {
        //Console.WriteLine(numA);

    }
    
}
*/


