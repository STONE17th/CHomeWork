Console.Clear();
Console.WriteLine("Подсчитать сумму цифр в числе");
Console.Write("Введите число: ");
int NumberA =  int.Parse(Console.ReadLine() ?? "0");
int Number = NumberA;
int summ = 0;

while (Number>0)
{
    summ += Number%10;
    Number /= 10;
}

Console.WriteLine($"Сумма цифр в числе {NumberA} равна {summ}");