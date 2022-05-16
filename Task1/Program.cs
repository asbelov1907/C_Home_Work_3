// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string GetNumber(string msg)
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if(number > 10000 && number < 99999 )  
        
            return Convert.ToString(number);
        else
        {
            Console.WriteLine("Число должно быть пятизначным. Введите другое число");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число.");
    }
}
}

void Palindrom(string numberprov)
{
    if(numberprov[0] == numberprov[4] && numberprov[1] == numberprov[3])
        Console.WriteLine("Число " + numberprov + " является палиндромом");
    else 
        Console.WriteLine("Число " + numberprov + " не является палиндромом");
}


Palindrom(GetNumber("Введите пятизначное число"));
