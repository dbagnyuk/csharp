using System;

public class MatrixMult
{
    public static void Main()
    {
        MultiplyMatrix();
    }

    public static void MultiplyMatrix()
    {
        var a = new[,]
        {
      {5, 10, 13, -4, 10},
      {20, 2, 9, 9, -1},
      {5, 10, 4, 8, 14},
      {6, 1, 2, 6, 10},
      {95, 5, 10, 10, 2}
    };
        var b = new[,]
        {
      {5, 10, 8, -4, 62},
      {20, 2, 9, 9, -1},
      {5, 10, 1, 8, 1},
      {6, 1, 2, 6, -5},
      {95, 5, 1, 3, 2}
    };

        var c = new[,]
        {
      {0, 0, 0, 0, 0},
      {0, 0, 0, 0, 0},
      {0, 0, 0, 0, 0},
      {0, 0, 0, 0, 0},
      {0, 0, 0, 0, 0}
    };

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                for (int k = 0; k < 5; k++)
                {
                    c[i, j] += (a[i, k] * b[k, j]);
                }

        for (int i = 0; i < 5; i++)
        {
            Console.Write("|");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(c[i, j] + "|");
            }
            Console.WriteLine();
        }


    }
}
