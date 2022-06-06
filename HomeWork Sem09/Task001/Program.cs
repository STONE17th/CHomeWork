Console.Clear();
Console.WriteLine("Показать натуральные числа от M до N, M и N задано");
Console.Write("Введите число M: ");
int NumberM = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

PrintNaturalNumbers(NumberM);

void PrintNaturalNumbers (int N)
{
    if (NumberM<=NumberN)
    {
        Console.Write($"{NumberM} ");
        NumberM++;
        PrintNaturalNumbers(NumberM);
    }
}