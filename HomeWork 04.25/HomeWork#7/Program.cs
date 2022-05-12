Console.WriteLine("Задание. Удалить вторую цифру трёхзначного числа.");
// Без метода ToString() не смог найти решения этой задачи 
Console.Write("Введите трехзначное число: ");
int Number3 = int.Parse(Console.ReadLine() ?? "0");
if (100 <= Number3 && Number3 <= 999)
    {
        string NewNumber2 = (Number3/10/10).ToString() + (Number3%10).ToString();
        Console.Write($"Из числа {Number3} убираем вторую цифру {Number3/10%10} и получаем {NewNumber2}");
    }
else
    {
        Console.WriteLine($"Сколько было порросят в сказке? Вот столько и нам нужно было цифр. ТРИ!");
    }    