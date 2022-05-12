Console.WriteLine("Задание. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.");
Console.Write("Введите двухзначное число: ");
int Number2 = int.Parse(Console.ReadLine() ?? "0");
if (10 <= Number2 && Number2 <= 99)
    {
        int Digit1 = Number2%10;
        int Digit2 = Number2/10;
        if (Digit1 > Digit2)
            {
                Console.WriteLine($"В числе {Number2} наибольшая цифра {Digit1}.");
            }
        if (Digit2 > Digit1)
            {
                Console.WriteLine($"В числе {Number2} наибольшая цифра {Digit2}.");
            }
        if (Digit2 == Digit1)
            {
                Console.WriteLine($"Поздравляем! У вас близнецы! Обе цифры {Digit1}.");
            }
        
    }
else
    {
        Console.WriteLine($"А какая разница какая из цифр больше, если у Вас с двузначными числами проблема?");
    }