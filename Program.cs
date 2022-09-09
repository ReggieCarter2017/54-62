int[,] CreatingMassive(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;   
}
int a = 2;
int b = 2;
int[,] array1 = CreatingMassive(a, b);
int[,] array2 = CreatingMassive(a, b);
void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}
PrintArray(array1);
PrintArray(array2);

int[,] CreateFinalMatrix(int[,] first, int[,] second)
{
    int[,] finalMatrix = new int[first.GetLength(0), first.GetLength(1)];
    for (int i = 0; i < finalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalMatrix.GetLength(1); j++)
        {        int sum = 0;
            for (int s = 0; s < first.GetLength(0); s++)
            {
                sum += array1[i, s] * array2[s, j];
            }
            finalMatrix[i, j] = sum;
        }
    }
    return finalMatrix;
}

PrintArray(CreateFinalMatrix(array1, array2));





