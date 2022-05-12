Console.WriteLine("Задание. По заданному номеру дня недели вывести его название.");
Console.Write("Введите порядковый день недели: ");
int DayWeek = int.Parse(Console.ReadLine() ?? "0");
if (DayWeek == 1)
    {
        Console.Write($"{DayWeek}ый день недели это понедельник");
    }
if (DayWeek == 2)
    {
        Console.Write($"{DayWeek}ой день недели это вторник");
    }
if (DayWeek == 3)
    {
        Console.Write($"{DayWeek}ий день недели это среда");
    }
if (DayWeek == 4)
    {
        Console.Write($"{DayWeek}ый день недели это четверг");
    }
if (DayWeek == 5)
    {
        Console.Write($"{DayWeek}ый день недели это пятница");
    }
if (DayWeek == 6)
    {
        Console.Write($"{DayWeek}ой день недели это суббота");
    }
if (DayWeek == 7)
    {
        Console.Write($"{DayWeek}ой день недели это воскресенье");
    }
if (DayWeek < 1 || DayWeek > 7)
    {
        Console.Write("Для начала сходите и подучите сколько дней в неделе, а потом ждем Вас снова! :)");
    }