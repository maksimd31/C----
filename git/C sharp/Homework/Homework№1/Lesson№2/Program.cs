Console.WriteLine("Задание №2");
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. ");

Console.WriteLine("Введем первое число ==> ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введем второе число ==> ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введем третье число ==> ");
int numb3 = Convert.ToInt32(Console.ReadLine());

int max = numb1;
//if (numb1>max)max = numb1;
if (numb2>max)max = numb2;
if (numb3>max)max = numb3;
Console.WriteLine($"Максимальное число = {max} ");

//int numbers = {numb2,numb2,numb3};
//int Max = numbers.Max();
//Console.WriteLine($"Максимальное число = {Max} ");
