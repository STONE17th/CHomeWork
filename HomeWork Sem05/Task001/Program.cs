double GetValue (string text)
{
    Console.Write($"Введите коэффициент {text}: ");
    double value =  double.Parse(Console.ReadLine() ?? "0");
    return (value);
}

Console.Clear();
Console.WriteLine("Найти точку пересечения двух прямых заданных "
    +"уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
double k1 = GetValue("k1");
double b1 = GetValue("b1");
double k2 = GetValue("k2");
double b2 = GetValue("b2");

if (k1 == k2)
    Console.Write($"Эти прямые не пересекаются. Они параллельны друг другу");
else
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    Console.Write($"координаты точки пересечения прямых x = {x}, y = {y}");
}