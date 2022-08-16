/*
Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string gg = Convert.ToString(num);

for (int i = 0 ; i <gg.Length; i++)
{
    Console.WriteLine(i);
}

/*
//Вариант №1
Console.Clear();
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {num} имеет {num.ToString().Length} цифр(ы)");

*/
/*
//Вариант №2
Console.Clear();
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int num = userNumber;
int i = 1;

while(num > 9)
{
    num = num / 10;
    i++;
}

Console.WriteLine($"В числе {userNumber} {i} цифры.");
*/