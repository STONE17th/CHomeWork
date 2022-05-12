Console.WriteLine("Задание. Показать вторую цифру трехзначного числа");
Console.Write("Введите число трехзначное число: ");
int Number3 = int.Parse(Console.ReadLine() ?? "0");
if (99 < Number3 && Number3 < 1000)
    {
        Console.WriteLine($"В числе {Number3} вторая цифра - {Number3/10%10}");
    }
else
    {
        Console.WriteLine($"Уважаемый, трехзначное - это из трех цифр, например 123");
    }