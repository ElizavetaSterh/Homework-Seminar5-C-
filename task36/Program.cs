﻿// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumOfOddIn(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

int[] RandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int[] array = RandomArray(7, -10, 10);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine($" = {GetSumOfOddIn(array)}");