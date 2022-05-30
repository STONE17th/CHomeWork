void fillMatrixRnd(int [,] matrix, int min, int max)
{
    var rnd = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = rnd.Next(min,max);
}

void printMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("В прямоугольной матрице найти строку с наименьшей суммой элементов.");
Console.Write("Введите количество столбцов: ");
int sizeRow = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int sizeCol = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[sizeCol,sizeRow];

fillMatrixRnd(matrix,0,100);

Console.WriteLine($"Оригинальная матрица {sizeRow}х{sizeCol}");
printMatrix(matrix);
Console.WriteLine();

int min = int.MaxValue;
int index = 0;
for (int i=0; i<sizeCol; i++)
{
    int[] summa = new int[sizeCol];
    for (int j=0; j<sizeRow; j++)
        summa[i] += matrix[i,j];
    if (summa[i]<min) 
    {
        min = summa[i];
        index = i;
    }
}

Console.WriteLine($"Минимальная сумма элементов в матрице находится на {index+1} строке и равна {min}");