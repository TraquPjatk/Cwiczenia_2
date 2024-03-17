using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 15, 20, 25 };
        Console.WriteLine(CalculateAverage(numbers));
    }

    static double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int sum = 0;
        foreach (int value123 in array)
        {
            sum += value123;
        }

        return (double)sum / array.Length;
    }

    static int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
