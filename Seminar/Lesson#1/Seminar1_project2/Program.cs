/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли втрое число квадратом первого.
a = 5; b = 25 -> да 
a = 2 b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3 b = 9 -> да
*/
//Обявление типа переменых 
int userNumberFirst = new int();
int userNumberSecond = new int();
//Консоль ввода 
Console.WriteLine("Введите первое число: ");
userNumberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
userNumberSecond = Convert.ToInt32(Console.ReadLine());
//Условие if (первое число возводим в степень и сравниваем с вторым )
if(userNumberFirst * userNumberFirst == userNumberSecond)
{
    Console.WriteLine($"Число {userNumberSecond} является квадратом числа {userNumberFirst}");
}
else
{
    Console.WriteLine($"Число {userNumberSecond} не является квадратом числа {userNumberFirst}");
}