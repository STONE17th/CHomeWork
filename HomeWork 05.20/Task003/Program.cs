Console.Clear();
Console.WriteLine("Задать массив, заполнить случайными "
    +"положительными трёхзначными числами. "
    +"Показать количество нечетных/четных чисел");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");

int OddNum = 0, EvenNum = 0;

int[] array = new int[arrSize];

Console.WriteLine("Массив: ");
for (int i=0; i<arrSize; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");
foreach (int k in array)
{
    if (k%2 == 0) ++EvenNum;
    if (k%2 != 0) ++OddNum;
}

Console.WriteLine($"В данном массиве {OddNum} нечетных элементов");
Console.WriteLine($"В данном массиве {EvenNum} четных элементов");