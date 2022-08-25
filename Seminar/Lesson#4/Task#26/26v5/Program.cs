//Вариант №5

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