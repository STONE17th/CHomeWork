Console.Clear();
Console.WriteLine("Найти точку пересечения двух прямых заданных "
    +"уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");
Console.Write("Введите коэффициент k1: ");
float k1 =  float.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите коэффициент b1: ");
float b1 =  float.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите коэффициент k2: ");
float k2 =  float.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите коэффициент b2: ");
float b2 =  float.Parse(Console.ReadLine() ?? "0");

float x = (b2-b1)/(k1-k2);
float y = k1*x+b1;

Console.Write($"координаты точки пересечения прямых x={x}, y={y}");
