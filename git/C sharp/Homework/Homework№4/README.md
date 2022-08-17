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


<img width="1064" alt="Homework#1v2" src="https://user-images.githubusercontent.com/106627508/185114900-e212650e-1eaf-4321-a002-fd07a6214558.png">
