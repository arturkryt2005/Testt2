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

//Общая сложность Сложность вычисления суммы массива: 𝑂 ( 𝑛 )
//Сложность нахождения наименьшей степени 2: 𝑂 (log ⁡ 𝑆 ) 
//Итак, общая временная сложность алгоритма будет 𝑂 ( 𝑛 + log ⁡ 𝑆 ) 
//Пояснение коду 
//    Ввод данных: 
//Массив array задается в коде (можно изменить на ввод с клавиатуры). 
//Метод SumArray: Вычисляет сумму элементов массива. 
//Метод FindNextPowerOfTwo: Находит наименьшую степень 2, которая больше или равна заданному числу: Начинаем с 1 и удваиваем, пока не достигнем или не превзойдем число.