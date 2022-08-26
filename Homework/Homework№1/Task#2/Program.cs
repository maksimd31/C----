// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Задание №1");
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдает наибольшее, а какое меньшее. ");

Console.WriteLine("Введем первое число ==> ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введем второе число ==> ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if (numb1 > numb2)
{
    Console.WriteLine($"Число {numb1} Больше Числа {numb2}");
}
else
{
    Console.WriteLine($"Число {numb1} меньше числа {numb2}");

}