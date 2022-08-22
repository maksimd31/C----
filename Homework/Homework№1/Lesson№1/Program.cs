Console.WriteLine("Задание №1");
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдает наибольшнее, а какое меньшее. ");

Console.WriteLine("Введем первое число ==> ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введем виторое число ==> ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if (numb1>numb2)
{
    Console.WriteLine($"Число {numb1} Больше Числа {numb2}");
}
else
{
    Console.WriteLine($"Число {numb1} меньше числа {numb2}");

}