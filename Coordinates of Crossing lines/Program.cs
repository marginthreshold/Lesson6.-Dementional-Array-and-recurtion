using static System.Console;
Clear();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

WriteLine("Введите числовые значения b1, k1, b2, k2 через запятую для прямых y = k1 * x + b1 и y = k2 * x + b2");
string[] parameters = new string[4];
parameters = ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
double b1 = Convert.ToDouble(parameters[0]);
double k1 = Convert.ToDouble(parameters[1]);
double b2 = Convert.ToDouble(parameters[2]);
double k2 = Convert.ToDouble(parameters[3]);

CoordinatesOfCrossingLines(k1, b1, k2, b2);


void CoordinatesOfCrossingLines(double a1, double c1, double a2, double c2)  //y = a1 * x + c1 и y = a2 * x + c2
{
    double x = (c1 - c2) / (a2 - a1);
    WriteLine($"({Math.Round(x, 2)};{Math.Round(a1 * x + c1, 2)})");
}