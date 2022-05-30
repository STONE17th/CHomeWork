void printMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]}\t");
        Console.WriteLine();
    }
}

void streamRow(int[] row)
{
 
    for (int j=0; j<row.Length; j++)
        for (int i=0; i<row.Length-1; i++)
            if (row[i+1] > row[i])
            {
                int element = row[i];
                row[i] = row[i+1];
                row[i+1] = element;
            }
}

Console.Clear();
Console.WriteLine("Написать программу, упорядочивания по убыванию "
    +"элементы каждой строки двумерной массива");
    Console.Write("Введите количество столбцов: ");
int sizeRow = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int sizeCol = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[sizeCol,sizeRow];
int[] array = new int[sizeRow];
var rnd = new Random();

for (int i=0; i<sizeCol; i++)
{
    for (int j=0; j<sizeRow; j++)
        matrix[i,j] = rnd.Next(0,100);
    Console.WriteLine();
}

Console.WriteLine($"Оригинальная матрица {sizeRow}х{sizeCol}");
printMatrix (matrix);

for (int i=0; i<sizeCol; i++)
{
    for (int j=0; j<sizeRow; j++)
        array[j] = matrix[i,j];
    streamRow(array);
    for (int j=0; j<sizeRow; j++)
        matrix[i,j] = array[j];
}  

Console.WriteLine($"Упорядоченная матрица {sizeRow}х{sizeCol}");
printMatrix (matrix);