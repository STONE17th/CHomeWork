void OneString(int count, int j)
{
    Console.Write("Число: \t\t");
    for (int i = 1; i <= j; i++)
        Console.Write($"{i + 10*(count-1)}\t");

    Console.WriteLine();

    Console.Write("Квадрат: \t");
    for (int i = 1; i <= j; i++)
        Console.Write($"{(i + 10*(count-1))*(i + 10*(count-1))}\t");

    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");
Console.Write("Введите предел таблицы: ");
int NumberN =  int.Parse(Console.ReadLine() ?? "0");
int N = NumberN/10;
int count = 1;

while (count<(N+1))
{
    OneString(count, 10);
    count++;
}

OneString(count, NumberN%10);