int[,] EnterMatrix(int rows, int columns, int min, int max)
{
    var rnd = new Random();
    int[,] matrix = new int[rows,columns];
    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            matrix[i,j] = rnd.Next(min,max);
    return matrix;
}

void PrintMatrix(int[,] matrix, int MaxValue)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            string Number = "";
            string Max = Convert.ToString(MaxValue*MaxValue);
            string Num = Convert.ToString(matrix[i,j]);
            while (Number.Length<(Max.Length - Num.Length))
                Number += " ";
            Number += Num;
            Console.Write($"{Number} |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeMatrix(int [,] matrix)
{
for (int i=0; i<matrix.GetLength(0); i++)
    for (int j=0; j<matrix.GetLength(1); j++)
        if (i%2==0 && j%2==0)
            matrix[i,j] *= matrix[i,j];
}

Console.Clear();
Console.WriteLine("В двумерном массиве заменить элементы, у"
    +"которых оба индекса чётные на их квадраты");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int rows =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение: ");
int min =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение: ");
int max =  int.Parse(Console.ReadLine() ?? "0");

int[,] array = EnterMatrix(rows, columns, min, max);
Console.WriteLine("Исходная матрица: ");
PrintMatrix(array, max);
ChangeMatrix(array);
Console.WriteLine("Измененная матрица, где элементы с четными"
    +" координатами изменены на их квадраты: ");
PrintMatrix(array,max);