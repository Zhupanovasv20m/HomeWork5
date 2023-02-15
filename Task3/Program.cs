// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] arr = GetRandomArray(8);
PrintArray(arr);
System.Console.WriteLine(MaxNum(arr));
System.Console.WriteLine(MinNum(arr));

int MaxNum(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinNum(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int DifferentOfNum = MaxNum(arr) - MinNum(arr);
System.Console.WriteLine($"{MaxNum(arr)} - {MinNum(arr)} = {DifferentOfNum}");

int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 11);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}