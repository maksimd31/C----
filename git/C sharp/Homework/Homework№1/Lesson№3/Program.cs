﻿Console.WriteLine("Задача 3");
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
Console.WriteLine("Введите число ==> ");
int numb1 = Convert.ToInt32(Console.ReadLine());
//if (numb1%2 == 0) Console.WriteLine("Число является четным: ");
//else Console.WriteLine("Число является не четным");
if(numb1%2 ==0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является не четным");
}
/*{
    Console.WriteLine("Число является четным");
}
else

{
    Console.WriteLine("Число является не четным");
}

Python
x = int(input('Введите число ==> '))
if x%2==0:
    print('Число является четным')
else:
print('Число является не четным')
*/