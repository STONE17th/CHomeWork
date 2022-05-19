int[] array = new int[8];

Console.WriteLine("Двоичный массив: ");
for (int i=0; i<8; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write($"{array[i]} ");
}