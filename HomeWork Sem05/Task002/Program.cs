Console.Clear();
Console.WriteLine("Написать программу масштабирования фигуры");
Console.Write("Введите координаты вершин изначальной фигуры в формате (x,y через пробел): ");
string origCoord = Console.ReadLine() ?? "0";
Console.Write("Введите коэффициент масштабирования: ");
double Number =  Convert.ToDouble(Console.ReadLine() ?? "0");
string[] CoordArr = origCoord.Split(" ");
string scaleCoord = "x:y  ";
for (int i=0; i<CoordArr.Length; i++)
{
    string[] DotCoord = CoordArr[i].Split(",");
    scaleCoord += $"{Convert.ToInt32(DotCoord[0])*Number}:{Convert.ToInt32(DotCoord[1])*Number}  ";
}
Console.WriteLine("Координаты вершин масштабированной фигуры:");
Console.WriteLine($"{scaleCoord}");