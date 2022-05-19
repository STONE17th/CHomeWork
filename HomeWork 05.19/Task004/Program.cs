Console.Clear();
Console.WriteLine("Возведите число А в натуральную степень B используя цикл");
Console.Write("Введите число А: ");
int NumberA =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите степень В: ");
int NumberB =  int.Parse(Console.ReadLine() ?? "0");
long Number = 1;

for (int i=1; i<=NumberB; i++)
    Number *= NumberA;

Console.WriteLine($"Число {NumberA} в степени {NumberB} равно {Number}");