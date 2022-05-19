/* Console.WriteLine("Задание. Найти третью цифру числа или сообщить, что её нет");
Console.Write("Введите любое число: ");
int MainNumber = int.Parse(Console.ReadLine() ?? "0");
int CurrentNumber = MainNumber;
if (MainNumber >= 100)
{
    while(CurrentNumber>1000)
        CurrentNumber = CurrentNumber/10;
    Console.Write($"В числе {MainNumber} третья цифра - {CurrentNumber%10}.");
}
else
    {
       Console.Write($"В числе {MainNumber} нет третьей цифры."); 
    } */

// Второй вариант решения задачи

Console.WriteLine("Задание. Найти третью цифру числа или сообщить, что её нет");
Console.Write("Введите любое число: ");
string MainNumber = Console.ReadLine() ?? "";
if (MainNumber.Length >= 3)
    Console.Write($"В числе {MainNumber} третья цифра - {MainNumber[2]}.");
else
    Console.Write($"В числе {MainNumber} нет третьей цифры."); 