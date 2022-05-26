int[,] EnterMatrix(int rows, int columns)
{
var rnd = new Random();
int[,] matrix = new int[rows,columns];
for (int i=0; i<rows; i++)
    for (int j=0; j<columns; j++)
        matrix[i,j] = i+j;
return matrix;
}

void PrintMatrix(int[,] matrix, int MaxValue)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            string Number = "";
            string Max = Convert.ToString(MaxValue);
            string Num = Convert.ToString(matrix[i,j]);
            while (Number.Length<(Max.Length - Num.Length))
                Number += " ";
            Number += Num;
            Console.Write($"{Number} | ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задать двумерный массив следующим правилом: A(m,n) = m+n");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int rows =  int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Матрица в которой значение элементов равно сумме их индексов:");
int[,] array = EnterMatrix(rows, columns);
PrintMatrix(array, rows+columns);


