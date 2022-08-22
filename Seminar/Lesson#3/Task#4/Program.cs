
/*Задача 22: Напишите программу, которая принимает
на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
Console.WriteLine("Введите данные ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++) // Цикл который выполняет действие умножение до того момента пока i не станет равно N
{
    int result = i * i;
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
