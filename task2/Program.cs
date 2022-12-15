// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = InputValue("b1");
double k1 = InputValue("k1");
double b2 = InputValue("b2");
double k2 = InputValue("k2");
string pointOfIntersection = GetPointOfIntersectionOfLines(b1, k1, b2, k2);
Console.WriteLine(pointOfIntersection);

double InputValue(string value)
{
    Console.WriteLine($"Введите значение {value}");
    double num = double.Parse (Console.ReadLine());
    return num;
}

string GetPointOfIntersectionOfLines(double b1, double k1, double b2, double k2)
{
    string result = "";
    if (k1 == k2 && b1 == b2)
    {
        result = "Прямые совпадают";
    }
    else if (k1==k2)
    {
        result = "Прямые параллельны";
    }
    else
    {
        double x=(b2-b1)/(k1-k2);
        double y=(k1*(b2-b1))/(k1-k2)+b1;
        result = $"Точка пересечения двух прямых ({x}; {y})";
    }
    return result;
}    
   