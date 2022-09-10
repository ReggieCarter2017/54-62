int s = 4;


    int[,] array = new int[s, s];
    int i = 0;
    int x = 0;
    int y = -1;
    int uD = 0;
    int rL = 1;
   
            while (i < s*s)
                {
                    if (0 <= x + uD && x + uD < s && 0 < y + rL && y + rL < s && array[x + uD, y + rL] == 0)
                    {
                        x += uD;
                        y += rL;
                        array[x, y] = i;
                        i++;
                        Console.Write(i + " ");

                    }
                    else
                    {
                        if(rL == 1)
                        {
                            rL = 0;
                            uD = 1;
                        }
                        else if (uD == 1)
                        {
                            uD = 0;
                            rL = -1;
                        }
                        else if (rL == -1)
                        {
                            rL = 0;
                            uD = -1;
                        }
                        else if (uD == -1)
                        {
                            uD = 0;
                            rL = 1;
                        }
                        i++;
                    }   
                }


