/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Задание №2\nНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите х1 ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите у1 ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите х2 ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите у2 ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());


double sum = Math.Sqrt(Math.Pow((x2-x1), 2)+ Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));
sum = Math.Round(sum, 2);
Console.WriteLine(sum);
/*
Math.Sqrt() – математическая функция которая извлекает квадратный корень. В аргументных скобках указывается значение числа, из которого нужно извлечь квадратный корень.

Math.Pow() – возведения числа в степень. В аргументных скобках через запятую указываются два аргумента (1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).
*/