# Домашнее задание #3

# Задача 19
#### Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
+ 14212 -> нет

+ 12821 -> да

+ 23432 -> да

### Решение 
```
Console.WriteLine("Задача №1\nНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите пятизначное число: ");

int numb = Convert.ToInt32(Console.ReadLine());

string ggg = Convert.ToString(numb);

if (ggg[0] == ggg[4])
{
    if (ggg[1] == ggg[3])
    Console.WriteLine($"Число {ggg} является палиндромом");
}
else
{
    Console.WriteLine($"Число {ggg} Не является палиндромом");
}
//Я не понял как решить по другому? как решить математически, плохо знаю математику но палиндромом может не только цифры но и буквы..

```

<img width="1341" alt="Homework#1" src="https://user-images.githubusercontent.com/106627508/184635374-6e5538af-7afe-4e99-962a-39136a3b6070.png">




# Задача 21
#### Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
* A (3,6,8); B (2,1,-7), -> 15.84

* A (7,-5, 0); B (1,-1,9) -> 11.53

### Решение 

```
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
```

<img width="1741" alt="Homework#2" src="https://user-images.githubusercontent.com/106627508/184635403-6127f8ba-8eac-46c6-b006-c1d2f8f5e2ef.png">

# Задание 23 
#### Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
* 3 -> 1, 8, 27

* 5 -> 1, 8, 27, 64, 125

### Решение 
```
Console.WriteLine("Задание №3\nНапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите данные ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++) // Цикл который выполняет действие умножение до того момента пока i не станет равно N
{
    int result = i * i * i;
    if (i == N)
    {
        Console.Write(result);
        break;
    }
    else
    {
        Console.Write(result + ", ");
        //if (result == N)
        //break;
    }
}

```

<img width="1341" alt="Homework#3" src="https://user-images.githubusercontent.com/106627508/184635439-5dcdd5e5-1df8-409b-87a7-085a6a616c57.png">

