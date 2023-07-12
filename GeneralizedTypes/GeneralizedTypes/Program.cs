using System;
using System.Diagnostics;

class Program
{
    public static T CalculateSum<T>(T[] array)
    {
        dynamic sum = default(T);
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public static int CalculateSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        const int N = 1000000;
        int[] array1 = new int[N];
        double[] array2 = new double[N];

        Random rand = new Random();

        for (int i = 0; i < N; i++)
        {
            array1[i] = rand.Next(100);
            array2[i] = rand.NextDouble() * 100;
        }

        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        int sum1 = CalculateSum(array1);
        stopwatch1.Stop();

        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        double sum2 = CalculateSum(array2);
        stopwatch2.Stop();

        Console.WriteLine("Sum1 (int): " + sum1);
        Console.WriteLine("Sum2 (double): " + sum2);
        Console.WriteLine("Time1 (int): " + stopwatch1.Elapsed.TotalMilliseconds + " ms");
        Console.WriteLine("Time2 (double): " + stopwatch2.Elapsed.TotalMilliseconds + " ms");
    }
}
