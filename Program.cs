int a = 2;
int b = 2;
int c = 2;
Random random = new Random();
int[,,] CreatingMassive(int m, int n, int s)
{
    int[,,] array = new int[m, n, s];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int temp = random.Next(1,10);
                while (IsDup(temp, array))
                {
                    temp = random.Next(1,10);
                }
                array[i, j, k] = temp;
            }
        }
    }

    return array;   
}

bool IsDup(int temp, int[,,] array)
{
    foreach (var el in array)
    {
        if (el == temp) return true;
    }
    return false;
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
