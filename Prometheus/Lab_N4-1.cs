using System;
using System.Linq;

public class SortProblem
{
    public static void Main(string[] args)
    {
        Sort();
    }

    public static void Sort()
    {
        var a = new[]
        {
                11,86,232,28,8,145,588,1,307,179,77,792,693,678,481,888,574,695,624,866,467,434,907,259,130,37,25,373,214,268,108,672,371,866,863,279,22,233,336,830,374,439,144,234,360,617,244,5,566,847,476,493,56,618,202,576,179,972,898,970,119,214,786,38,71,404,420,827,814,201,865,341,358,794,492,27,290,672,899,512,792,20,807,367,792,615,616,753,663,287,99,49,334,366,711,160,652,105,162,955
            };
        int inversionsCount = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j]) inversionsCount++;
            }
        }
        //            Console.WriteLine($"{inversionsCount}");
        a = myPartition(a);
        for (int i = 0; i < a.Length; i++) Console.Write($"{a[i]} ");
        Console.ReadKey();
    }

    static int[] myPartition(int[] arr)
    {
        var part1 = Enumerable.Range(0, arr.Length / 2).Select(i => arr[i]).ToArray();
        var part2 = Enumerable.Range(0, arr.Length - arr.Length / 2).Select(i => arr[arr.Length / 2 + i]).ToArray();
        if (part1.Length > 1) part1 = myPartition(part1);
        if (part2.Length > 1) part2 = myPartition(part2);

        int prt1Index = 0;
        int prt2Index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (prt2Index == part2.Length || (prt1Index < part1.Length && part1[prt1Index] < part2[prt2Index]))
            {
                arr[i] = part1[prt1Index];
                prt1Index++;
            }
            else
            {
                arr[i] = part2[prt2Index];
                prt2Index++;
            }

        }
        return arr;
    }
}
