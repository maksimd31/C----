# Задание №1

##### Решение находится в папке (Task#1)

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


# Задание №1v2 

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

# Задание №2 

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

# Задание №3

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