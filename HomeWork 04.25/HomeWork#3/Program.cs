Console.WriteLine("Задание. Выяснить является ли число чётным.");
Console.Write("ВВедите любое число: ");
int Number = Convert.ToInt32(Console.ReadLine() ?? "0");
if (Number % 2 == 1)
    {
        Console.Write("Число {0} - нечетное", Number);
    }
else
    {
        Console.Write("Число {0} - четное", Number);
    }