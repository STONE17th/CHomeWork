Console.Clear();
Console.WriteLine("По двум заданным числам проверять является ли одно квадратом другого");

bool Trigger = false;
int NumA = 0, NumB = 0;
do
{
    try
    {
        Console.Write("ВВедите первое число ");
        NumA =  int.Parse(Console.ReadLine() ?? "0");
        Console.Write("ВВедите второе число ");
        NumB =  int.Parse(Console.ReadLine() ?? "0");
        Trigger = false;
    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Вводите числа, а не то, что вздумается. Посерьезнее...");
        Trigger = true;
    }

} while (Trigger);
    if (NumA == NumB*NumB) Console.WriteLine($"Число {NumA} является квадратом числа {NumB}");
    else if (NumB == NumA*NumA) Console.WriteLine($"Число {NumB} является квадратом числа {NumA}");
    else Console.WriteLine($"Числа {NumA} и {NumB} не квадраты и не корни друг друга. Их объединяет, что они оба состоят из цифр");
