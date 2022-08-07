Console.WriteLine("Задача №4");
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число ==> ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;
for (; i<num;)
{
    Console.WriteLine($"Четное число N = {i+2}");
    i = (i+2);
}