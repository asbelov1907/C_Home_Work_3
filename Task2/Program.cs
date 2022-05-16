// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;

        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

double GetLinghtVector(int xx1, int yy1, int zz1, int xx2, int yy2, int zz2)
{
    double result = Math.Sqrt(Math.Pow(xx2 - xx1, 2) + Math.Pow(yy2 - yy1, 2) + Math.Pow(zz2 - zz1, 2));
    return result;
}

int x1 = GetNumber("Введите Х координату первой точки");
int y1 = GetNumber("Введите Y координату первой точки");
int z1 = GetNumber("Введите Z координату первой точки");
int x2 = GetNumber("Введите Х координату второй точки");
int y2 = GetNumber("Введите Y координату второй точки");
int z2 = GetNumber("Введите Z координату второй точки");

double LinghtVector = GetLinghtVector(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояния между двумя точками равно " + Math.Round(LinghtVector, 2));

