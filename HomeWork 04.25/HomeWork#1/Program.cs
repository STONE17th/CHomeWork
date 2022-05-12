Console.WriteLine("Задание. По двум заданным числам проверять является ли первое квадратом второго.");
Console.Write("Введите первое число:  ");
int NumberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:  ");
int NumberB = int.Parse(Console.ReadLine() ?? "0");

if (NumberB == NumberA * NumberA)
    {
        Console.WriteLine("Супер! Число {0} является квадратным корнем числа {1}!", NumberA, NumberB);
    }
else
    {
        Console.WriteLine("Эх... Квадратный корень из {1} совсем не {0}.", NumberA, NumberB);
    }