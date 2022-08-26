# Homework-C

# Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
## Например
### a = 5; b = 7 -> max = 7
### a = 2 b = 10 -> max = 10
### a = -9 b = -3 -> max = -3
```
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
```
<img width="1324" alt="Homework#1" src="https://user-images.githubusercontent.com/106627508/183252756-3c0c3e51-2fbc-4b59-8150-1231322645ec.png">

# Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
## Например

### 2, 3, 7 -> 7
### 44 5 78 -> 78
### 22 3 9 -> 22
```
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
if (numb2 > max) max = numb2;
if (numb3 > max) max = numb3;
Console.WriteLine($"Максимальное число = {max} ");

//int numbers = {numb2,numb2,numb3};
//int Max = numbers.Max();
//Console.WriteLine($"Максимальное число = {Max} ");
```
<img width="1325" alt="Homework#2" src="https://user-images.githubusercontent.com/106627508/183252764-891ea71f-f850-4744-aeda-9e40d6f7fc69.png">

# Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
## Например

### 4 -> да
### -3 -> нет
### 7 -> нет

```
Console.WriteLine("Задача 3");
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
Console.WriteLine("Введите число ==> ");
int numb1 = Convert.ToInt32(Console.ReadLine());
//if (numb1%2 == 0) Console.WriteLine("Число является четным: ");
//else Console.WriteLine("Число является не четным");
if (numb1 % 2 == 0)
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
```
<img width="1321" alt="Homework#3" src="https://user-images.githubusercontent.com/106627508/183252769-e8e0a52c-7bd9-40b9-8196-db20eae8e8b8.png">

# Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
## Например

### 5 -> 2, 4
### 8 -> 2, 4, 6, 8
```
Console.WriteLine("Задача №8");
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число ==> ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;
for (; i < num;)
{
    Console.WriteLine($"Четное число N = {i + 2}");
    i = (i + 2);
}
```
<img width="1319" alt="Homework#4" src="https://user-images.githubusercontent.com/106627508/183252774-20ffef12-bcff-42cf-8961-38be22ff12bb.png">
