// Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер дня недели выходным");

// bool Trigger = false;
// int Number = 0;
// do
// {
//     try
//     {
//         Console.Write("ВВедите первое число ");
//         Number =  int.Parse(Console.ReadLine() ?? "0");
//         Trigger = false;
//     }
//     catch
//     {
//         Console.WriteLine("По вашему это цифра? Либо вводите цифру, либо расходимся! Попробуем еще разок...");
//         Trigger = true;
//     }

// } while (Trigger);
// if (Number > 0 && Number < 8)
//     switch (Number)
//     {
//         case  1:
//             Console.Write("Это понедельник. Понедельник день тяжелый...");
//             break;
//         case 2:
//             Console.Write("Вторник, неплохой день, но всё равно не выходной");
//             break;
//         case 3:
//             Console.Write("Среда! Уже ближе к выходным, но...");
//             break;
//         case 4:
//             Console.Write("Четверг. У некоторых он 'чистый', так что можешь пойти помыться");
//             break;
//         case 5:
//             Console.Write("Друг! Тебе совсем чуть-чуть не хватило, ты попал на пятницу");
//             break;
//         case 6:
//             Console.Write("Запускайте салюты, ее величество суббота, это выходной!");
//             break;
//         case 7:
//             Console.Write("Воскресенье - хуже субботы, именно потому, что вчера была суббота. Тоже выходной, но помни - завтра понедельник...");
//             break;
//     }
// else Console.WriteLine("Вот мой номер телефона +79094512021 - звони и я расскажу сколько дней в неделе, а пока... Пока!");

Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
Console.Write("ВВедите число соответствующее дню недели ");
int Number =  int.Parse(Console.ReadLine() ?? "0");
if (Number < 6 && Number > 0) Console.WriteLine("Работайте дальше, это будни");
else if (Number == 6 || Number == 7) Console.WriteLine("Кайфуем! Это Выходной");
else Console.WriteLine("Вот мой номер телефона +79094512021 - звони и я расскажу сколько дней в неделе, а пока... Пока!");