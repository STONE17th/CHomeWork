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

void MultiMatrix(int [,] FirstMatrix, int [,] SecondMatrix, int [,] WorkMatrix)
{
    for (int i=0; i<WorkMatrix.GetLength(0); i++)
        for (int j=0; j<WorkMatrix.GetLength(1); j++)
            for (int k=0; k<FirstMatrix.GetLength(1); k++)
                WorkMatrix[i,j] += FirstMatrix[i,k]*SecondMatrix[k,j];
}

Console.Clear();
Console.Write("Введите размер первой матрицы (x y), минимальное и максимальное значение, через пробел: ");
string FirstMatrixSettings = Console.ReadLine() ?? "0";
Console.Write("Введите размер второй матрицы (x y), минимальное и максимальное значение, через пробел: ");
string SecondMatrixSettings = Console.ReadLine() ?? "0";
string [] FirstMatrSet = FirstMatrixSettings.Split(" ");
string [] SecondMatrSet = SecondMatrixSettings.Split(" ");
int [] FirstMatrSetting = new int[4];
int [] SecondMatrSetting = new int[4];
for (int i=0; i<4; i++)
{
    FirstMatrSetting[i] = Convert.ToInt32(FirstMatrSet[i]);
    SecondMatrSetting[i] = Convert.ToInt32(SecondMatrSet[i]);
}
int[,] FirstMatrix = new int[FirstMatrSetting[0],FirstMatrSetting[1]];
int[,] SecondMatrix = new int[SecondMatrSetting[0],SecondMatrSetting[1]];
int[,] WorkMatrix = new int[FirstMatrSetting[0],SecondMatrSetting[1]];
fillMatrixRnd(FirstMatrix, FirstMatrSetting);
fillMatrixRnd(SecondMatrix, SecondMatrSetting);

Console.WriteLine("Первая матрица:");
printMatrix(FirstMatrix);
Console.WriteLine("Вторая матрица:");
printMatrix(SecondMatrix);
if (FirstMatrSetting[1] == SecondMatrSetting[0])
{
    MultiMatrix(FirstMatrix, SecondMatrix, WorkMatrix);
    Console.WriteLine("Умноженная матрица:");
    printMatrix(WorkMatrix);
}
else Console.WriteLine("Умножение данных матриц невозможно");