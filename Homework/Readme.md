Сборник всех домашних заданий и их решений 

# Homework-C#

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

---
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

----

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

---
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

---
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

----

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

---
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

# Задание №25

### Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
* 3, 5 -> 243 (3⁵)
* 2, 4 -> 16

### Решение задачи(возведение в степень)

* `Math.Pow` - функция возведение в степень работает изначально только с значениями `double`!
* Что бы сработало нужно `Convert.ToInt32` в `int`

```
Console.WriteLine("Задача 25:\nНапишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int sum = Convert.ToInt32(Math.Pow(numA, numB)); 

Console.WriteLine($"Число А = {numA} в натуральной степени B = {numB}\nРавняется = {sum} ");
```
<img width="1065" alt="Homework#1" src="https://user-images.githubusercontent.com/106627508/184919904-31788455-e473-48c3-8223-45bd898e2e9c.png">


# Задание №25v2 

## Решение №2 к заданию 25

##### Решение находится в папке (Task#1v2)
```
//Решение задачи(возведение в степень)
Console.Clear(); //Очищаем консоль 
Console.WriteLine("Задача 25:\nНапишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int sum(int numA, int numB)//метод
{
    int number1 = numA; //присваиваем numA новую переменную 
    for(int i = 1; i<numB; i++) // Прокручиваем цикл начиная перемножение с 1, если i меньше numB, и плюсуем +1 каждый круг к i, то numA умножаем на numA пока numB будет больше i. 
    {
        number1 *= numA;
    }
    return number1;
}

Console.WriteLine($"Число А = {numA} в натуральной степени B = {numB}\nРавняется = {sum(numA,numB)} ");
```

<img width="1064" alt="Homework#1v2" src="https://user-images.githubusercontent.com/106627508/185114900-e212650e-1eaf-4321-a002-fd07a6214558.png">

# Задание №27

### Задача 27: Напишите программу, котора я принимает на вход число и выдаёт сумму цифр в числе.
* 452 -> 11
* 82 -> 10
* 9012 -> 12
```
Console.Clear();
Console.WriteLine("Задача 27:\nНапишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.Write("Введите число: ==> ");
int numA = Convert.ToInt32(Console.ReadLine());

int tSumm(int numA) //метод 
{
    int s = 0; //счетчик+ переменная/ 
    while (numA > 0) //цикл который проверяет является ли введенная цифра больше нуля. 
    {
        s = s + numA % 10;
        numA = numA /10 ;
    }
    return s;
}
Console.WriteLine($"Сумма цифр {numA}\nРавна = {tSumm(numA)}");
```


<img width="1070" alt="Homework#2" src="https://user-images.githubusercontent.com/106627508/185178973-00ee6fd7-b7b9-4159-a69f-f192d2aeb48c.png">

# Задание №29

### Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
* 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
* 6, 1, 33 -> [6, 1, 33]

```
int[] a = new int[8]; // создали массив из восьми элементов

void RandomArray(int[] array)//Метод подсчета 
{
    for (int i = 0; i < a.Length; i++)//цикл прогона через весь массив/сравнение с длиной массива 
    {
        array[i]=new Random().Next(1, 100); //блок рандома который принимает 
        Console.Write($"{array[i]} ");//Вывод на экран
    }
}

Console.WriteLine($"Массив из 8 единиц = ");
RandomArray(a);//применяем метод к массиву `а`


```

<img width="906" alt="Снимок экрана 2022-08-19 в 15 06 06" src="https://user-images.githubusercontent.com/106627508/185615198-e2ea5261-a256-4b1a-8456-49b20d28a147.png">

# Задание №34

### Задача 34:Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
* [345, 897, 568, 234] -> 2
```
Console.Clear(); //очистили терминал 
Console.WriteLine("Задача 34:\nЗадайте массив заполненный случайными положительными трёхзначными числами. /nНапишите программу, которая покажет количество чётных чисел в массиве.");
int[] arr = new int[10]; // создали массив из 10 элементов

void Random(int[] array) //метод рандома
{
    for (int i = 0; i < arr.Length; i++) //цикл прохода по элементам массива 
    {
        Random rnd = new Random(); //Создание объекта для генерации чисел
        int value = rnd.Next(100, 1000);//Получить случайное число 
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void GetEven(int[] array)//метод поиска четных чисел 
{
    int num = 0; //счетчик 
    for (int i = 0; i < arr.Length; i++) //цикл прохода по элементам массива 
    {
        if (arr[i] % 2 == 0) //если в массиве число делится на 2 без остатка или равно 0 
        {
            num++;
        }
    }
    Console.WriteLine($"Четных чисел в массиве - {num}");
}

Random(arr);
GetEven(arr);
```
# Задание №36

### Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
* [3, 7, 23, 12] -> 19
* [-4, -6, 89, 6] -> 0
```
Console.Clear();
Console.WriteLine("Задача 36: \nЗадайте одномерный массив, заполненный случайными числами. \nНайдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).");
int[] arr = new int[8]; // создали массив из восьми элементов

void Random(int[] array) //метод рандома
{
    for (int i = 0; i < arr.Length; i++) //цикл прохода по элементам массива 
    {
        Random rnd = new Random(); //Создание объекта для генерации чисел
        int value = rnd.Next(-100, 100);//Получить случайное число 
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
Random(arr);

void Sum(int[] array) //метод Sum 
{
    int sum1 = 0; //счетчик 
    for (int i = 1; i < arr.Length; i = i+2) //цикл прохода по элементам массива(но в конце +2) 
    {
        sum1 = sum1 + arr[i]; 
    }
    Console.WriteLine($"Сумма элементов с нечетным индексом равна: {sum1}");
}

Sum(arr);
```
# Задание №38

### Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
* [3 7 22 2 78] -> 76
```
Console.Clear();

Console.WriteLine("Задача 38: \nЗадайте массив вещественных чисел. /nНайдите разницу между максимальным и минимальным элементов массива.");
int[] arr = new int[8]; // создали массив из восьми элементов

void Random(int[] array) //метод рандома
{
    for (int i = 0; i < arr.Length; i++) //цикл прохода по элементам массива 
    {
        Random rnd = new Random(); //Создание объекта для генерации чисел
        int value = rnd.Next(-100, 100);//Получить случайное число 
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void MaxMin(int[] array)//метод расчета максимум - минимум 
{
    int min = arr[0]; //счетчик mix 
    int max = arr[0]; //счетчик max 
    for (int i = 0; i < arr.Length; i++) ////цикл прохода по элементам массива
    {
        if (min > arr[i]) min = arr[i]; //если min больше значения массива arr[i] то min = arr[i]
        if (max < arr[i]) max = arr[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {max - min}");
}

Random(arr); //Вызов метода 
MaxMin(arr);
```
# Урок 6. Двумерные массивы и рекурсия
# Задача 41: 
## Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
* 0, 7, 8, -2, -2 -> 2
* 1, -7, 567, 89, 223-> 3

**Не получилось закончить код в варианте 1
Запутался не понял как решить, решил по другому в втором варианте**  

```
Console.Clear();
Console.Write("Введи число М : ");
int m = Convert.ToInt32(Console.ReadLine());
int[] result = new int[m]; //создаем массив с клавиатуры пользователя 

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"введите {i + 1} число");
    result[i] = Convert.ToInt32(Console.ReadLine());

}
return result;


// void InputNumbers(int m)
// {
//     int i = 0; //счетчик
//     while (i < m) //цикл 
//     {
//         Console.Write($"Введи {i + 1} число: ");
//         massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//         i++;
//         //Console.WriteLine(massiveNumbers);
//     }
// }

int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

//InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(result)} ");
```
## Вариант №2
```
/*
Вариант №2
*/
Console.Clear();
Console.Write("Введите элементы(через пробел): ");
//Вычитал на форумах про класс Array.ConvertAll = массив конвертируется автоматически но в аргументах нужно прописывать все равно тип int.Prase 
//Split - разделение строк разделяет строку на массив подстрок(Выступает в роле разделителя)
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0; //счетчик 

for (int i = 0; i < arr.Length; i++) //цикл пробегаемся по массиву 
{
    if (arr[i] > 0) // если цифра больше 0 то число записывается в count 
    {
        count++;
    }
}

Console.WriteLine($"Введено чисел больше 0: {count}"); // выводим count 

```
----
# Задача 43:
## Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
### Пример 
* х = k1 * x + b1, y = k2 * x + b2; 
* значения b1, k1, b2 и k2 задаются пользователем.
* b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Ответ в задаче 
```
Console.Clear();

Console.Write("введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
```
