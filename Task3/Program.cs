// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string msg)
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if(number >= 1 )  
        
            return number;
        else
        {
            Console.WriteLine("Число должно быть равным или больше 1. Введите другое число");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести число.");
    }
}
}

void GetCobe(int n)
{
    int index = 1;

    while(index <= n)
    {
        Console.Write(Math.Pow(index,3) + " ");
        index++;
    }
}

int Number_N = GetNumber("Введите число равное или больше 1");
GetCobe(Number_N);
