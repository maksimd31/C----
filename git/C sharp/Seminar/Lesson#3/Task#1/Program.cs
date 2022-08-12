// Код с семенара дополнить его с записи семенара.
int getQuoterFromCoordinate(int x, int y )
{
    int resault = 0;
    if (x>0 && y<0)
    {
        resault =1;
    }
    else if(x<0 && y >0)
    {
        resault = 2;
    }
    else if (x<0 && y < 0)
    {
        resault =3;
    }
    else if (x>0 && y < 0)
    {
        resault =4; 
    }
    else 
    {
        Console.ForegroundColor -ConsoleColor.Red;
        Console.WriteLine($"X и Y Не должны быть равны 0 вы ввели {x} {Y}");
        Console.ResetColor();
    }
    return resault;
}
int userX =0;
int userY = 0;

Console.WriteLine("Введите Х: ");
userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
userY = Convert.ToInt32(Console.ReadLine());
int quoter = getQuoterFromCoordinate;