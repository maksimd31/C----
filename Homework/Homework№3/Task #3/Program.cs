/*
Задание 23 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
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
