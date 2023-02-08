// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Inpudouble(string msg)
{
    System.Console.Write($"{msg} -> ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double Count(double a, double b, double c, double d)
{   
    double x = -(b - d) / (a - c);
    double y = a * x + b;
    System.Console.Write($"({x}; {y})");
    double result = 0;
    return result;
}

double b1 = Inpudouble("Введите b1");
double k1 = Inpudouble("Введите k1");
double b2 = Inpudouble("Введите b2");
double k2 = Inpudouble("Введите k2");
Count(k1, b1, k2, b2);