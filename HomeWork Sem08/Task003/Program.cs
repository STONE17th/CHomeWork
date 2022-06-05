void fillMatrixRnd(int[,,] Array3D, int [] array)
{
    int NewElement = 0;
    string AllElements = "";
    var rnd = new Random();
    for (int i=0; i<Array3D.GetLength(0); i++)
        for (int j=0; j<Array3D.GetLength(1); j++)
            for (int k=0; k<Array3D.GetLength(2); k++)
            {
                NewElement = rnd.Next(array[3],array[4]);
                while (AllElements.Contains(Convert.ToString(NewElement)))
                    NewElement = rnd.Next(array[3],array[4]);
                Array3D[i,j,k] = NewElement;
                AllElements += $"{NewElement}, ";
            }
}

void printMatrix (int[,,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"Столбец {i+1} строка {j+1}\t");
            for (int k=0; k<matrix.GetLength(2); k++)
                Console.Write($"{matrix[i,j,k]}\t");
            Console.WriteLine();    
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива (x y z), минимальное и максимальное значение, через пробел: ");
string ArraySettings = Console.ReadLine() ?? "0";
string [] ArrSet = ArraySettings.Split(" ");
int [] ArrSetting = new int[5];
for (int i=0; i<5; i++)
    ArrSetting[i] = Convert.ToInt32(ArrSet[i]);

int[,,] Array3D = new int[ArrSetting[0],ArrSetting[1],ArrSetting[2]];
fillMatrixRnd(Array3D, ArrSetting);
printMatrix(Array3D);