//vid
void Metod1() //Метод 
{
    Console.WriteLine("Автор ....."); // Что ыыполняе метод 
}
Metod1(); //Вызов метода 

//Вид 2
void Metod2(string msg)// метод/название/тип/переменная
{
    Console.WriteLine(msg); // что выполняет метод 

}
Metod2("Текс собщения "); //Вызов Метода и присвоение аргумента

//Вариант 2 /метод вызывает текс 4 раза  
void Metod2v1(string msg, int count )// метод/название/тип/переменная
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Metod2v1("Текст собщения, 4 "); //Вызов Метода и присвоение аргумента
//Metod2v1(msg: "Текст собщения, count: 4 "); //точное указание параметров ,( можно писать в разнобой)

//Вид 3 /[Ничего не возращает, Ничего не принимает] 

int Metod3()
{
    return DateTime.Now.Year;
}
int Year = Metod3();
Console.WriteLine(Year); 
// Показывает текущий год.

//Вид Методы что то принимают и что то возращают
//этот метод печатает склееный текст 10 раз 
string Metod4(int count, string text )
{
    int i=0; //счетчик 
    string result = string.Empty; // у переченной result строка и объявляем что строка пустая! 
    while (i<count)// цикл пока i меньше count цикл будет выполнятся 
    {
        result = result + text; //происходит склеивание  
        i++;
    }
    return result; // остаовливаем цикл при достижении цели
}
string res = Metod4(10, "qwer"); //Обявляем метод 
Console.WriteLine(res); //Выводим метод 
