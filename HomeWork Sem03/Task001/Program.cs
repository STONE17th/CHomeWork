// Console.Clear();
// Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");
// Console.Write("Введите предел таблицы: ");
// int NumberN =  int.Parse(Console.ReadLine() ?? "0");
// for (int i = 1; i<=NumberN; i++)
//     Console.WriteLine($"Квадрат числа {i} равен {i*i}");

// Ниже приведен код, который выводит в консоль именно ТАБЛИЦУ(!!!)

Console.Clear();
Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");
Console.Write("Введите предел таблицы: ");
int NumberN =  int.Parse(Console.ReadLine() ?? "0");
int N = NumberN/10;
int count = 1;
string Num = "";

while (count<(N+1))
{
    OneString(count, 10);
    count++;
}

OneString(count, NumberN%10);

void OneString(int count, int j)
{
    Console.Write("  Число: ");
    for (int i = 1+((count-1)*10); i <= j+((count-1)*10); i++)
    {
        Num = Convert.ToString(i);
        while (Num.Length<4)
            Num += " ";
        Console.Write($"{Num} | ");
    }

    Console.WriteLine();

    Console.Write("Квадрат: ");
    for (int k = 1+((count-1)*10); k <= j+((count-1)*10); k++)
    {
        Num = Convert.ToString(k*k);
        while (Num.Length<4)
            Num += " ";
        Console.Write($"{Num} | ");
    }

    Console.WriteLine();
}