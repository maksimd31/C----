# Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
* M = 1; N = 5. -> ""5, 4, 3, 2, 1""
* M = 4; N = 8. -> ""8, 7, 6, 5, 4""
```

Console.Clear();
Console.WriteLine($"Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
int n = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

```
# Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
* M = 1; N = 15 -> 56
* M = 4; N = 8. -> 18
```

Console.Clear();
Console.WriteLine($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) //метод приобразование числа 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
```
# Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
* m = 2, n = 3 -> A(m,n) = 9
```

Console.Clear();
Console.WriteLine($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) //метод приобразование числа 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

```