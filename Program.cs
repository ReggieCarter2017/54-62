int n = 4;
int[,] Snake(int n)
{
    int count = 1;
    int[,] array = new int[n, n];
    int movingLeftRight = 1;
    int movingDownUp = 0;
    int x = 0;
    int y = -1;
        while (count <= n*n)
        {
            if ((0 <= x + movingDownUp && x + movingDownUp < n) && (0 <= y + movingLeftRight && y + movingLeftRight < n) && array[x + movingDownUp, y + movingLeftRight] == 0) 
            {
            x += movingDownUp;
            y += movingLeftRight;
            array[x, y] = count;
            count++;
            }
            else
            {
                if(movingLeftRight == 1)
                {
                    movingLeftRight = 0;
                    movingDownUp = 1;
                }
                else if (movingDownUp == 1)
                {
                    movingDownUp = 0;
                    movingLeftRight = -1;
                }
                else if (movingLeftRight == -1)
                {
                    movingLeftRight = 0;
                    movingDownUp = -1;
                }
                else if (movingDownUp == -1)
                {
                    movingDownUp = 0;
                    movingLeftRight = 1;
                }
            }
        }
        return array;
}
for (int i = 0; i < n; i++)
{
    for (int h = 0; h < n; h++)
    {
        Console.Write(Snake(n)[i, h] + " ");
    }
    Console.WriteLine();
}