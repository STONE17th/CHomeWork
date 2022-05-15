Console.Clear();
Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");

bool Trigger = true;
do
{
    try
    {
        Console.WriteLine("Введите координаты точек А и В через пробел");
        Console.Write("ВВедите координаты первой точки (через пробел): ");
        string FirstCoord = Console.ReadLine() ?? "0";
        Console.Write("ВВедите координаты второй точки (через пробел): ");
        string SecondCoord = Console.ReadLine() ?? "0";

        string[] FC = (FirstCoord + " 0").Split(' ');
        string[] SC = (SecondCoord + " 0").Split(' ');
        int DistX = Convert.ToInt32(FC[0]) - Convert.ToInt32(SC[0]);
        int DistY = Convert.ToInt32(FC[1]) - Convert.ToInt32(SC[1]);
        int DistZ = Convert.ToInt32(FC[2]) - Convert.ToInt32(SC[2]);
    
        double Dist = Math.Sqrt(DistX*DistX + DistY*DistY + DistZ*DistZ);
        Console.WriteLine($"Расстояние между точкой А({FC[0]},{FC[1]},{FC[2]}) и точкой B({SC[0]},{SC[1]},{FC[2]}) равно {Dist}");
        Trigger = false;
    }
    catch
    {
        // Console.Clear();
        Console.WriteLine("Проверьте корректность ввода координат и повторите попытку");
    }
} while (Trigger);