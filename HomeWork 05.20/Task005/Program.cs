Console.Clear();
Console.WriteLine("Найти произведение пар чисел в "
    +"одномерном массиве. Парой считаем первый и "
    +"последний элемент, второй и предпоследний и т.д.");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];

Console.WriteLine("Массив: ");
for (int i=0; i<arrSize; i++)
{
    array[i] = new Random().Next(-100,100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");

for (int i=0; i<(array.Length/2); i++)
    Console.WriteLine($"Произведение {i+1} и {array.Length-i} "
    +$"элементов равно {array[i]*array[array.Length-i-1]}");
