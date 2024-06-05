using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 }; 
        int sum = SumArray(array);
        int result = FindNextPowerOfTwo(sum);
        Console.WriteLine($"Наименьшая степень 2, равная или большая суммы чисел в массиве: {result}");
    }

    static int SumArray(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    static int FindNextPowerOfTwo(int number)
    {
        int powerOfTwo = 1;
        while (powerOfTwo < number)
        {
            powerOfTwo *= 2;
        }
        return powerOfTwo;
    }
}
