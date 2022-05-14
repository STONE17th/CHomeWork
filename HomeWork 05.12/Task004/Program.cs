Console.Clear();
Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");

bool Trigger = true;
do
{
    try
    {
        Console.WriteLine("Введите координаты точек А и В через пробел");
        Console.WriteLine("X Y - для 2D или X Y Z - для 3D ");
        Console.Write("ВВедите координаты первой точки (через пробел): ");
        string FirstCoord = Console.ReadLine() ?? "0";
        Console.Write("ВВедите координаты второй точки (через пробел): ");
        string SecondCoord = Console.ReadLine() ?? "0";

        string[] FC = FirstCoord.Split(' ');
        string[] SC = SecondCoord.Split(' ');
        int DistX = Convert.ToInt32(FC[0]) - Convert.ToInt32(SC[0]);
        int DistY = Convert.ToInt32(FC[1]) - Convert.ToInt32(SC[1]);
    
        double DistXY = DistX*DistX + DistY*DistY;
        if ((FC.Length == SC.Length) && (FC.Length == 2))
        {
            double Dist = Math.Sqrt(DistXY);
            Console.WriteLine($"Расстояние между точкой А({FC[0]},{FC[1]}) и точкой B({SC[0]},{SC[1]}) равно {Dist}");
            Trigger = false;
        }
        else if ((FC.Length == SC.Length) && (FC.Length == 3))
        {
            int DistZ = Convert.ToInt32(FC[2]) - Convert.ToInt32(SC[2]);
            double DistXYZ = DistXY + DistZ*DistZ;
            double Dist = Math.Sqrt(DistXYZ);
            Console.WriteLine($"Расстояние между точкой А({FC[0]},{FC[1]},{FC[2]}) и точкой B({SC[0]},{SC[1]},{FC[2]}) равно {Dist}");
            Trigger = false;
        }
        else sysError();
    }
    catch
    {
        sysError();
    }
} while (Trigger);

static void sysError()
{
    Console.Clear();
    Console.WriteLine("Проверьте корректность ввода координат и повторите попытку");
}