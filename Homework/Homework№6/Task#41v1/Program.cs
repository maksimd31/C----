/*
Урок 6. Двумерные массивы и рекурсия
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

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