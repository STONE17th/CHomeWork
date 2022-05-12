Console.WriteLine("Задание. Выяснить, кратно ли число заданному, если нет, вывести остаток.");
Console.Write("Введите число изначальное число: ");
int MainNumber = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число для проверки на кратность: ");
int SubNumber = int.Parse(Console.ReadLine() ?? "0");
if (MainNumber%SubNumber == 0)
    {
        Console.Write($"Бинго! Число {MainNumber} кратно числу {SubNumber}!");
    }
else
    {
        Console.Write($"Увы... Число {MainNumber} не кратно числу {SubNumber}. Остаток будет {MainNumber%SubNumber}.");
    }