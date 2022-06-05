Console.Clear();
Console.WriteLine("Треугольник Паскаля");
Console.Write("Введите число N: ");
int NumberN =  int.Parse(Console.ReadLine() ?? "0");

int[,] triangleP = new int[NumberN*2+2,NumberN*2+2];

triangleP[0,(NumberN*2+1)/2] = 1;

for (int i=1; i<=NumberN; i += 1)
    for (int j=1; j<triangleP.GetLength(1)-1; j += 1)
    {
        triangleP[NumberN,0] = 1;
        triangleP[i,j] = triangleP[i-1,j-1] + triangleP[i-1,j+1];
    }
for (int i=0; i<triangleP.GetLength(0); i++)
{
    for (int j=0; j<triangleP.GetLength(1); j++)
    {
        if (triangleP[i,j] != 0)
        {
            string Element = Convert.ToString(triangleP[i,j]);
            while (Element.Length<3)
                Element += " ";
            Console.Write($"{Element} ");

        }
        else 
            Console.Write($"    ");
    }
    Console.WriteLine();
}