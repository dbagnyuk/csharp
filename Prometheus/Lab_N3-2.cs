using System;

public class SortProblem
{
    public static void Main()
    {
        Sort();
    }

    public static void Sort()
    {
        var a = new[]
        {
      10, 10, 5, 2, 2, 5, 6, 7, 8, 15, 4, 4, 4, 2, 3, 5, 5, 36, 32, 623, 7, 475, 7, 2, 2, 44, 5, 6, 7, 71, 2
    };
        int temp = 0;
        int maxPos = 0;

        //    for (int i = 0; i < a.Length; i++)
        //        Console.Write($"{a[i]} ");
        //    Console.WriteLine();

        for (int i = 0; i < a.Length; i++)
        {
            maxPos = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[maxPos] < a[j])
                {
                    maxPos = j;
                }
            }
            temp = a[i];
            a[i] = a[maxPos];
            a[maxPos] = temp;

            Console.Write($"{maxPos} ");
        }
        Console.WriteLine();

        for (int i = 0; i < a.Length; i++)
            Console.Write($"{a[i]} ");
    }
}
