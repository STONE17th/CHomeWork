Console.Clear();
Console.WriteLine("В одномерном массиве из 123 чисел "
    +"найти количество элементов из отрезка [10,99]");
int CurNum = 0;
int[] array = new int[123];

Console.WriteLine("Массив: ");
for (int i=0; i<123; i++)
{
    array[i] = new Random().Next(0,1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");

foreach (int k in array)
    if (k>=10 && k<=99) ++CurNum;

Console.WriteLine($"В данном массиве {CurNum} элементов "
    +$"попадает в интервал значений от 10 до 99");



// Console.Clear();
// Console.WriteLine("В одномерном массиве из 123 чисел "
//     +"найти количество элементов из отрезка [10,99]");
// Console.Write("Введите размер массива: ");
// int arrSize =  int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите минимальный предел элементов: ");
// int MinLim = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("Введите максимальный предел элементов: ");
// int MaxLim = int.Parse(Console.ReadLine() ?? "0");
// int CurNum = 0;

// int[] array = new int[arrSize];

// Console.WriteLine("Массив: ");
// for (int i=0; i<arrSize; i++)
// {
//     array[i] = new Random().Next(0,1000);
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine("");
// foreach (int k in array)
//     if (k>=MinLim && k<=MaxLim) ++CurNum;

// Console.WriteLine($"В данном массиве {CurNum} элементов попадает в интервал значений от {MinLim} до {MaxLim}");