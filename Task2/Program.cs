// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] arr = GetRandomArray(8);
PrintArray(arr);
System.Console.WriteLine(FindCountOfAddPositions(arr));

int FindCountOfAddPositions(int[] array)
{
    int SumofOddIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            SumofOddIndex =SumofOddIndex + array [i];
        }
    }
    return SumofOddIndex;
}

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