Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
Console.Write("ВВедите число соответствующее дню недели ");
int Number =  int.Parse(Console.ReadLine() ?? "0");
if (Number < 6 && Number > 0) Console.WriteLine("Работайте дальше, это будни");
else if (Number == 6 || Number == 7) Console.WriteLine("Кайфуем! Это Выходной");
else Console.WriteLine("Вот мой номер телефона +79094512021 - звони и я расскажу сколько дней в неделе, а пока... Пока!");