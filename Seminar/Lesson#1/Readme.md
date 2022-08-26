# Урок 1. Знакомство с языком программирования С#
## Задание №1 
```
/*
 Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя)
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

int userNumber = new int(); //тип/переменная/присваивает к userNumber значение int

Console.WriteLine("Введите число: ");

userNumber = Convert.ToInt32(Console.ReadLine());

int result = (userNumber * userNumber);

Console.WriteLine($"Квадрат числа {userNumber} = {result}");
// или 
```
## Задание №2 
```
/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли втрое число квадратом первого.
a = 5; b = 25 -> да 
a = 2 b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3 b = 9 -> да
*/
//Объявление типа переменных 
int userNumberFirst = new int();
int userNumberSecond = new int();
//Консоль ввода 
Console.WriteLine("Введите первое число: ");
userNumberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
userNumberSecond = Convert.ToInt32(Console.ReadLine());
//Условие if (первое число возводим в степень и сравниваем с вторым )
if (userNumberFirst * userNumberFirst == userNumberSecond)
{
    Console.WriteLine($"Число {userNumberSecond} является квадратом числа {userNumberFirst}");
}
else
{
    Console.WriteLine($"Число {userNumberSecond} не является квадратом числа {userNumberFirst}");
}
```
## Задание №3

```
/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница
*/

int dayNumber = new int();
Console.WriteLine("Введите номер дня недели");
dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1)
{
    Console.WriteLine("Первый день недели - это понедельник");
}

else if (dayNumber == 2)
{
    Console.WriteLine("Второй день недели - это вторник");
}

else if (dayNumber == 3)
{
    Console.WriteLine("Третий день недели - это среда");
}

else if (dayNumber == 4)
{
    Console.WriteLine("Четвертый день недели - это четверг");
}

else if (dayNumber == 5)
{
    Console.WriteLine("Пятый день недели - это пятница");
}

else if (dayNumber == 6)
{
    Console.WriteLine("Шестой день недели - это суббота");
}

else if (dayNumber == 7)
{
    Console.WriteLine("Седьмой день недели - это воскресенье");
}

else
{
    Console.WriteLine("Такого дня недели не существует");
}

/*
или с использованием switch
Console.WriteLine("Введите число: " );
switch 
(Convert.ToInt32(Console.ReadLine()))
{    
  case 1:    
  Console.WriteLine("понедельник" );    
  break;    
  case 2:    
  Console.WriteLine("вторник" );    
  break;    
  case 3:   
  Console.WriteLine("среда " );    
  break;    
  case 4:     
  Console.WriteLine("четверг" );    
  break;    
  case 5:    
  Console.WriteLine("пятница " );    
  break;    
  case 6:     
  Console.WriteLine("суббота" );     
  break;    
  case 7:    
  Console.WriteLine("воскресенье" );    
  break;    
  default: //Введенные числа вне диапазона.   
  Console.WriteLine("такого нет " );    
  break; // конец цыкала 
}
*/
```
## Задание №4
```
/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

int number = new int();
Console.WriteLine("Введите N");
number = Convert.ToInt32(Console.ReadLine());

int i = -number;

while (i <= number)
{
    Console.WriteLine(i);
    i += 1;
}
Console.WriteLine(i);
```
## Задание №5
```
/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/
int number = new int();
Console.WriteLine("Введите трехзначное число");
number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine($"Последняя цифра вашего числа = {number % 10}");

}
else
{
    Console.WriteLine("Вы ввели НЕ трехзначное число");
}
/*
Console.WriteLine("введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1000 && x > 99)
{
int two = x / 10;
int result = two % 10;
Console.Write(result);
}
else
Console.WriteLine("ввели не трехзначное число");
*/

```

