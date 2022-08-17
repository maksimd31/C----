/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
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



