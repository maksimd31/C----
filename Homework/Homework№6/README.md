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
