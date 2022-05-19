Console.Clear();
Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
Console.Write("Введите предел последовательности: ");
int NumberA =  int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Четные значения кубов чисел от 1 до {NumberA}");
for (int i=1; i<=NumberA; i++)
    if ((i*i*i)%2 == 0)
        Console.WriteLine($"{i} в кубе {i*i*i}");