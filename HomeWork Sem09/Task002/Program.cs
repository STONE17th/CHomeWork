Console.Clear();
Console.WriteLine("Показать сумму натуральных чисел от M до N, M и N задано");
Console.Write("Введите число M: ");
int NumberM = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int NumberN = int.Parse(Console.ReadLine() ?? "0");

int summa = 0;
int Number = NumberM;
PrintSummaNumbers(NumberM, summa);

void PrintSummaNumbers (int Number, int summa)
{
    if (Number<=NumberN)
    {
        summa += Number;
        Number++;
        PrintSummaNumbers(Number, summa);
    }
    else
        Console.Write($"Cумма натуральных чисел от {NumberM} до {NumberN} равна {summa}");
}