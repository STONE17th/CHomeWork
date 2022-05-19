Console.WriteLine("Задание. Показать четные числа от 1 до N");
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");
int counter = 1;
Console.WriteLine($"Четные числа от 1 до {NumberN}: ");
while (counter <= NumberN)
    {
        if (counter % 2 == 0)
            {
                Console.Write(counter+", ");
            }
        counter++;
    }