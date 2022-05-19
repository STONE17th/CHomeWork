Console.Clear();
Console.WriteLine("Задать массив из 12 элементов, "
    +"заполненных числами из [0,9]. Найти сумму "
    +"положительных/отрицательных элементов массива");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный предел элементов: ");
int MinLim = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный предел элементов: ");
int MaxLim = int.Parse(Console.ReadLine() ?? "0");

int PositiveSumm = 0, NegativeSumm = 0;

int[] array = new int[arrSize];

Console.WriteLine("Массив: ");
for (int i=0; i<arrSize; i++)
{
    array[i] = new Random().Next(MinLim,MaxLim);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");
foreach (int k in array)
{
    if (k>0) PositiveSumm += k;
    if (k<0) NegativeSumm += k;
}

Console.WriteLine($"Сумма положительных элементов массива: {PositiveSumm}");
Console.WriteLine($"Сумма отрицательных элементов массива: {NegativeSumm}");