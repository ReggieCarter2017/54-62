
int a = 2;
int b = 2;
int c = 2;
int[,,] CreatingMassive(int m, int n, int s)
{
    int[,,] array = new int[m, n, s];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }

    return array;   
}

int[,,] array3diment = CreatingMassive(a, b, c);
for (int i = 0; i < array3diment.GetLength(0); i++)
{
    for (int j = 0; j < array3diment.GetLength(1); j++)
    {
        for (int k = 0; k < array3diment.GetLength(2); k++)
        {
            Console.Write($"{array3diment[i, j, k]} ({i}, {j}, {k}) ");
        }
            Console.WriteLine();
    }
}
