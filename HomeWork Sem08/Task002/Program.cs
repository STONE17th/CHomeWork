void fillMatrixRnd(int [,] matrix, int [] ArrSettings)
{
    var rnd = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = rnd.Next(ArrSettings[2],ArrSettings[3]);
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

void FindMinElement(int [,] matrix, int [,] NewMatrix)
{
    int MinElement = matrix[0,0];
    int[] MinElementCoord = new int[2];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
            if (matrix[i,j]<MinElement)
            {
                MinElement = matrix[i,j];
                MinElementCoord[0] = i;
                MinElementCoord[1] = j;
            }
        
    }
    for (int i=0; i<NewMatrix.GetLength(0); i++)
    {
        int k = i;
        if (i >= MinElementCoord[0])
            k++;
        for (int j=0; j<NewMatrix.GetLength(1); j++)
        {
            int l = j;
            if (j >= MinElementCoord[1])
                l++;
            NewMatrix[i,j] = matrix[k,l];
        }
    }
    Console.WriteLine($"Минимальный элемент {MinElement} "
        +$"находится в {MinElementCoord[1]+1} столбце {MinElementCoord[0]+1} строке");
}

Console.Clear();
Console.Write("Введите размер массива (x y), минимальное и максимальное значение, через пробел: ");
string ArraySettings = Console.ReadLine() ?? "0";
string [] ArrSet = ArraySettings.Split(" ");
int [] ArrSetting = new int[4];
for (int i=0; i<4; i++)
    ArrSetting[i] = Convert.ToInt32(ArrSet[i]);

int[,] matrix = new int[ArrSetting[0],ArrSetting[1]];
int[,] NewMatrix = new int[ArrSetting[0]-1,ArrSetting[1]-1];
fillMatrixRnd(matrix, ArrSetting);
Console.WriteLine("Исходная матрица:");
printMatrix(matrix);
FindMinElement(matrix, NewMatrix);
Console.WriteLine("Матрица после удаления столбца и строки:");
printMatrix(NewMatrix);