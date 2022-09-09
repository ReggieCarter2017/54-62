int[,] CreatingMassive(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;   
}
int a = 4;
int b = 3;


string SumOfMin(int[,] twoArray)
{
    int tempResult = 0;
    int[] array = new int[twoArray.GetLength(0)];
    for (int i = 0; i < twoArray.GetLength(0); i++)
        {
            tempResult = 0;

            for (int j = 0; j < twoArray.GetLength(1); j++)
            {
                while (j < twoArray.GetLength(1))
                {
                    tempResult += twoArray[i, j];
                    break;
                }
            }
            array[i] = tempResult;
            Console.Write(array[i] + " \n");
        }
    int minSum = array[0];
    string finalResult = "";
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum) 
        {
            index = i+1;
            minSum = array[i];
        }
        else if (array[0] == minSum) index = 1;
        finalResult = $"{index} -> {minSum}";
    }
        return finalResult;
}

Console.Write(SumOfMin(CreatingMassive(a, b)));
