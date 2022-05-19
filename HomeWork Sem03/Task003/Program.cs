Console.Clear();
Console.WriteLine("Найти сумму чисел от 1 до А");
Console.Write("Введите число А: ");
int NumberA =  int.Parse(Console.ReadLine() ?? "0");
int summ = 0;
for (int i = 1; i<=NumberA; i++)
    summ += i;
Console.WriteLine($"Сумма чисел от 1 до {NumberA} равна {summ}");