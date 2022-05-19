Console.Clear();
Console.WriteLine("Найти кубы чисел от 1 до N");
Console.Write("Введите число N: ");
int NumberN =  int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i<=NumberN; i++)
    Console.WriteLine($"Куб числа {i} равен {i*i*i}");