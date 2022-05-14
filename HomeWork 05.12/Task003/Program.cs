Console.Clear();
Console.WriteLine("Задать номер четверти, показать диапазоны для возможных координат");

bool Trigger = true;
do
{
    Console.WriteLine("1 | 2");
    Console.WriteLine("-----");
    Console.WriteLine("3 | 4");
    Console.Write("ВВедите номер четверти ");
    int Num =  int.Parse(Console.ReadLine() ?? "0");
    switch (Num)
    {
        case  1:
            Console.Write($"В {Num} четверти значения X [0,-inf) и Y [0,+inf)");
            Trigger = false;
            break;
        case 2:
            Console.Write($"В {Num} четверти значения X [0,+inf) и Y [0,+inf)");
            Trigger = false;
            break;
        case 3:
            Console.Write($"В {Num} четверти значения X [0,-inf) и Y [0,-inf)");
            Trigger = false;
            break;
        case 4:
            Console.Write($"В {Num} четверти значения X [0,+inf;) и Y [0,-inf)");
            Trigger = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Повнимательней, такой четверти нет. Попробуй еще раз");
            break;        
    }
} while (Trigger);