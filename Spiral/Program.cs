void printMatrix (int[,] Matrix)
{
    for (int i=0; i<Matrix.GetLength(0); i++)
    {
        for (int j=0; j<Matrix.GetLength(1); j++)
            Console.Write($"{Matrix[i,j]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("ВВедите количество строк матрицы: ");
int Row =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("ВВедите количество столбцов матрицы: ");
int Columns =  int.Parse(Console.ReadLine() ?? "0");

int [,] Matrix = new int[Row, Columns];
int direction = 1;
int circle = 0;
int count = 1;

void FillRow(int [,] Matrix, int direction, int circle, int count)
{
    if (count > Row*Columns) return;
    if (direction == 1)
    {
        int i = circle;
        for(int j=0+circle; j<Matrix.GetLength(1); j++)
            if (Matrix[i,j] == 0)
            {
                Matrix[i,j] = count;
                count++;
            }
    }
    else
    {
        int i = Matrix.GetLength(0) - 1 - circle;
        for(int j=Matrix.GetLength(1)-1-circle; j>=0; j--)
            if (Matrix[i,j] == 0)
            {
                Matrix[i,j] = count;
                count++;
            }
    }
    if (circle > (Row+Columns)/2) return;
    FillLine(Matrix, direction, circle, count);
}

void FillLine(int [,] Matrix, int direction, int circle, int count)
{
    if (direction == 1)
    {
        int j = Matrix.GetLength(1) - 1 - circle;
        for(int i = 0 + circle; i<Matrix.GetLength(0); i++)
            if (Matrix[i,j] == 0)
            {
                Matrix[i,j] = count;
                count++;
            }
    }
    else
    {
        int j = circle;
        for(int i = Matrix.GetLength(0) - 1 - circle; i>=0; i--)
            if (Matrix[i,j] == 0)
            {
                Matrix[i,j] = count;
                count++;
            }
        circle++;
    }
    direction *= -1;
    if (circle > (Row+Columns)/2) return;
    FillRow(Matrix, direction, circle, count);
}

FillRow(Matrix, direction, circle, count);

printMatrix(Matrix);