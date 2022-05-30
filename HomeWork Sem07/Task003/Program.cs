void fillMatrixRnd(int [,] matrix)
{
    var rnd = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = rnd.Next(0,100);
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

void rotateMatrix(int[,] matrix)
{
    int[,] NewMatrix = new int[matrix.GetLength(0),matrix.GetLength(0)];
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=i; j<matrix.GetLength(1); j++)
        {
            int value = matrix[j,i];
            matrix[j,i] = matrix[i,j];
            matrix[i,j] = value;
        }
}
            
      

Console.Clear();
Console.WriteLine("Написать программу, которая в двумерном массиве заменяет "
    +"строки на столбцы или сообщить, что это невозможно "
        +"(в случае, если матрица не квадратная).");
Console.Write("Введите количество столбцов: ");
int sizeRow = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int sizeCol = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[sizeCol,sizeRow];

fillMatrixRnd(matrix);

Console.WriteLine($"Оригинальная матрица {sizeRow}х{sizeCol}");
printMatrix(matrix);
Console.WriteLine();


if (sizeCol != sizeRow)
    Console.WriteLine($"В данной матрице невозможно поменять значения строк и столбцов");
else
{
    Console.WriteLine("Перевернутая матрица:");
    rotateMatrix(matrix);
    printMatrix(matrix);
}