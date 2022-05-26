double[,] EnterMatrix(int rows, int columns)
{
    var rnd = new Random();
    double[,] matrix = new double[rows,columns];
    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            matrix[i,j] = Math.Round(rnd.NextDouble()*100, 2);
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            string Number = "";
            string Max = Convert.ToString(99.99);
            string Num = Convert.ToString(matrix[i,j]);
            while (Number.Length<(Max.Length - Num.Length))
                Number += " ";
            Number += Num;
            Console.Write($"{Number} | ");
        }
    }
}

Console.Clear();
Console.WriteLine("Показать двумерный массив размером m*n заполненный вещественными числами");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк: ");
int rows =  int.Parse(Console.ReadLine() ?? "0");

double[,] array = EnterMatrix(rows, columns);
PrintMatrix(array);


