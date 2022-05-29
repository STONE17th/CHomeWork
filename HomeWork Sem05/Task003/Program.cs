Console.Clear();
Console.WriteLine("Написать программу копирования массива");
Console.Write("Введите данные массива (размер, минимальное и макисмальное значение, через пробел): ");
string SettingArr =  Console.ReadLine() ?? "0";
string[] SetArr = SettingArr.Split(" ");
int[] array = new int[Convert.ToInt32(SetArr[0])];
int newSize = array.Length;
int[] newArray = new int[newSize];

Console.WriteLine("Массив: ");
for (int i=0; i<Convert.ToInt32(SetArr[0]); i++)
{
    array[i] = new Random().Next(Convert.ToInt32(SetArr[1]),Convert.ToInt32(SetArr[2]));
    Console.Write($"{array[i]} ");
    newArray[i] = array[i];
}
Console.WriteLine("");

Console.WriteLine("Новый массив: ");
foreach (int k in newArray)
    Console.Write($"{k} ");


// по факту копирование массива можно заложить сразу в первый цикл for
// где мы присваиваем значения элементам первого массива
// (после 14ой строки добавить newArray[i] = array[i];)