//этот метод печатает склеенный текст 10 раз 
string Metod4(int count, string text )
{
    int i=0; //счетчик 
    string result = string.Empty; // у переменной result строка и объявляем что строка пустая! 
    for(int i=0; i<count; i++ )//Цикл for/тип-счетчик/условие/плюсуем на 1(инкремент) 
    {
        result = result + text; //происходит склеивание  
    }
    return result; // останавливаем цикл при достижении цели
}
string res = Metod4(10, "qwerty"); //Объявляем метод 
Console.WriteLine(res); //Выводим метод 

