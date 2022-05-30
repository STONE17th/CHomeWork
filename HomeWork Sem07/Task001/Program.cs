void printMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(0); j++)
            Console.Write($"{matrix[i,j]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Написать программу, которая обменивает элементы "
    +"первой строки и последней строки");
Console.Write("Введите количество строк: ");
int sizeCol = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int sizeRow = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[sizeCol,sizeRow];
int[] array = new int[sizeRow];
var rnd = new Random();

for (int i=0; i<sizeCol; i++)
{
    for (int j=0; j<sizeRow; j++)
        matrix[i,j] = rnd.Next(0,100);
    Console.WriteLine();
}

Console.WriteLine($"Оригинальная матрица {sizeCol}х{sizeRow}");
printMatrix (matrix);

for (int i=0; i<sizeRow; i++)
{
    array[i] = matrix[0,i];
    matrix[0,i] = matrix[sizeCol-1,i];
    matrix[sizeCol-1,i] = array[i];
}

Console.WriteLine($"Финальная матрица {sizeCol}х{sizeRow}");
printMatrix (matrix);